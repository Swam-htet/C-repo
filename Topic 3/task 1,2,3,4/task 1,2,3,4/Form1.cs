using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1_2_3_4
{
    public partial class Form1 : Form
    {
        // boolean condition
        Boolean add, sub, multi, div;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int num1, num2;
            string inputOneText,inputTwoText;

            
            inputOneText = inputOne.Text;
            inputTwoText = inputTwo.Text;

            // task 2 : input validation

            // input one validation
            if(inputOneText== "")
            {
                MessageBox.Show("Enter the number One.");

            }
            // input validation
            else if(inputTwoText == "")
            {
                MessageBox.Show("Enter the number Two.");
                
            }
            // all input all true 
            else
            {
                num1 = Int32.Parse(inputOneText);
                num2 = Int32.Parse(inputTwoText);

                // MessageBox.Show("This is number One >" + num1 + "\nThis is number two >" + num2);

                // result for radion calculation
                int result = 0;

                // task 1 : radio input checking
                if (radioAdd.Checked == true)
                {
                    result = num1 + num2;
                    if(add == true)
                    {
                        MessageBox.Show("Choose different calculation");
                        return;
                    }
                    add = true;
                    sub = false;
                    div = false;
                    multi = false;
                }
                else if (radioSub.Checked == true)
                {
                    if(sub == true)
                    {
                        MessageBox.Show("Choose different calculation.");
                        return;
                    }
                    result = num1 - num2;
                    sub = true;
                    add = false;
                    div = false;
                    multi = false;
                }

                else if (radioMulti.Checked == true)
                {
                    if(multi == true)
                    {
                        MessageBox.Show("Choose different calculation.");
                        return;
                    }
                    result = num1 * num2;
                    multi = true;
                    sub = false;
                    add = false;
                    div = false;
                }
                else if (radioDiv.Checked == true)
                {
                    if(div == true)
                    {
                        MessageBox.Show("Choose different calculation");
                        return ;
                    }
                    
                    result = num1 / num2;
                    div = true;
                    multi = false;
                    sub = false;
                    add = false;
                }
                // task 4: comparison the number

                // number 1 and number 2
                if(num1 > num2)
                {
                    comparisonOne.Text = " Number one is greater than the number two";

                }
                else if(num2 > num1)
                {
                    comparisonOne.Text = " Number Two is greater than the number one";
                }
                else
                {
                    comparisonOne.Text = " Number one and number two are equal.";
                }

                //result and number 1
                if(result > num1)
                {
                    comparisonTwo.Text = "The result( " + result + " ) is greater than the number one( " + num1 + " ).";
                }
                else if(num1 > result)
                {
                    comparisonTwo.Text = "The result( " + result + " ) is less than the number one( " + num1 + " ).";

                }
                else
                {
                    comparisonTwo.Text = "The result( " + result + " ) and number one( " + num1 + " ) are equal.";
                }

                // result and number 2
                if (result > num2)
                {
                    comparisonThree.Text = "The result( " + result + " ) is greater than the number two( " + num2 + " ).";
                }
                else if (num2 > result)
                {
                    comparisonThree.Text = "The result( " + result + " ) is less than the number two( " + num2 + " ).";

                }
                else
                {
                    comparisonThree.Text = "The result( " + result + " ) and number two( " + num2 + " ) are equal.";
                }

                MessageBox.Show("The result is > " + result);
            }

            
        }
    }
}
