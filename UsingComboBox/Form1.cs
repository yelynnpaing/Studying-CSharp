using System.Data;
using System.Data.SqlClient;

namespace UsingComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection consql;
        string constr;

        void Connection()
        {
            constr = "Data Source=DESKTOP-L3SMK21\\SQLEXPRESS;Initial Catalog=CustomerCRUD;Integrated Security=True";
            consql = new SqlConnection(constr);
            consql.Open();
        }

        void FillCustomer()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customers", consql);
            DataSet ds = new DataSet();
            DataTable dt;
            adapter.Fill(ds, "Customers");
            dt = ds.Tables["Customers"];
            cboCusID.DataSource = dt;
            cboCusID.DisplayMember = dt.Columns["CusID"].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection();
            FillCustomer();
        }

        private void cboCusID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "SELECT CusName FROM Customers WHERE CusID='"+cboCusID.Text+"'";
            SqlDataAdapter adapterCus = new SqlDataAdapter(str, consql);
            DataSet dsCus = new DataSet();
            adapterCus.Fill(dsCus, "CName");
            txtCusName.Text = dsCus.Tables["CName"].Rows[0][0].ToString();
            cboCusID.Focus();
        }
    }
}
