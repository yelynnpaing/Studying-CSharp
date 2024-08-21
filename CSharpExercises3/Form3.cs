using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpExercises3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            int first = 0, second = 0, third;
            int i = 1;
            while(i < 4)
            {
                if(i == 1)
                {
                    first = i;
                    resultTxt.Items.Add(first);
                }

                if(i == 1)
                {
                    second = i;
                    resultTxt.Items.Add(second);
                }

                third = first + second;
                resultTxt.Items.Add(third);

                first = second;
                second = third;

                i++;
            }
            
        }
    }
}
