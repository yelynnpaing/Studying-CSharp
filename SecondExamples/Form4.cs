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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int charges;
        int check;
        int discount;
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            switch(check)
            {
                case 0:
                    charges = int.Parse(txtDay.Text) * 100000;
                    break;
                case 1:
                    charges = int.Parse(txtDay.Text) * 7000;
                    break;
                case 2:
                    charges = int.Parse(txtDay.Text) * 5000;
                    break;
            }

            if(charges >= 100000)
            {
                discount = (charges * 10) / 100;
            }
            else
            {
                discount = 0;
            }

            MessageBox.Show("Rent Charges = " + charges.ToString() + "\nDiscount Rate = " + discount.ToString(), "Rental Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void optHiway_CheckedChanged(object sender, EventArgs e)
        {
            check = optHiway.TabIndex;
        }

        private void optMinibus_CheckedChanged(object sender, EventArgs e)
        {
            check = optMinibus.TabIndex;
        }

        private void optSaloon_CheckedChanged(object sender, EventArgs e)
        {
            check = optSaloon.TabIndex;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
