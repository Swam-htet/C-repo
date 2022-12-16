using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic_7_example
{
    public partial class Form1 : Form
    {
        // array declaration
        int[] numlist;

        // current index
        int i;

        public Form1()
        {
            InitializeComponent();
        }

        // form load function
        private void Form1_Load(object sender, EventArgs e)
        {
            numlist = new int[10];
             i = 0;
        }

        // add new item button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // full number in numlist array
            if(i == 10)
            {
                output.Text = "You have filled the array. Press calculate.";
            }

            // inserting number to the numlist array
            else
            {
                // taking input / assiging to the array / index increment
                int inputNumber = Int32.Parse(input.Text);
                numlist[i] = inputNumber;
                i++;

                // showwing output
                output.Text = i + " numbers in array.";

                // clear input text
                input.Text = "";
            }
        }

        // calculate average button
        private void btnCal_Click(object sender, EventArgs e)
        {
            // there is no number in numlist
            if(i == 0)
            {
                output.Text = "There is no number in numlist.";
            }

            // calculate function
            else
            {
                // adding numbers to the total and showing average result
                int total = 0;
                int result;
                for (int a = 0; a < numlist.Length; a++)
                {
                    total += numlist[a];
                }
                result = total / numlist.Length;
                output.Text = "The average is : " + result;
            }
        }
    }
}
