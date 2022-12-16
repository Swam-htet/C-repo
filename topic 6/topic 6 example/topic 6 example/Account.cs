using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic_6_example
{
    // parent class
    internal class Account
    {
        // properties
        private string pin;
        private string lastTransition;
        private int balance;
        private string accountNumber;

        // accessor function for account number
        public string AccountNumber { get { return accountNumber; } set { accountNumber = value; } }

        // contstructor for parent Account
        public Account(string an,string p, int b)
        {
            accountNumber = an;
            pin = p;
            balance = b;
        }

        // get balance method
        public int getBalance()
        {
            return balance;
        }

        // check pin method
        public bool checkPin(string a, string p)
        {
            // check account number with parameter a 
            // if false
            if (accountNumber.ToLower().Equals(a.ToLower()) == false)
            {
                // end function
                return false;
            }
            
            // else check pin with parameter p
            if (pin.ToLower().Equals(p.ToLower()))
            {
                return true;
            }

            // if pin is wrong
            else
            {
                return false;
            }
        }

        // check withdraw check ok or insufficient amount check
        public virtual Boolean queryValidTransaction(int amount)
        {
            if(amount > balance)
            {
                // insufficient withdraw
                return false;
            }
            // withdraw ok
            return true;

        }

        // withdraw method for child overiadable 
        public virtual Boolean withdraw(int amount)
        {
            // check withdraw condition 
            if (queryValidTransaction(amount) == false)
            {
                return false;
            }
            // else 
            else
            {
                // show balance before - and show withdraw amount
                lastTransition = "Balance was : " + balance + "\nWithdraw " + amount;

                // - the withdraw amount from balance
                balance -= amount;

                // show remain balance
                lastTransition += "\nRemain balance : " + balance;

                // return true
                return true;
            }
        }

        // get last transaction method
        public String getLastTransaction()
        {
            if (lastTransition != null)
            {
                return lastTransition;
            }
            return "No Transaction";

        }

        public virtual String queryType()
        {
            return "Base";
        }

        

    }
    
    // basic account child of account class
    class BasicAccount : Account
    {
        private int overdraft;

        public int Overdraft
        {
            get { return overdraft; }
            set { overdraft = value; }
        }

        // child constructor
        public BasicAccount(string an, string p, int b) : base(an, p, b)
        {
            overdraft = 100;
        }

        
        public override Boolean queryValidTransaction(int amount)
        {
            int newAmount = this.getBalance() - amount;
            if(newAmount < overdraft)
            {
                return false;
            }
            return true;
        }


        public override string queryType()
        {
            return "Basic";
        }



    }

    // extended account child of account class
    class ExtendedAccount : Account
    { 
        private double interestRate;

        public double InterestRate { get => interestRate; set => interestRate = value; }
        
        public ExtendedAccount(string an,string p,int b,double ir):base(an,p,b)
        {
            interestRate = ir;
        }

        public override string queryType()
        {
            return "Extended";
        }

    }
}
