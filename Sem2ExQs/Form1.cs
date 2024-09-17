namespace Sem2ExQs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            lvData.Columns.Add("Name", 200);
            lvData.Columns.Add("Address", 250);
            lvData.Columns.Add("Phone", 150);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ListViewItem lvNames = new ListViewItem(txtName.Text);
            lvNames.SubItems.Add(txtAddress.Text);
            lvNames.SubItems.Add(txtPhone.Text);

            lvData.Items.Add(lvNames);
            Clear();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            lvData.Items[lvData.FocusedItem.Index].Remove();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
