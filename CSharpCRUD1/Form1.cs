using System.Data;
using System;
using System.Data.SqlClient;

namespace CSharpCRUD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection consql;
        string str;
        DataSet Dset;

        private void Form1_Load(object sender, EventArgs e)
        {
            str = "Data Source=DESKTOP-L3SMK21\\SQLEXPRESS;Initial Catalog=CustomerCRUD;Integrated Security=True";
            consql = new SqlConnection(str);
            consql.Open();

            FillData();
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
            dgCustomer.Columns[2].HeaderText = "NRC";
            dgCustomer.Columns[3].HeaderText = "Address";
            dgCustomer.Columns[4].HeaderText = "Phone";

            dgCustomer.Columns[0].Width = 120;
            dgCustomer.Columns[1].Width = 200;
            dgCustomer.Columns[2].Width = 120;
            dgCustomer.Columns[3].Width = 300;
            dgCustomer.Columns[4].Width = 120;
        }

        void AutoID()
        {
            string CName;
            int CID;
            SqlDataAdapter ad = new SqlDataAdapter("SELECT CusID FROM Customers ORDER BY CusID", consql);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            if(ds.Tables[0].Rows.Count > 0)
            {
                CName = ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1][0].ToString();
                CID = int.Parse(CName.Substring(2, (CName.Length - 2)));
                txtCusID.Text = "C_" + ((CID + 1).ToString("0000000"));
            }
            else
            {
                txtCusID.Text = "C_0000001";
            }
        }

        void ClearText()
        {
            txtCusID.Text = "";
            txtCusName.Text = "";
            txtNRC.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            ClearText();
            AutoID();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string strInsert = "INSERT INTO Customers VALUES('"+txtCusID.Text+"','"+txtCusName.Text+"','"+txtNRC.Text+"','"+txtAddress.Text+"','"+txtPhone.Text+"')";
            SqlCommand cmd = new SqlCommand(strInsert, consql);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Finish save customer information", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillData();
        }

        private void dgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgCustomer.CurrentRow.Index;
            txtCusID.Text = Dset.Tables[0].Rows[i][0].ToString();
            txtCusName.Text = Dset.Tables[0].Rows[i][1].ToString();
            txtNRC.Text = Dset.Tables[0].Rows[i][2].ToString();
            txtAddress.Text = Dset.Tables[0].Rows[i][3].ToString();
            txtPhone.Text = Dset.Tables[0].Rows[i][4].ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string str = "UPDATE Customers SET CusName='"+txtCusName.Text+"',NRC='"+txtNRC.Text+"',Address='"+txtAddress.Text+"',Phone='"+txtPhone.Text+"' WHERE CusID='"+txtCusID.Text+"'";
            SqlCommand mycmd = new SqlCommand(str, consql);
            mycmd.ExecuteNonQuery();
            MessageBox.Show("Finish update customer information", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillData();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string str = "DELETE FROM Customers WHERE CusID='"+txtCusID.Text+"'";
            SqlCommand mycmd = new SqlCommand(str, consql);
            mycmd.ExecuteNonQuery();
            MessageBox.Show("Finish delete customer information", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillData();
            ClearText();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
