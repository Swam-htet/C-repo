using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic_8_example_1
{
    internal class User
    {
        // private properties
        private String realname;
        private String username;
        private String password;

        // accessor function
        public string Realname { get => realname; set => realname = value; }
        public String Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        // check password funciton return boolean
        public Boolean checkPassword(string pass)
        {
            if (pass.ToLower().Equals(password.ToLower())){
                return true;
            }
            return false;
        }

    }
    class NormalUser: User
    {

    }


}
