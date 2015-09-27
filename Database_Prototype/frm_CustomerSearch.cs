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
    public partial class frm_CustomerInfo : Form
    {
        //Database Connection
        public OleDbConnection _dbConnection;

        public frm_CustomerInfo()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchCustomer();
        }

        public void SearchCustomer()
        {
            //string[] names = new string[2];
            //names = txt_Search.Text.Split();

            //Create OldeDb Command
            OleDbCommand command = new OleDbCommand();
            command.Connection = _dbConnection;

            //Query Database for Customer Info Count
            command.CommandText = "SELECT count(*) FROM Customers WHERE CustomerID=\"" + txt_Search.Text + "\"";
            int rowCount = (int)command.ExecuteScalar();

            //Query Database for Customer Info
            command.CommandText = "SELECT * FROM Customers WHERE CustomerID=\"" + txt_Search.Text + "\"";
            OleDbDataReader reader = command.ExecuteReader();

            //Read Results
            if (rowCount > 0)
            {
                while (reader.Read())
                {

                    txt_CustomerId.Text = reader.GetValue(0).ToString();
                    txt_FirstName.Text = reader.GetValue(1).ToString();
                    txt_LastName.Text = reader.GetValue(2).ToString();
                    txt_Address.Text = reader.GetValue(3).ToString();
                    txt_City.Text = reader.GetValue(4).ToString();
                    txt_StateRegion.Text = reader.GetValue(5).ToString();
                    txt_PostalCode.Text = reader.GetValue(6).ToString();
                    txt_Country.Text = reader.GetValue(7).ToString();
                    txt_PhoneNumber.Text = reader.GetValue(8).ToString();

                }

            }
            else
            {
                txt_CustomerId.Text = "NA";
                txt_FirstName.Text = "NA";
                txt_LastName.Text = "NA";
                txt_Address.Text = "NA";
                txt_City.Text = "NA";
                txt_StateRegion.Text = "NA";
                txt_PostalCode.Text = "NA";
                txt_Country.Text = "NA";
                txt_PhoneNumber.Text = "NA";

                MessageBox.Show("Customer ID \"" + txt_Search.Text + "\" not found.");
            }

            //Close Reader
            reader.Close();

            //Clear Order ComboBox
            cmb_Orders.Items.Clear();

            //Query Database for Customer Order Count
            command.CommandText = "SELECT count(OrderID) FROM Orders WHERE CustomerID=\"" + txt_Search.Text + "\"";
            rowCount = (int)command.ExecuteScalar();

            //Query Database for Customer Orders
            command.CommandText = "SELECT OrderID FROM Orders WHERE CustomerID=\"" + txt_Search.Text + "\"";
            reader = command.ExecuteReader();

            //Read Results
            while (reader.Read())
            {
                for (int i = 0; i < rowCount; i++)
                {
                    cmb_Orders.Items.Add(reader.GetValue(i).ToString());
                }
            }

            //Set Order ComboBox Text to first order
            if (cmb_Orders.Items.Count > 0)
            {
                cmb_Orders.Text = cmb_Orders.Items[0].ToString();
            }
            else
            {
                cmb_Orders.Text = "NO ORDERS FOUND";
            }

            //Close Reader
            reader.Close();
        }

        private void btn_ViewOrderInfo_Click(object sender, EventArgs e)
        {
            frm_OrderInfo frm = new frm_OrderInfo();
            frm.Show();
            frm._dbConnection = _dbConnection;
            frm.txt_Search.Text = cmb_Orders.Text;
            frm.SearchOrder();
        }
    }
}
