namespace SecondExamples
{
    public partial class FindeGrade : Form
    {
        public FindeGrade()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void findGradeBtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtNum.Text) < 300)
            {
                MessageBox.Show("Grade I", "Grade Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (int.Parse(txtNum.Text) <= 400)
            {
                MessageBox.Show("Grade II", "Grade Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Grade III", "Grade Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FindeGrade_Load(object sender, EventArgs e)
        {

        }
    }
}
