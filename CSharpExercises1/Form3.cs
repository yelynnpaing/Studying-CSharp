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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void sideCal_Click(object sender, EventArgs e)
        {
            int perimeter, side;
            perimeter = int.Parse(pTxtNum.Text);
            side = perimeter / 4;

            sTxtNum.Text = side.ToString();
        }
    }
}
