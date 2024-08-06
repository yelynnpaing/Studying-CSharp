namespace CSharpExercises2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findMaxiBtn_Click(object sender, EventArgs e)
        {
            int int1, int2, result;
            int1 = int.Parse(txtFirstInt.Text);
            int2 = int.Parse(txtSecondInt.Text);

            if (int1 > int2)
            {
                result = int1;
            }
            else
            {
                result = int2;
            }

            txtResult.Text = result.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
