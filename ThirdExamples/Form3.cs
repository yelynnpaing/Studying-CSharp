using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdExamples
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            int check;
            check = txtFirstString.Text.CompareTo(txtSecondString.Text);
            if (check == 0)
            {
                MessageBox.Show("The two string are the same", "String compare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The two string are not same", "String compare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtFirstString.Text = "";
            txtSecondString.Text = "";
            txtFirstString.Focus();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
