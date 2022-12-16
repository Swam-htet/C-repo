using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_matchine
{
    internal class Account
    {
        // private properties
        private string pin;
        private string lastTran;
        private int balance;

        // account number
        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        // constructor
        public Account(string ac, string p,int b)
        {
            accountNumber = ac;
            pin = p;
            balance = b;
        }

        // get balance
        public int getBalance()
        {
            return balance;
        }

        // check pin 
        public bool checkPin(string a,string p)
        {
            if(accountNumber.ToLower().Equals(a.ToLower()) == false)
            {
                return false;
            }
            else
            {

                if (pin.ToLower() == p.ToLower())
                {
                    return true;
                }
                return false;
            }
        }

        // check withdraw
        public bool checkwithdraw(int para)
        {
            if( para > balance)
            {
                return false;
            }
            else
            {
                lastTran = "Balance is " + balance + " and withdraw amount is " + para;
                balance -= para;
                lastTran += "\nRemain balance is " + balance;
                return true;

            }
        }

        // lastTran output
        public string getLasttran()
        {
            if(lastTran == null)
            {
                return "No Transition";
            }
            else
            {
                return lastTran;
            }
        }
    }
}
