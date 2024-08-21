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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void substring_Click(object sender, EventArgs e)
        {
            txtSecondString.Text = txtFirstString.Text.Substring(1, 5);
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
