using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2ExQs
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection consql;
        string constr;

        void Connection()
        {
            constr = "Data Source=DESKTOP-L3SMK21\\SQLEXPRESS;Initial Catalog=StockCRUD;Integrated Security=True";
            consql = new SqlConnection(constr);
            consql.Open();
        }

        private void Setting()
        {
            dgStock.Columns[0].HeaderText = "Stock ID";
            dgStock.Columns[1].HeaderText = "Stock Name";
            dgStock.Columns[2].HeaderText = "Price";
            dgStock.Columns[3].HeaderText = "Quantity";

            dgStock.Columns[0].Width = 100;
            dgStock.Columns[1].Width = 200;
            dgStock.Columns[2].Width = 100;
            dgStock.Columns[3].Width = 100;
        }

        void FillStock()
        {
            string query = "SELECT * FROM Stocks";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet dset = new DataSet();
            adapter.Fill(dset);
            dgStock.DataSource = dset.Tables[0];

            Setting();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtStockName.Text = "";
            Connection();
            FillStock();
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            txtStockName.Text = "";
            FillStock();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Stocks WHERE StockName='" + txtStockName.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet dset = new DataSet();
            adapter.Fill(dset);
            dgStock.DataSource = dset.Tables[0];
            Setting();
        }
    }
}
