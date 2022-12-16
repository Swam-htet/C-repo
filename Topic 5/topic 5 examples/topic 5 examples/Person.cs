using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic_5_examples
{
    internal class Person
    {
        // private name and age
        private string name;
        private int age;

        /*
        // normal set and get method
        public void setAge(int a)
        {
            age = a;
        }
        public int getAge()
        {
            return age;
        }

        */

        
        // .NET 's buildIn accesser method
        
        // accessor method for age
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        //accessor method for name
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // adjust age method
        public void adjustAge(int amount)
        {
            age = age + amount;
        }

        


        /*
        // constructor method

        // constructor overloading

         public Person(string n,int a)
        {
            name = n;
            age = a;
        }

        public Person()
        {
            name = "undefinied";
            age = 10;
        }

        */






    }
}
