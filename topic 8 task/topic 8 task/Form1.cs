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
        // declaration of list type of "Animal"
        List<Animal> myAnimalList;
        

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // creating of object
            myAnimalList = new List<Animal>();


        }

        public void addAnimal(string name,string type)
        {
            // check object
            Animal check = null;

            if (type == "Dog")
            {
                check = new Dog();
            }
            if(type == "Cat")
            {
                check = new Cat();
            }
            if(type == "Horse")
            {
                check = new Horse();
            }
            if( type == "House Cat")
            {
                check = new HouseCat();
            }
            if(type == "Great Cat")
            {
                check = new GreatCat();
            }
            if(type == "Great Dane")
            {
                check = new GreatDane();
            }
            if(type == "Yorkshire Terrier")
            {
                check = new YorkshireTerrier();
            }

            // set name for check object
            check.Name = name;
            myAnimalList.Add(check);

            output.Text = "";

            // show list output
            for(int i =0; i < myAnimalList.Count; i++)
            {
                output.Text += myAnimalList[i].Name + " is a " + myAnimalList[i].queryType() + " has a " + myAnimalList[i].walk() + " and say " + myAnimalList[i].talk() + "\n";
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            addAnimal(inputName.Text,inputType.Text);

        }
    }
}
