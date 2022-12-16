using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic_8_example_2
{
    internal class User
    {
        // private properties
        private string realName;
        private string usename;
        private string password;

        // accessor functions
        public string RealName { get { return realName; } set { realName = value; } }
        public string UseName { get { return usename; } set { usename = value; } }
        public string Password { get { return password; } set { password = value; } }

        // check password funciton return boolean
        public virtual bool checkPassword(string pass)
        {
            if (pass.ToLower() == password.ToLower())
            {
                return true;
            }

            return false;
        }
    }
    // child class >> normal user
    class NormalUser : User
    {

    }

    // child class >> admin user
    class AdminUser : User
    {
        // admin 's private properties
        private int count;
        private bool locked;

        // accessor function
        public int Count { get { return count; } set { count = value; } }
        public Boolean Locked { get { return locked; }set { locked = value; } }

        // override method for adming to check password
        public override bool checkPassword(string pass)
        {
            // check condition
            bool condi;

            // check locked or not
            if(locked == true)
            {
                    return false;
            }
            
            // use parent's checkpassword method
            condi = base.checkPassword(pass);

            // if password is true
            if(condi == true)
            {
                // availe count to0
                count = 0;

                // return true from check function
                return true;
            }

            // if password is false
            else
            {
                // increce available count 
                count++;

                // if available count is 5 time 
                if(count == 5)
                {
                    // locked 
                    locked = true;

                }
                // return false from checkf function
                return false;
            }

        }
    }
}
