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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int salary, bonus, payment;
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            salary = int.Parse(txtSalary.Text);

            if(salary < 5000)
            {
                bonus = 500;
                payment = salary + bonus;
            }
            else if (salary <= 8000)
            {
                bonus = 800;
                payment = salary + bonus;
            }
            else if (salary > 8000)
            {
                bonus = 1000;
                payment = salary + bonus;
            }

            MessageBox.Show("Bonus is " + bonus + "\nPayment is " + payment, "Payment Informantion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
