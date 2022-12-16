using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // this include only task 1, task 2, task 4, task 5 and task 6
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            // task 1 
            int inputNumber = Int32.Parse(input.Text);
            int total = 0;
            for(int i = 0; i <= inputNumber; i++)
            {
                total += i;
            }
            MessageBox.Show("This is total :" + total);
            */

            /*
            // task 2
            int inputNumber = Int32.Parse(input.Text);
            for(int i = 1; i <= 12; i++)
            {
                int ans = i * inputNumber;
                output.Text += inputNumber + " * " + i + " = " + ans + "\n"; 
            }
            */

            /*
            // task 4
            int inputNUmber = Int32.Parse(input.Text);
            for(int i = 0; i < inputNUmber; i++)
            {
                for(int j = 0 ; j <= i; j++)
                {
                    output.Text += "*";
                }
                output.Text += "\n";
            }
            */

            /*
            // task 5
            int inputNumber = Int32.Parse(input.Text);

            for(int i = 0; i < inputNumber; i++)
            {
                for(int j = 0; j<= i; j++)
                {
                    output.Text += "*";

                }
                output.Text += "\n";
            }
            for(int i = inputNumber - 1; i >= 0; i--)
            {
                for(int j = 1; j<=i; j++)
                {
                    output.Text += "*";
                }
                output.Text += "\n";
            }
            */
            

            /*
            // task 6

            int inputNumber = Int32.Parse(input.Text);
            int result = 1;
            for(int i = 1; i <= inputNumber; i++)
            {
                result = result * i;
            }

            output.Text = "This is the factorital of " + inputNumber + " is : " + result;
            */
        }
    }
}
