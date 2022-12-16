using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic_8_example_1
{
    public partial class Form1 : Form
    {
        // list declaration
        List<NormalUser> accounts;

        public Form1()
        {
            InitializeComponent();
        }
        // function to create object and add to the list
        private void addAccount(string user,string pass)
        {
            // obj creatring
            NormalUser u;
            u = new NormalUser();

            // assign the parameter value to the obj
            u.Username = user;
            u.Password = pass;

            // add the obj to the list
            accounts.Add(u);
        }
         
        private void Form1_Load(object sender, EventArgs e)
        {
            // list assigning
            accounts = new List<NormalUser>();

            // add some sample account to the list

            addAccount("Swam Htet", "222222");
            addAccount("Aung Aung", "111111");



        }

        private NormalUser findAccount(string input)
        {
            // check every account from the list by using loop
            for(int i = 0; i< accounts.Count; i++)
            {
                // check condition with user name from account and input text in lower case condition
                if (accounts[i].Username.ToLower() == input.ToLower())
                {
                    // if true return current account
                    return accounts[i];
                }
            }

            // if there is no suitable account in the list return null
            return null;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            NormalUser current;
            current = findAccount(inputUser.Text);

            if(current == null)
            {
                MessageBox.Show("No such account.");
                return;
            }
            if (current.checkPassword(inputPassword.Text))
            {
                MessageBox.Show("Access granted");
            }
            else
            {
                MessageBox.Show("Access denied.");
            }
        }
    }
}
