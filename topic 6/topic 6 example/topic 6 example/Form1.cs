using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic_6_example
{
    public partial class Form1 : Form
    {
        // list declaration 
        List<Account> accounts;

        // enter number 
        string enterNumber;

        // enter pin
        string enterPIN;
        
        // input text
        String enteredText;

        // creating of 4 object
        Account acc1, acc2, acc3, acc4;

        // to check the current account
        Account current;

        // input usage , withdraw and withdraw receipt 's boolean conditions
        Boolean inputAllow, withdrawing, receipt;

        public Form1()
        {
            InitializeComponent();
        }

        // form load funtion
        private void Form1_Load(object sender, EventArgs e)
        {
            // assign text to ""
            enteredText = "";
            enterNumber = "";
            enterPIN = "";


            // interest rate for extended user
            double interest;

            // list 
            accounts = new List<Account>();

            

            // add basic account to the list
            addAccount("10", "2222", 100000);
            addAccount("20", "3333", 100000);
            addAccount("30", "4444", 100000);
            addAccount("40", "5555", 100000);
            addAccount("50", "6666", 100000);
            addAccount("60", "7777", 100000);
            addAccount("70", "8888", 100000);

            // add extended account to the list
            addAccount("80", "9999", 100000, 10);


            // assignin inputAllow = true to take input
            inputAllow = true;
        }

        // add account method
        public void addAccount(string a,string n, int b)
        {
            Account check = new Account(a,n,b);
            accounts.Add(check);
            
            
        }
        /* public void addBasicAccount(string a,string n,int b)
        {
            Account check = new BasicAccount(a,n,b);
            accounts.Add(check);

        }
        */

        public void addAccount(string a,string n,int b,double ir)
        {
            Account check = new ExtendedAccount(a,n,b,ir);
            accounts.Add(check);
        }


        // output display update
        private void updateDisplay()
        {
            output.Text = enteredText;
        }

        // keypard input function

        // for button 1
        private void btn1_Click(object sender, EventArgs e)
        {
            if (inputAllow == false)
            {
                return;
            }
            enteredText += "1";
            updateDisplay();
        }

        // for button 2
        private void btn2_Click(object sender, EventArgs e)
        {
            if (inputAllow == false)
            {
                return;
            }
            enteredText += "2";
            updateDisplay();
        }

        // for button 3
        private void btn3_Click(object sender, EventArgs e)
        {
            if (inputAllow == false)
            {
                return;
            }
            enteredText += "3";
            updateDisplay();
        }

        // for button 4
        private void btn4_Click(object sender, EventArgs e)
        {
            if (inputAllow == false)
            {
                return;
            }
            enteredText += "4";
            updateDisplay();
        }

        // for button 5
        private void btn5_Click(object sender, EventArgs e)
        {
            if (inputAllow == false)
            {
                return;
            }
            enteredText += "6";
            updateDisplay();
        }

        // for button 6
        private void btn6_Click(object sender, EventArgs e)
        {
            if (inputAllow == false)
            {
                return;
            }
            enteredText += "6";
            updateDisplay();
        }

        // for button 7
        private void btn7_Click(object sender, EventArgs e)
        {
            if (inputAllow == false)
            {
                return;
            }
            enteredText += "7";
            updateDisplay();
        }

        // for button 8
        private void btn8_Click(object sender, EventArgs e)
        {
            if (inputAllow == false)
            {
                return;
            }
            enteredText += "8";
            updateDisplay();
        }

        // for button 9
        private void btn9_Click(object sender, EventArgs e)
        {
            if (inputAllow == false)
            {
                return;
            }
            enteredText += "9";
            updateDisplay();
        }

        // for button 0
        private void btn0_Click(object sender, EventArgs e)
        {
            if (inputAllow == false)
            {
                return;
            }
            enteredText += "0";
            updateDisplay();
        }

        // for button clear
        private void btnC_Click(object sender, EventArgs e)
        {

            if (inputAllow == false)
            {
                return;
            }
            enteredText = "";
            updateDisplay();
        }

        // keypad fucntion end



        // check account by using checkPin() method from Account class
        // return one of 4 object or null
        private Account findAccount(String num,String pin)
        {
            Account check;

            for(int i = 0;i<accounts.Count; i++)
            {
                if (accounts[i].checkPin(num, pin) == true)
                {
                    check = accounts[i];
                    return check;
                }
            }
            return null;
        }

        // balance button
        private void btnBalance_Click(object sender, EventArgs e)
        {
            // current is not null
            if (current != null)
            {
                output.Text = "Balance is " + current.getBalance();
            }
            // current is null
            else
            {
                // MessageBox.Show("There is no account. Please log in your account");
            }

        }

        // withdrawing function
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // current account is nothing
            if (current == null)
            {
                output.Text = "Enter PIN";                
            }
            // else 
            else
            {
                output.Text = "Enter amount";
                inputAllow = true;
                withdrawing = true;

                // assign receipt = false for no receipt
                receipt = false;
            }
        }

        // withdrawing with receipt button
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            if (current == null)
            {
                output.Text = "Enter PIN";
            }
            else
            {
                output.Text = "Enter amount";
                inputAllow = true;
                withdrawing = true;

                // assign receipt = true for receipt
                receipt = true;
            }
        }

        // confirm button
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Boolean ret;
 

            // null condition for account searching
            if (current == null)
            {
                if (enterNumber.Length == 0)
                {
                    enterNumber = enteredText;
                    enteredText = "";
                    output.Text = "Enter PIN";
                    return;
                }
                if (enterPIN.Length == 0)
                {
                    enterPIN = enteredText;
                    enteredText = "";
                }
                if (enterNumber.Length > 0 && enterPIN .Length > 0)
                {
                    current = findAccount(enterNumber, enterPIN);
                }
            }
            
            // not null condition
            if (current != null)
            {
                if (withdrawing == true)
                {
                    // check the balance with withdraw amount
                    ret = current.withdraw(Int32.Parse(enteredText));

                    // if true
                    if (ret == true)
                    {
                        // output text
                        output.Text = "Transaction successful.\nYour have a "+current.queryType()+" Account.\n";

                        // receipt button for receipt output
                        if (receipt == true)
                        {
                            output.Text += "\nLast transaction: \n" + current.getLastTransaction();
                        }
                    }
                    // if false
                    else
                    {
                        // withdraw amount is larger than the balance
                        output.Text = "Insufficient funds";
                    }

                    // reset the entered text => null 
                    // withwraw => false
                    // input usage => false

                    enteredText = "";
                    enterPIN = "";
                    enterNumber = "";

                    withdrawing = false;
                    inputAllow = false;
                }
                // no account to assign the account
                else
                {
                    output.Text = "Logged in - choose transaction";
                    enteredText = "";
                }
            }

            // else condition
            else
            {
                
                enteredText = "";
                enterNumber = "";
                enterPIN = "";

                inputAllow = true;

                output.Text = "Invalid PIN";
            }

        }

        // deny button
        private void btnDeny_Click(object sender, EventArgs e)
        {
            enteredText = "";
            withdrawing = false;
            if (current != null)
            {
                output.Text = "Choose Transaction";
            }
            else
            {
                output.Text = "Enter PIN";
            }
        }





    }
}
