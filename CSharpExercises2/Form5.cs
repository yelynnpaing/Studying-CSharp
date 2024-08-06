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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int amount, option, salesTax, totalAmount;
        private void computeBtn_Click(object sender, EventArgs e)
        {
            amount = int.Parse(txtPurchase.Text);

            switch(option)
            {
                case 0:
                    salesTax = 0;
                    totalAmount = amount;
                    break;
                case 1:
                    salesTax = (amount * 3 ) / 100;
                    totalAmount = amount + salesTax;
                    break;
                case 2:
                    salesTax = (amount * 5) / 100;
                    totalAmount = amount + salesTax;
                    break;
                case 3:
                    salesTax = (amount * 7) / 100;
                    totalAmount = amount + salesTax;
                    break;
            }

            MessageBox.Show("Sales tax is " + salesTax + "\nTotal amount is " + totalAmount, "Sales Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void opt0_CheckedChanged(object sender, EventArgs e)
        {
            option = opt0.TabIndex;
        }

        private void opt1_CheckedChanged(object sender, EventArgs e)
        {
            option = opt1.TabIndex;
        }

        private void opt2_CheckedChanged(object sender, EventArgs e)
        {
            option = opt2.TabIndex;
        }

        private void opt3_CheckedChanged(object sender, EventArgs e)
        {
            option = opt3.TabIndex;
        }
    }
}
