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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void stratBtn_Click(object sender, EventArgs e)
        {
            Boolean str;
            str = txtString.Text.StartsWith(txtStarts.Text);

            MessageBox.Show(str.ToString(), "Start with", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtString.Text = "";
            txtStarts.Text = "";
            txtString.Focus();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
