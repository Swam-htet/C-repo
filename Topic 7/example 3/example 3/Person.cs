using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_3
{
    internal class Person
    {
        // private name and age properties
        private string name;
        private int age;

        // constructor
        public Person(string n,int a)
        {
            name = n;
            age = a;
        }

        // accessor methods for name and age
        public string Name{ get { return name; } set { name = value; } }
        public int Age{ get { return age; } set { age = value; } }
    }
}
