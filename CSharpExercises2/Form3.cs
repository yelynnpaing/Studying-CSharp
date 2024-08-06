using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpExercises2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            int y;

            lbResult.Items.Clear();
            y = int.Parse(txtYear.Text);

            if (y % 4 == 0)
            {
                if (cboMonth.Text == "January")
                {
                    lbResult.Items.Add(31);
                }
                else if (cboMonth.Text == "February")
                {
                    lbResult.Items.Add(29);
                }
                else if (cboMonth.Text == "March")
                {
                    lbResult.Items.Add(31);
                }
                else if (cboMonth.Text == "April")
                {
                    lbResult.Items.Add(30);
                }
                else if (cboMonth.Text == "May")
                {
                    lbResult.Items.Add(31);
                }
                else if (cboMonth.Text == "June")
                {
                    lbResult.Items.Add(30);
                }
                else if (cboMonth.Text == "July")
                {
                    lbResult.Items.Add(31);
                }
                else if (cboMonth.Text == "August")
                {
                    lbResult.Items.Add(31);
                }
                else if (cboMonth.Text == "September")
                {
                    lbResult.Items.Add(30);
                }
                else if (cboMonth.Text == "October")
                {
                    lbResult.Items.Add(31);
                }
                else if (cboMonth.Text == "November")
                {
                    lbResult.Items.Add(30);
                }
                else if (cboMonth.Text == "December")
                {
                    lbResult.Items.Add(31);
                }
            }
            else
            {
                if (cboMonth.Text == "January")
                {
                    lbResult.Items.Add(31);
                }
                else if (cboMonth.Text == "February")
                {
                    lbResult.Items.Add(28);
                }
                else if (cboMonth.Text == "March")
                {
                    lbResult.Items.Add(31);
                }
                else if (cboMonth.Text == "April")
                {
                    lbResult.Items.Add(30);
                }
                else if (cboMonth.Text == "May")
                {
                    lbResult.Items.Add(31);
                }
                else if (cboMonth.Text == "June")
                {
                    lbResult.Items.Add(30);
                }
                else if (cboMonth.Text == "July")
                {
                    lbResult.Items.Add(31);
                }
                else if (cboMonth.Text == "August")
                {
                    lbResult.Items.Add(31);
                }
                else if (cboMonth.Text == "September")
                {
                    lbResult.Items.Add(30);
                }
                else if (cboMonth.Text == "October")
                {
                    lbResult.Items.Add(31);
                }
                else if (cboMonth.Text == "November")
                {
                    lbResult.Items.Add(30);
                }
                else if (cboMonth.Text == "December")
                {
                    lbResult.Items.Add(31);
                }
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtYear.Clear();
            lbResult.Items.Clear(); 
        }
    }
}
