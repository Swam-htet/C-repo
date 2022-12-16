using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    internal class Parent
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age;set => age = value; }

        // constructor
        public  Parent(string n,int a)
        {
            name = n;
            age = a;
        }

        

        // get functions
        public string getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

    }
}
