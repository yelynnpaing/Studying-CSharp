using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondExamples
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjectList.Items.Clear();
            if (examCbo.Text == "Semester I")
            {
                subjectList.Items.Add("Computer Concept");
                subjectList.Items.Add("Simple Program Design");
                subjectList.Items.Add("Information System");
                subjectList.Items.Add("Web Technology");
            }
            else
            {
                subjectList.Items.Add("Networking");
                subjectList.Items.Add("C#");
                subjectList.Items.Add("Database Management System");
                subjectList.Items.Add("Computer Concept");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            subjectList.Items.Clear();
        }

        private void subjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
