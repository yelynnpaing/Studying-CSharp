using System.Data;
using System.Data.SqlClient;

namespace SearchingDatas
{
    public partial class SearchingDatas : Form
    {
        public SearchingDatas()
        {
            InitializeComponent();
        }

        SqlConnection consql;
        string constr;
        DataTable dtStock;

        void connection()
        {
            constr = "Data Source=DESKTOP-L3SMK21\\SQLEXPRESS;Initial Catalog=StockCRUD;Integrated Security=True";
            consql = new SqlConnection(constr);
            consql.Open();
        }

        private void setting()
        {
            dgStock.Columns[0].HeaderText = "Stock ID";
            dgStock.Columns[1].HeaderText = "Stock Name";
            dgStock.Columns[2].HeaderText = "Price";
            dgStock.Columns[3].HeaderText = "Quantity";

            dgStock.Columns[0].Width = 100;
            dgStock.Columns[1].Width = 250;
            dgStock.Columns[2].Width = 120;
            dgStock.Columns[3].Width = 120;
        }

        private void SearchingDatas_Load(object sender, EventArgs e)
        {
            connection();
            string query = "SELECT * FROM Stocks";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "stock");
            dtStock = ds.Tables["stock"];
            dgStock.DataSource = dtStock;
            setting();
        }

        private void serachBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Stocks WHERE StockID='" + txtStockID.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "stock");
            dtStock = ds.Tables["stock"];
            dgStock.DataSource = dtStock;
            setting();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtStockID.Text = "";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
