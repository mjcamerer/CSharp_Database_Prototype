using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Database_Prototype
{
    public partial class frm_AdvancedCustomerSearch : Form
    {
        //Database Connection
        public OleDbConnection _dbConnection;

        public frm_AdvancedCustomerSearch()
        {
            InitializeComponent();
        }

        private void btn_SeachCustomerID_Click(object sender, EventArgs e)
        {
            frm_CustomerInfo frm = new frm_CustomerInfo();
            frm.Show();
            frm._dbConnection = _dbConnection;
            frm.txt_Search.Text = txt_CustomerId.Text;
            frm.SearchCustomer();
        }

        private void btn_SearchName_Click(object sender, EventArgs e)
        {
            if (txt_FirstName.Text == "" || txt_LastName.Text == "")
            {
                MessageBox.Show("Please enter both a First and Last name before searching.");
            }
            else
            {
                //Create OldeDb Command
                OleDbCommand command = new OleDbCommand();
                command.Connection = _dbConnection;

                //Query Database for Customer Info Count
                command.CommandText = "SELECT count(CustomerID) FROM Customers WHERE FirstName=\"" + txt_FirstName.Text + "\" AND LastName=\"" + txt_LastName.Text + "\"";
                int rowCount = (int)command.ExecuteScalar();

                //Query Database for Customer Info
                command.CommandText = "SELECT CustomerID FROM Customers WHERE FirstName=\"" + txt_FirstName.Text + "\" AND LastName=\"" + txt_LastName.Text + "\"";
                OleDbDataReader reader = command.ExecuteReader();

                //Read Results
                if (rowCount > 0)
                {
                    while (reader.Read())
                    {

                        frm_CustomerInfo frm = new frm_CustomerInfo();
                        frm.Show();
                        frm._dbConnection = _dbConnection;
                        frm.txt_Search.Text = reader.GetValue(0).ToString();
                        if (frm.txt_Search.Text == "")
                        {
                            frm.txt_Search.Text = "NOT FOUND";
                        }
                        else
                        {
                            frm.SearchCustomer();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Customer \"" + txt_FirstName.Text + " " + txt_LastName.Text + "\" not found.");
                }

                //Close Reader
                reader.Close();
            }

        }

        private void btn_SearchPhoneNumber_Click(object sender, EventArgs e)
        {
            if (txt_PhoneNumber.Text == "")
            {
                MessageBox.Show("Please enter a Phone Number before searching.");
            }
            else
            {
                //Create OldeDb Command
                OleDbCommand command = new OleDbCommand();
                command.Connection = _dbConnection;

                //Query Database for Customer Info Count
                command.CommandText = "SELECT count(CustomerID) FROM Customers WHERE PhoneNumber=\"" + txt_PhoneNumber.Text + "\"";
                int rowCount = (int)command.ExecuteScalar();

                //Query Database for Customer Info
                command.CommandText = "SELECT CustomerID FROM Customers WHERE PhoneNumber=\"" + txt_PhoneNumber.Text + "\"";
                OleDbDataReader reader = command.ExecuteReader();

                //Read Results
                if (rowCount > 0)
                {
                    while (reader.Read())
                    {

                        frm_CustomerInfo frm = new frm_CustomerInfo();
                        frm.Show();
                        frm._dbConnection = _dbConnection;
                        frm.txt_Search.Text = reader.GetValue(0).ToString();
                        if (frm.txt_Search.Text == "")
                        {
                            frm.txt_Search.Text = "NOT FOUND";
                        }
                        else
                        {
                            frm.SearchCustomer();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Customer Phone Number \"" + txt_PhoneNumber.Text +  "\" not found.");
                }

                //Close Reader
                reader.Close();
            }
        }
    }
}
