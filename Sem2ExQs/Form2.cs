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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection consql;
        string constr;
        DataSet Dset;

        void Connection()
        {
            constr = "Data Source=DESKTOP-L3SMK21\\SQLEXPRESS;Initial Catalog=SemTwoExQTwo;Integrated Security=True";
            consql = new SqlConnection(constr);
            consql.Open();
        }

        private void FillData()
        {
            string query = "SELECT * FROM Customers";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            Dset = new DataSet();
            adapter.Fill(Dset);
            dgCustomer.DataSource = Dset.Tables[0];

            dgCustomer.Columns[0].HeaderText = "Customer ID";
            dgCustomer.Columns[1].HeaderText = "Customer Name";

            dgCustomer.Columns[0].Width = 200;
            dgCustomer.Columns[1].Width = 250;
        }

        void ClearText()
        {
            txtCusId.Text = "";
            txtCusName.Text = "";
        }
        void AutoID()
        {

            string CName;
            int CId;
            SqlDataAdapter ad = new SqlDataAdapter("SELECT CusID FROM Customers ORDER BY CusID", consql);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                CName = ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1][0].ToString();
                CId = int.Parse(CName.Substring(2, (CName.Length - 2)));
                txtCusId.Text = "C_" + ((CId + 1).ToString("0000000"));
            }
            else
            {
                txtCusId.Text = "C_0000001";
            }

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Connection();
            FillData();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            ClearText();
            AutoID();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string strInsert = "INSERT INTO Customers VALUES ('" + txtCusId.Text + "', '" + txtCusName.Text + "')";
            SqlCommand cmd = new SqlCommand(strInsert, consql);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Save Data");
            FillData();
        }

        private void dgCustomer_Click(object sender, EventArgs e)
        {
            int i;
            i = dgCustomer.CurrentRow.Index;
            txtCusId.Text = Dset.Tables[0].Rows[i][0].ToString();
            txtCusName.Text = Dset.Tables[0].Rows[i][1].ToString();
        }
    }
}
