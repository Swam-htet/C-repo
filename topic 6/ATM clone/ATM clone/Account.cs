using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_clone
{
    internal class Account
    {
        private string pin;
        private string lastTran;
        private int balance;

        // constructor
        public Account(string p,int b)
        {
            pin = p;
            balance = b;
        }

        // get function of balance
        public int getBalance()
        {
            return balance;
        }

        // withdrawCheck
        public Boolean withdrawCheck(int money)
        {
            if(money > balance)
            {
                return false;
            }
            else
            {
                lastTran = "Balance : " + balance + "\nWithdraw amount : " + money;
                balance -= money;
                lastTran += "\nRemain Balance : " + balance;
                return true;
            }
        }

        // last transiton check
        public string lastTranOutput()
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

        // check pin and return boolean condition
        public bool checkPin(string p)
        {

            if (pin.ToLower()==p.ToLower()) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
