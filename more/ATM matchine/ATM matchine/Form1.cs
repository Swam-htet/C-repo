using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_matchine
{
    public partial class Form1 : Form
    {
        

        // creation of object
        Account test;

        // input text
        string enterText;
        string enterNumber;
        string enterPin;

        // check account
        Account check;

        // keyboard permission
        bool keyboard;

        // withdraw permission
        bool withdraw;

        // receipt permission
        bool receipt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enterPin = "";
            enterNumber = "";
            enterText = "";

            // assigning the object
            test = new Account("20","222222",10000);


            // allow using keyboard
        }

        // update display
        private void updateDisplay()
        {
            output.Text = enterText;
        }

        // keyboard

        private void btn0_Click(object sender, EventArgs e)
        {

            if (keyboard == false)
            {
                return;
            }
            enterText += "0";
            updateDisplay();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           if(keyboard == false)
            {
                return;
            }
            enterText += "1";
            updateDisplay();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (keyboard == false)
            {
                return;
            }
            enterText += "2";
            updateDisplay();

        }

        private void btn3_Click(object sender, EventArgs e)
        {

            if (keyboard == false)
            {
                return;
            }
            enterText += "3";
            updateDisplay();
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if (keyboard == false)
            {
                return;
            }
            enterText += "4";
            updateDisplay();
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            if (keyboard == false)
            {
                return;
            }
            enterText += "5";
            updateDisplay();
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            if (keyboard == false)
            {
                return;
            }
            enterText += "6";
            updateDisplay();
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            if (keyboard == false)
            {
                return;
            }
            enterText += "7";
            updateDisplay();
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            if (keyboard == false)
            {
                return;
            }
            enterText += "8";
            updateDisplay();
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            if (keyboard == false)
            {
                return;
            }
            enterText += "9";
            updateDisplay();
        }

        private void btnC_Click(object sender, EventArgs e)
        {

            if (keyboard == false)
            {
                return;
            }
            enterText = "";
            updateDisplay();
        }

        // keyboard end 

        // find account funciton
        private Account findAccount(string num,string pin)
        {
            if( test.checkPin(num,pin) == true)
            {
                return test;
            }
            return null;
        }

        // balance button
        private void btnBalance_Click(object sender, EventArgs e)
        {
            if(check == null)
            {
                output.Text = "Sign in your account";
            }
            else
            {
                output.Text = "Balance is " + check.getBalance();
            }
        }

        // withdraw only funciton
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if(check == null)
            {
                output.Text = "Enter PIN.";
            }
            else
            {
                output.Text = "Enter amount";
                keyboard = true;
                withdraw = true;
                receipt = false;

            }
        }

        // withdraw and receipt function
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            if (check == null)
            {
                output.Text = "Enter PIN.";
            }
            else
            {
                output.Text = "Enter amount";
                keyboard = true;
                withdraw = true;
                receipt = true;

            }
        }


        // confirm button fuction
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool temp;
            if(check == null)
            {
                if(enterNumber.Length == 0)
                {
                    enterNumber = enterText;
                    enterText = "";
                    output.Text = "Enter PIN";
                    return;
                }
                if(enterPin.Length == 0)
                {
                    enterPin = enterText;
                    enterText = "";
                }

                if(enterNumber.Length > 0 && enterPin.Length > 0)
                {
                    check = findAccount(enterNumber, enterPin);
                }

                
            }
            if(check != null)
            {
                if(withdraw == true)
                {
                    temp = check.checkwithdraw(Int32.Parse(enterText));
                    if(temp == true)
                    {
                        output.Text = "Transcation successful";
                        if(receipt == true)
                        {
                            output.Text = "\nLast Transaction : " + check.getLasttran();
                        }
                    }
                    else
                    {
                        output.Text = "Insufficient funds";
                    }

                    enterText = "";
                    enterNumber = "";
                    enterPin = "";

                    keyboard = false;
                    withdraw = false;

                }
                else
                {
                    output.Text = "Logged in - choose transaction";
                    enterText = "";
                }

            }
            else
            {
                
                enterText = "";
                enterPin = "";
                enterNumber = "";

                keyboard = true;

                output.Text = "Invalid PIN";
            }
        }


        // deny button fucntion
        private void btnDeny_Click(object sender, EventArgs e)
        {
            enterText = "";
            enterNumber = "";
            enterPin = "";
            withdraw = false;

            if(check == null)
            {
                output.Text = "Choose Transaction.";
            }
            else
            {
                output.Text = "Enter PIN";
            }
        }
    }
}
