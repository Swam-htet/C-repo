using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_5
{
    public partial class Form1 : Form
    {
        // array
        Book[] library;

        int index;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            library = new Book[10];

            //index = 0;
            library[0] = new Book("Hello world", "alphar", 2002);
            library[1] = new Book("Hello C#", "beta", 2010);

        }

        // add button
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*
            if(inputTitle.Text != "" && inputArthur.Text != "" && inputYear.Text != "")
            {
                // taking input
                string title = inputTitle.Text;
                string arthur = inputArthur.Text;
                int year = Int32.Parse(inputYear.Text);

                // adding new item to the array
                library[index] = new Book(title, arthur, year);

                // index increment
                index++;

                // showing output
                output.Text = index + " books in libraby.";

                // input reset
                //inputTitle.Text = "";
                // inputYear.Text = "";
                //inputArthur.Text = "";
            }

            else
            {
                output.Text = "Input Error.";
            }
            */
        }

        // search button
        private void button1_Click(object sender, EventArgs e)
        {
            int search = Int32.Parse(inputSearch.Text);

            // output.Text = "Book releaed in " + search + " : ";

            for(int i = 0; i < library.Length; i++)
            {
                if(library[i].Year == search)
                {
                    output.Text += library[i].Title + "\n";
                }
            }
        }
    }
}
