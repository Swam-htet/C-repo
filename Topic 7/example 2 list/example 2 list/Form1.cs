using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_2_list
{
    public partial class Form1 : Form
    {
        // list declaration
        List<int> numlist;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numlist = new List<int>();
        }

        // adding new to the number list
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(input.Text == "")
            {
                output.Text = "Text the number.";
            }
            else
            {

                // taking input
                int number = Int32.Parse(input.Text);

                // adding the input text to the list
                numlist.Add(number);

                // checking the length of the list
                output.Text = numlist.Count + " numbers in number list.";

                input.Text = "";
            }

        }

        // find average funciton
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(numlist.Count == 0)
            {
                output.Text = "There is no number in the list.";
            }
            else
            {
                int total = 0;

                // adding each element of the total
                for (int i = 0; i < numlist.Count; i++)
                {
                    total += numlist[i];
                }

                // output average
                output.Text = "This is average : " + total / numlist.Count;
            }
        }

        // finding largest function
        private void btnLargest_Click(object sender, EventArgs e)
        {
            int largest = numlist[0];
            for (int i = 0; i < numlist.Count; i++ ){
                if (numlist[i] > largest)
                {
                    largest = numlist[i];
                }
            }
            output.Text = "This is the largest number from list : " + largest;
        }

        // find smallest function
        private void btnSmallest_Click(object sender, EventArgs e)
        {
            int smallest = numlist[0];
            for(int i = 0; i< numlist.Count; i++)
            {
                if (numlist[i] < smallest)
                {
                    smallest = numlist[i];
                }
            }
            output.Text = "This is smallest number from list : " + smallest;
        }

        // couning the number between 5 to 10
        private void btnCount_Click(object sender, EventArgs e)
        {
            int count = 0;
            for(int i = 0; i< numlist.Count; i++)
            {
                if(numlist[i] >=5 && numlist[i] <= 10)
                {
                    count++;
                }
            }

            
            output.Text = "This is the count of number between 5 to 10 : " + count;
        }
    }
}
