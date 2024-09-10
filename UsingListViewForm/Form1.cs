using System.Data.SqlClient;

namespace UsingListViewForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection consql;
        string constr;

        void connection()
        {
            constr = "Data Source=DESKTOP-L3SMK21\\SQLEXPRESS;Initial Catalog=UsingListView;Integrated Security=True";
            consql = new SqlConnection(constr);
            consql.Open();
        }

        void ClearTextBox()
        {
            txtRNum.Text = "";
            txtName.Text = "";
            cboSubject.Text = "";
            txtMarks.Text = "0";
            txtTotalMark.Text = "0";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection();
            ClearTextBox();
            lstMarks.Columns.Add("Roll No", 100);
            lstMarks.Columns.Add("Name", 300);
            lstMarks.Columns.Add("Subject", 200);
            lstMarks.Columns.Add("Marks", 200);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ListViewItem lvMarks = new ListViewItem(txtRNum.Text);
            lvMarks.SubItems.Add(txtName.Text);
            lvMarks.SubItems.Add(cboSubject.Text);
            lvMarks.SubItems.Add(txtMarks.Text);

            lstMarks.Items.Add(lvMarks);
            txtTotalMark.Text = (int.Parse(txtMarks.Text) + int.Parse(txtTotalMark.Text)).ToString();
            cboSubject.Text = "";
            txtMarks.Text = "0";
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            int marks, tMarks;
            marks = Convert.ToInt32(lstMarks.Items[lstMarks.FocusedItem.Index].SubItems[3].Text);
            tMarks = Convert.ToInt32(txtTotalMark.Text);
            txtTotalMark.Text = (tMarks - marks).ToString();
            lstMarks.Items[lstMarks.FocusedItem.Index].Remove();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= lstMarks.Items.Count-1; i++)
            {
                string rollno = lstMarks.Items[i].SubItems[0].Text;
                string name  = lstMarks.Items[i].SubItems[1].Text;
                string subject = lstMarks.Items[i].SubItems[2].Text;
                string marks = lstMarks.Items[i].SubItems[3].Text;

                string SaveStr = "INSERT INTO Students" + " VALUES ('" + rollno + "', '" + name + "', '" + subject + "', '" + marks + "')";
                SqlCommand save = new SqlCommand(SaveStr, consql);
                save.ExecuteNonQuery();
            }

            MessageBox.Show("Finish saving new information", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
