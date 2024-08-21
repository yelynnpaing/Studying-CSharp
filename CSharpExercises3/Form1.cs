namespace CSharpExercises3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sumBtn_Click(object sender, EventArgs e)
        {
            int result = 0;
            
            for(int i = 1; i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                    result += i;
                }
            }

            resultTxt.Text = result.ToString();
        }
    }
}
