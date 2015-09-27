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
    public partial class frm_OrderInfo : Form
    {

        //Database Connection
        public OleDbConnection _dbConnection;

        public frm_OrderInfo()
        {
            InitializeComponent();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchOrder();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_ViewCustomerInfo_Click(object sender, EventArgs e)
        {
            frm_CustomerInfo frm_CustomerSearch = new frm_CustomerInfo();
            frm_CustomerSearch.Show();
            frm_CustomerSearch._dbConnection = _dbConnection;
            frm_CustomerSearch.txt_Search.Text = txt_CustomerId.Text;
            frm_CustomerSearch.SearchCustomer();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        public void SearchOrder()
        {
            if (txt_Search.Text == "" || txt_Search.Text == "NO ORDERS FOUND")
            {
                MessageBox.Show("Order not found.");
            }
            else
            { 
                //Create OldeDb Command
                OleDbCommand command = new OleDbCommand();
                command.Connection = _dbConnection;

                //Query Database for Customer Info Count
                command.CommandText = "SELECT count(*) FROM Orders WHERE OrderID=" + txt_Search.Text;
                int rowCount = (int)command.ExecuteScalar();

                //Query Database for Customer Info
                command.CommandText = "SELECT * FROM Orders WHERE OrderID=" + txt_Search.Text;
                OleDbDataReader reader = command.ExecuteReader();

                //Read Results
                if (rowCount > 0)
                {
                    while (reader.Read())
                    {

                        txt_OrderId.Text = reader.GetValue(0).ToString();
                        txt_CustomerId.Text = reader.GetValue(1).ToString();
                        txt_AccountRep.Text = reader.GetValue(2).ToString();
                        txt_OrderDate.Text = reader.GetValue(3).ToString();
                        txt_ShippedDate.Text = reader.GetValue(4).ToString();
                        txt_ShippedBy.Text = reader.GetValue(5).ToString();
                        txt_Freight.Text = reader.GetValue(6).ToString();
                        txt_ShipName.Text = reader.GetValue(7).ToString();
                        txt_ShipAddress.Text = reader.GetValue(8).ToString();
                        txt_ShipCity.Text = reader.GetValue(9).ToString();
                        txt_ShipRegion.Text = reader.GetValue(10).ToString();
                        txt_ShipPostalCode.Text = reader.GetValue(11).ToString();
                        txt_ShipCountry.Text = reader.GetValue(12).ToString();
                        txt_RequiredDate.Text = reader.GetValue(13).ToString();
                        if (txt_RequiredDate.Text == "")
                        {
                            txt_RequiredDate.Text = "NA";
                        }

                    }

                }
                else
                {
                    txt_OrderId.Text = "NA";
                    txt_CustomerId.Text = "NA";
                    txt_AccountRep.Text = "NA";
                    txt_OrderDate.Text = "NA";
                    txt_ShippedDate.Text = "NA";
                    txt_ShippedBy.Text = "NA";
                    txt_Freight.Text = "NA";
                    txt_ShipName.Text = "NA";
                    txt_ShipAddress.Text = "NA";
                    txt_ShipCity.Text = "NA";
                    txt_ShipRegion.Text = "NA";
                    txt_ShipPostalCode.Text = "NA";
                    txt_ShipCountry.Text = "NA";
                    txt_RequiredDate.Text = "NA";
                }

                //Close Reader
                reader.Close();
  
            }
        }
    }
}
