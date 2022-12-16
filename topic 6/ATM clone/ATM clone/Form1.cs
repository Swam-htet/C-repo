using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_clone
{
    public partial class Form1 : Form
    {
        // object creation
        Account account;
        
        // string value to assign the input text
        string enter;

        // keyboard allow
        Boolean keyboardAllow;

        // check account
        Account which;

        // withdraw allow
        Boolean withdrawAllow;

        // receipt allow
        Boolean receiptAllow;

        public Form1()
        {
            InitializeComponent();
        }

        // form load function
        private void Form1_Load(object sender, EventArgs e)
        {
            // object assigning with constructor
            account = new Account("2030",100000);

            // when form load => give keyboard allow = true
            keyboardAllow = true;

        }


        // check which account
        private Account findAccount(string input)
        {
            if(input != "")
            {
                if (which.checkPin(input))
                {
                    return which;
                }
                return null;
            }
            else
            {
                return null;
            }
            
        }


        // update display function
        private void updateDisplay()
        {
            output.Text = enter;
        }

        // keypad

        // click 0
        private void btn0_Click(object sender, EventArgs e)
        {
            if (keyboardAllow)
            {
                enter += "0";
                updateDisplay();
            }
            

        }

        // click 1
        private void btn1_Click(object sender, EventArgs e)
        {
            if (keyboardAllow)
            {
                enter += "1";
                updateDisplay();
            }
        }

        // click 2
        private void btn2_Click(object sender, EventArgs e)
        {
            if (keyboardAllow)
            {
                enter += "2";
                updateDisplay();
            }
        }

        // click 3
        private void btn3_Click(object sender, EventArgs e)
        {
            if (keyboardAllow)
            {
                enter += "3";
                updateDisplay();
            }
        }

        // click 4
        private void btn4_Click(object sender, EventArgs e)
        {
            if (keyboardAllow)
            {
                enter += "4";
                updateDisplay();
            }
        }

        // click 5
        private void btn5_Click(object sender, EventArgs e)
        {
            if (keyboardAllow)
            {
                enter += "5";
                updateDisplay();
            }
        }

        // click 6
        private void btn6_Click(object sender, EventArgs e)
        {
            if (keyboardAllow)
            {
                enter += "6";
                updateDisplay();
            }
        }

        // click 7
        private void btn7_Click(object sender, EventArgs e)
        {
            if (keyboardAllow)
            {
                enter += "7";
                updateDisplay();
            }
        }

        // click 8
        private void btn8_Click(object sender, EventArgs e)
        {
            if (keyboardAllow)
            {
                enter += "8";
                updateDisplay();
            }
        }

        // click 9
        private void btn9_Click(object sender, EventArgs e)
        {
            if (keyboardAllow)
            {
                enter += "9";
                updateDisplay();
            }
        }

        // click C
        private void btnC_Click(object sender, EventArgs e)
        {
            if (keyboardAllow)
            {
                enter = "";
                updateDisplay();
            }
        }

        // click balance function
        private void balanceBtn_Click(object sender, EventArgs e)
        {
            if(which != null)
            {
                output.Text = "Your remamin balance : " + which.getBalance();
            }
            else
            {
                output.Text = "Log in your account.";
            }
        }

        // click withdraw function
        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            if(which != null)
            {
                output.Text = "Enter withdraw amount : ";
                keyboardAllow = true;
                receiptAllow = false;
                withdrawAllow = true;
                
            }
            else
            {
                output.Text = "Enter PIN.";
            }
        }

        // click withdraw with receipt function
        private void receiptBtn_Click(object sender, EventArgs e)
        {
            if(which != null)
            {
                output.Text = "Enter withdraw amount : ";
                keyboardAllow = true;
                receiptAllow = true;
                withdrawAllow = true;
            }
            else
            {
                output.Text = "Enter PIN.";
            }
        }

        // click deny funtion
        private void denyBtn_Click(object sender, EventArgs e)
        {
            enter = "";
            withdrawAllow = false;
            if (which == null)
            {
                output.Text = "Enter PIN.";
            }
            else
            {
                output.Text = "Choose Translation.";
            }
        }


        // click confirm fucntion
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if(which == null)
            {
                which = findAccount(enter);
            }

            if(which != null)
            {
                Boolean condi;

                if(withdrawAllow == true)
                {
                    
                    condi = which.withdrawCheck(Int32.Parse(enter));
                    if(condi == true)
                    {
                        output.Text = "Transition is successful";
                        if (receiptAllow == true)
                        {
                            output.Text +="\nWithdraw Amount : " + which.lastTranOutput();
                         }
                    }
                    else
                    {
                        output.Text = "Insufficient Amount";
                    }
                }
                else
                {
                    output.Text = "Logged In Successful.\nChoose Transition";
                    enter = "";
                }
            }
            else
            {
                output.Text = "Invalid PIN.";
                enter = "";
                keyboardAllow=true;
            }

        }

    }
}
