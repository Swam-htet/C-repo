using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic_8_task
{
    // parent child class
    internal class Animal
    {
        // private properties
        private String name;


        // accessor function
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // parent's methods available for overriding
        public virtual string talk()
        {
            return "unspecified";
        }

        public virtual string walk()
        {
            return "unspecified";
        }

        public virtual string queryType()
        {
            return "unspecified";
        }


    }

    // dog child class
    class Dog : Animal
    {
        // overriding parent's methods
        public override string talk()
        {
            return "Woof";
        }

        public override string walk()
        {
            return "Walk";
        }

        public override string queryType()
        {
            return "Dog";
        }
    }

    // dog's child class
    class GreatDane : Dog {
        public override string queryType()
        {
            return "Great Dane";
        }
    }

    // dog's child class
    class YorkshireTerrier : Dog
    {
        public override string queryType()
        {
            return "Yorkshire Terrier";
        }
    }
    
    // cat child class
    class Cat : Animal
    {
        // overriding parent's methods
        public override string talk()
        {
            return "Meow";
        }

        public override string walk()
        {
            return "Walk";
        }

        public override string queryType()
        {
            return "Cat";
        }

    }

    // cat's child class
    class HouseCat : Cat
    {
        public override string queryType()
        {
            return "House Cat";
        }
    }

    // cat's child
    class GreatCat : Cat
    {
        public override string queryType()
        {
            return "Great Cat";
        }
    }

    // horse child class
    class Horse : Animal
    {
        // overriding parent's methods
        public override string talk()
        {
            return "Whinny";
        }

        public override string walk()
        {
            return "Run";
        }

        public override string queryType()
        {
            return "Horse";
        }

    }


}
