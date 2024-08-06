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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double wageRate, regularWorkedHour, overTimeWorkedHour, regularPay, overtimePay, weeklyPay;

            wageRate = Convert.ToDouble(txtWageRate.Text);
            regularWorkedHour = Convert.ToDouble(txtRWHour.Text);
            regularPay = regularWorkedHour * wageRate;

            overTimeWorkedHour = Convert.ToDouble(txtOWHour.Text);
            overtimePay = ( overTimeWorkedHour * wageRate ) * 1.5;

            weeklyPay = regularPay + overtimePay;

            MessageBox.Show("Regular Payment is " + regularPay.ToString() + "\nOvertime Payment is " + overtimePay.ToString() + "\nWeekly Payment is " + weeklyPay.ToString(), "Employee Payment Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
