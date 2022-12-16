using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_3
{
    public partial class Form1 : Form
    {
        // creation of list with person data type
        List<Person> people;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            people = new List<Person>();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (inputName.Text == "" && inputAge.Text == "")
            {
                output.Text = "Wrong input condition.";
            }
            else
            {
                // input taking 
                string name = inputName.Text;
                int age = Int32.Parse(inputAge.Text);

                // adding the input value to the people list by using .add method and person class's constructor
                people.Add(new Person(name, age));

                output.Text = people.Count + " number of people in the list.";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (inputSearch.Text == "")
            {
                output.Text = "Wrong Search input taking condition";
            }
            else
            {
                string search = inputSearch.Text;
                for (int i = 0; i < people.Count; i++)
                {
                    if (search.ToLower() == people[i].Name.ToLower())
                    {
                        output.Text = search + " is " + people[i].Age;
                    }
                }
            }
        }
    }
}
