using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic_8_example_2
{
    public partial class Form1 : Form
    {
        // acount list declaration
        List<User> acounts;

        public Form1()
        {
            InitializeComponent();
        }


        // form load function
        private void Form1_Load(object sender, EventArgs e)
        {
            // account assinging
            acounts = new List<User>();

            // save account to the list by using add account function

            // admin user saving
            addAccount("Swam Htet", "alphar", "222222",true);

            // normal user saving
            addAccount("Hla Hla", "tessa", "111111");


        }

        // find accround from list
        private User findAccout(string rn,string un)
        {
            // find account along the list by looping
            for(int i = 0; i < acounts.Count; i++)
            {
                // need to equal with usename and realname from the list
                if (acounts[i].RealName.ToLower() == rn.ToLower() && acounts[i].UseName.ToLower() == un.ToLower()){

                    // return the search account from the list and end the function
                    return acounts[i];
                }
                
            }
            // if there is no account return null
            return null;
        }

        // polymophysm of addAccount function

        // add acount function for normal user
        private void addAccount(string rn,string un, string pw)
        {
            // check current account
            User current = new NormalUser();

            // parameter to properties
            current.RealName = rn;
            current.UseName = un;
            current.Password = pw;

            // add the check account to the acount list
            acounts.Add(current);
        }

        // add acount function for normal Admin user
        private void addAccount(string rn, string un, string pw,bool condi)
        {
            // current check user
            User current;

            // admin condition checking , if true create admin user
            if(condi == true)
            {
                current = new AdminUser();
            }

            // if false creat normal user
            else
            {
                current = new NormalUser();
            }

            // parameter to properties
            current.RealName = rn;
            current.UseName = un;
            current.Password = pw;

            // add the check account to the acount list
            acounts.Add(current);
        }

        // click function
        private void btn_Click(object sender, EventArgs e)
        {
            // to check the account
            User current;

            // find the check account from the list 
            current = findAccout(inputReal.Text,inputUser.Text);

            // if there is no such account
            if(current == null)
            {
                output.Text = "No such account.";
            }
            // if account is found from the list
            else
            {

                // check password if password is true
                if (current.checkPassword(inputPW.Text) == true)
                {
                    output.Text = "Access granted";
                }

                // if password is wrong
                else
                {
                    output.Text = "Access Denined";
                }
            }
        }
    }
}
