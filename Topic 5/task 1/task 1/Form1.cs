using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    public partial class Form1 : Form
    {
        // obj declaration
        StatisticalData s1, s2, s3, s4, s5;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // obj assigning
            s1 = new StatisticalData();
            s2 = new StatisticalData();
            s3 = new StatisticalData();
            s4 = new StatisticalData();
            s5 = new StatisticalData();

        }

        // checking which function
        private StatisticalData whichCheck()
        {
            StatisticalData which;
            int num = Int32.Parse(inputWhich.Text);
            if(num == 1)
            {
                which = s1;
            }
            else if(num == 2)
            {
                which = s2;
            }
            else if(num == 3)
            {
                which = s3;
            }
            else if(num == 4)
            {
                which = s4;
            }
            else
            {
                which = s5;
            }
            return which;
        }

        // store data method
        private void storeBtn_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(inputNum1.Text);
            int number2 = Int32.Parse(inputNum2.Text);
            int number3 = Int32.Parse(inputNum3.Text);

            StatisticalData select = whichCheck();

            select.Num1 = number1;
            select.Num2 = number2;
            select.Num3 = number3;
        }

        // find largest method
        private void findLargest_Click(object sender, EventArgs e)
        {
            StatisticalData select = whichCheck();
            output.Text = "This is the largest Number : " + select.findLargestFunction();
        }

        // find smallest method
        private void findSmallest_Click(object sender, EventArgs e)
        {
            StatisticalData select = whichCheck();
            output.Text = "This is the smallest Number : " + select.findSmallestFunction();
        }

        // find average method
        private void findAverage_Click(object sender, EventArgs e)
        {
            StatisticalData select = whichCheck();
            output.Text = "This is the Average : " + select.findAverageFunction();
        }

        

    }
}
