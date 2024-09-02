using System.Data.SqlClient;
using System.Data;

namespace SimpleStockInfoEntry
{
    public partial class stockForm : Form
    {
        public stockForm()
        {
            InitializeComponent();
        }

        SqlConnection consql;
        string conStr;
        DataTable dtStock;

        void connection()
        {
            conStr = "Data Source=DESKTOP-L3SMK21\\SQLEXPRESS;Initial Catalog=StockCRUD;Integrated Security=True";
            consql = new SqlConnection(conStr);
            consql.Open();
        }

        void AutoID()
        {
            string OID = "SELECT StockID FROM Stocks ORDER BY StockID";
            string MName;
            int MID;
            string format = "0000000";
            SqlDataAdapter ad = new SqlDataAdapter(OID, consql);
            DataSet ds = new DataSet();
            ad.Fill(ds, "Stocks");
            if (ds.Tables["Stocks"].Rows.Count > 0)
            {
                MName = ds.Tables["Stocks"].Rows[ds.Tables["Stocks"].Rows.Count - 1][0].ToString();
                MID = int.Parse(MName.Substring(1, (MName.Length - 1)));
                txtStockId.Text = "S" + ((MID + 1).ToString(format));
            }
            else
            {
                txtStockId.Text = "S0000001";
            }
        }

        private void fillData()
        {
            string query = "SELECT * FROM Stocks";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet Dset = new DataSet();
            adapter.Fill(Dset, "stock");
            dtStock = Dset.Tables["stock"];
            dgStock.DataSource = dtStock;

            dgStock.Columns[0].HeaderText = "Stock ID";
            dgStock.Columns[1].HeaderText = "Stock Name";
            dgStock.Columns[2].HeaderText = "Price";
            dgStock.Columns[3].HeaderText = "Quantity";

            dgStock.Columns[0].Width = 100;
            dgStock.Columns[1].Width = 200;
            dgStock.Columns[2].Width = 120;
            dgStock.Columns[3].Width = 200;
        }

        void clearText()
        {
            txtStockId.Clear();
            txtStockName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection();
            fillData();
            clearText();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            clearText();
            AutoID();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string str = "INSERT INTO Stocks VALUES ('" + txtStockId.Text + "','" + txtStockName.Text + "','" + txtPrice.Text + "','" + txtQuantity.Text + "')";
            SqlCommand mycmd = new SqlCommand(str, consql);
            mycmd.ExecuteNonQuery();

            MessageBox.Show("Finish");
            fillData();
        }

        private void dgStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr;
            int i;
            i = dgStock.CurrentRow.Index;
            dr = dtStock.Rows[i];
            txtStockId.Text = dr[0].ToString();
            txtStockName.Text = dr[1].ToString();
            txtPrice.Text = dr[2].ToString();
            txtQuantity.Text = dr[3].ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string str = "UPDATE Stocks SET StockName='" + txtStockName.Text + "',Price='" + txtPrice.Text + "',Quantity='" + txtQuantity.Text + "' WHERE StockID='" + txtStockId.Text + "'";
            SqlCommand mycmd = new SqlCommand(str, consql);
            mycmd.ExecuteNonQuery();
            MessageBox.Show("Finish");
            fillData();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string str = "DELETE FROM Stocks WHERE StockID='" + txtStockId.Text + "' ";
            SqlCommand mycmd = new SqlCommand(str, consql);
            mycmd.ExecuteNonQuery();
            MessageBox.Show("Finish delete this record.", "Delete Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillData();
            clearText();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
