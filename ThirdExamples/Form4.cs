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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void ToLowerBtn_Click(object sender, EventArgs e)
        {
            txtSecondString.Text = txtFirstString.Text.ToLower();
        }

        private void ToUpperBtn_Click(object sender, EventArgs e)
        {
            txtSecondString.Text = txtFirstString.Text.ToUpper();
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
