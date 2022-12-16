using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic_8_task
{
    public partial class Form1 : Form
    {

        // animal list declaration
        List<Animal> myList;

        public Form1()
        {
            InitializeComponent();
        }

        // btn click function
        private void btn_Click(object sender, EventArgs e)
        {
            addAnimal(inputName.Text, inputType.Text);
        }

        // form load
        private void Form1_Load(object sender, EventArgs e)
        {
            // list assigning
            myList = new List<Animal>();
        }
        public void addAnimal(string n,string t)
        {
            // object to check and add to the list
            Animal check = null;

            if (n != "" && t != "") {
                // check text and assging to the object
                if (t == "Dog")
                {
                    check = new Dog();
                }
                else if (t == "Cat")
                {
                    check = new Cat();
                }
                else if (t == "Horse")
                {
                    check = new Horse();
                }
                else if (t == "Great Cat")
                {
                    check = new GreatCat();
                }
                else if (t == "House Cat")
                {
                    check = new HouseCat();
                }
                else if (t == "Great Dane")
                {
                    check = new GreatDane();
                }
                else if ( t== "York Shire Terrier")
                {
                    check = new YorkShireTerrier();
                }

                // assigning the name property
                check.Name = n;

                // adding the check to the list
                myList.Add(check);

                // reset output
                output.Text = "";

                // list output
                for(int i =0; i< myList.Count; i++)
                {
                    output.Text = myList[i].Name + " is a " + myList[i].type() + " has a " + myList[i].move() + " and say  " + myList[i].talk() + ".\n";
                }

            }
            
        }
    }
}
