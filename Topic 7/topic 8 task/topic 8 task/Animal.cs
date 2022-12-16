using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic_8_task
{
    // parent animal class
    internal class Animal
    {
        // private name
        private string name;

        // accessor for name 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual string move()
        {
            return "unspecified";
        }
        public virtual string talk()
        {
            return "unspecified";
        }
        public virtual string type()
        {
            return "unspecified";
        }
    }

    // class dog
    class Dog : Animal
    {
        public override string move()
        {
            return "Walk";
        }
        public override string talk()
        {
            return "Woof";
        }
        public override string type()
        {
            return "Dog";
        }
    }

    // child class's class
    class GreatDane : Dog
    {
        public override string type()
        {
            return "Gread Dane";
        }
    }

    // child class's child class
    class YorkShireTerrier : Dog
    {
        public override string type()
        {
            return "York Shire Terrier";
        }
    }

    // class cat
    class Cat : Animal
    {
        public override string move()
        {
            return "Walk";
        }
        public override string talk()
        {
            return "Meow";
        }
        public override string type()
        {
            return "Cat";
        }
    }
    // child cat class's child class
    class HouseCat : Cat
    {
        public override string type()
        {
            return "House Cat";
        }
    }

    // child cat class's child class
    class GreatCat: Cat
    {
        public override string type()
        {
            return "Great Cat";
        }
    }

    // class horse
    class Horse : Animal 
    {
        public override string move()
        {
            return "Run";
        }
        public override string talk()
        {
            return "Whinny";
        }
        public override string type()
        {
            return "Horse";
        }
    }
}
