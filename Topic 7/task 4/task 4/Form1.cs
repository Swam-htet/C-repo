using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_4
{
    public partial class Form1 : Form
    {
        // array declaration
        Person[] people;

        // index
        int index;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // max lengthe of the array => 10
            people = new Person[10];

            index = 0;
        }

        // add new button 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(inputName.Text == "" && inputAge.Text == "")
            {
                output.Text = "Wrong input.";
            }
            else
            {
                // taking input
                string name = inputName.Text;
                int age = Int32.Parse(inputAge.Text);

                // adding the values into the array with construtor
                people[index] = new Person(name, age);

                // increment of index
                index++;

                // show output
                output.Text = index + " number in the list.";

                // input text reset
                inputAge.Text = "";
                inputName.Text = "";
            }
        }

        // seach button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (inputSearch.Text == "")
            {
                output.Text = "Wrong seach input.";
            }
            else
            {
                // taking search input
                string search = inputSearch.Text;

                // checking every element in the array with seach value
                for (int i = 0; i < people.Length; i++)
                {
                    if (search == people[i].Name)
                    {
                        output.Text = search + " is " + people[i].Age;
                    }
                }
            }
        }
    }
}
