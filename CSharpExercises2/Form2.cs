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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int int1, int2;
            string result;
            int1 = int.Parse(txtFirstInt.Text);
            int2 = int.Parse(txtSecondInt.Text);    

            if (int1 == int2)
            {
                result = "two integers are equal";
            }
            else if (int1 > int2)
            {
                result = "maximum number is " + int1 + "\nminimum number is " + int2;
            }
            else
            {
                result = "maximum number is " + int2 + "\nminimum number is " + int1; ;
            }

            MessageBox.Show(result, "Detemine two integers", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
