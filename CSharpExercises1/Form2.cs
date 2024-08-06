using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpExercises
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void areaCal_Click(object sender, EventArgs e)
        {
            int length, breadth, area;
            length = int.Parse(lTxtNum.Text);
            breadth = int.Parse(bTxtNum.Text);
            area = length * breadth;

            aTxtNum.Text = area.ToString();

        }
    }
}
