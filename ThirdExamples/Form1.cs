namespace ThirdExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            nameTxt.Text = "";
            txtLength.Text = "";
            nameTxt.Focus();
        }

        private void length_Click(object sender, EventArgs e)
        {
            string str = nameTxt.Text;
            txtLength.Text = str.Length.ToString();
        }
    }
}
