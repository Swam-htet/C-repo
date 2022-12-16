using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic_5_examples
{
    public partial class Form1 : Form
    {
        // object declaration
        Person p1, p2, p3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // object creation

            p1 = new Person();
            p2 = new Person();
            p3 = new Person();

        }

        // person data return function
        private Person getDesiredPerson()
        {
            Person whichOne;

            int input = Int32.Parse(whichPerson.Text);
            if( input <= 1)
            {
                whichOne = p1;
            }
            else if (input >= 3)
            {
                whichOne = p3;
            }
            else
            {
                whichOne = p2;
            }
            return whichOne;

        }


        // display button function
        private void displayBtn_Click(object sender, EventArgs e)
        {
            Person selected;
            selected = getDesiredPerson();
            displayOne.Text = selected.Name;
            displayTwo.Text = ""+ selected.Age;

        }

        // store button function
        private void storeBtn_Click(object sender, EventArgs e)
        {
            string name = inputName.Text;
            int age = Int32.Parse(inputAge.Text);

            // int index;
            Person selected;
            selected = getDesiredPerson();

            selected.Name = name;
            selected.Age = age;
        }

        // adjust button function
        private void adjustBtn_Click(object sender, EventArgs e)
        {
            Person selected;
            int amount = Int32.Parse(inputAdjustAge.Text);
            selected = getDesiredPerson();
            selected.adjustAge(amount);

        }



    }
}
