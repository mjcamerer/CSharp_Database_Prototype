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
    public partial class frm_Main : Form
    {
        //Database Connection Field
        public OleDbConnection _dbConnection = new OleDbConnection();

        public frm_Main()
        {
            InitializeComponent();

            //Connection String
            _dbConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=GardenCompany13.accdb;Persist Security Info=False;";

        }

        private void btn_SearchCustomerId_Click(object sender, EventArgs e)
        {
            frm_CustomerInfo frm_CustomerSearch = new frm_CustomerInfo();
            frm_CustomerSearch.Show();
            frm_CustomerSearch._dbConnection = _dbConnection;
            frm_CustomerSearch.txt_Search.Text = txt_CustomerId.Text;
            frm_CustomerSearch.SearchCustomer();
        }

        private void btn_SearchOrderId_Click(object sender, EventArgs e)
        {
            frm_OrderInfo frm_OrderSearch = new frm_OrderInfo();
            frm_OrderSearch.Show();
            frm_OrderSearch._dbConnection = _dbConnection;
            frm_OrderSearch.txt_Search.Text = txt_OrderId.Text;
            frm_OrderSearch.SearchOrder();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            //Open Database Connection
            try
            {
                _dbConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btn_AdvancedCustomerId_Click(object sender, EventArgs e)
        {
            frm_AdvancedCustomerSearch frm = new frm_AdvancedCustomerSearch();
            frm.Show();
            frm._dbConnection = _dbConnection;
        }
    }
}
