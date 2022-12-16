using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    internal class User
    {
        // property
        private int num1,num2;

        // accessor
        public int Num1 { get { return num1; } set { num1 = value; } }
        public int Num2 { get { return num2; } set { num2 = value; } }


        // constructor
        public User(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }

        // function

        public double div()
        {
            if(num2 == 0)
            {
                // 100/0 assume to 0, but not in math
                return 0;
            }
            
            return num1 / num2;
        }

    }
}
