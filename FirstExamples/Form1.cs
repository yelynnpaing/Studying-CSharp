namespace TestOne
{
    public partial class P9eg : Form
    {
        public P9eg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TestOne_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFristNum.Clear();
            txtSecondNum.Clear();
            txtAns.Clear(); 
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int first, second, ans;
            first = int.Parse(txtFristNum.Text);
            second = int.Parse(txtSecondNum.Text);
            ans = first + second;
            txtAns.Text = ans.ToString();
        }
    }
}
