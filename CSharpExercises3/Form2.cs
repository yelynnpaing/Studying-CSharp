using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpExercises3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void sumBtn_Click(object sender, EventArgs e)
        {
            int result = 0;

            for(int i = 1; i <= 99; i++)
            {
                if(i % 2 != 0)
                {
                    result += i;
                }
            }

            resultTxt.Text = result.ToString();
        }
    }
}
