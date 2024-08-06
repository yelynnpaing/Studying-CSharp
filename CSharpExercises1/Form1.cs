using System.Xml.XPath;

namespace CSharpExercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, result;
            num = int.Parse(txtNum.Text);
            result = num * num;
            rTxtNum.Text = result.ToString();
        }

        private void cube_Click(object sender, EventArgs e)
        {
            int num, result;
            num = int.Parse(txtNum.Text);
            result = num * num * num;
            rTxtNum.Text = result.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            rTxtNum.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
