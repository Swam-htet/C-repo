using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_2
{
    public partial class Form1 : Form
    {
        // declaration of object by Book class, number of book => 5
        Book b1, b2, b3, b4, b5;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // store 5 books
            b1 = new Book();
            b2 = new Book();
            b3 = new Book();
            b4 = new Book();
            b5 = new Book();

        }

        private Book checkWhich()
        {
            Book which;
            int num = Int32.Parse(inputWhich.Text);

            

            if(num == 1)
            {
                which = b1;
            }
            else if (num == 2)
            {
                which = b2;
            }
            else if (num == 3)
            {
                which = b3;
            }
            else if (num == 4)
            {
                which = b4;
            }
            else
            {
                which = b5;
            }

            return which;
        }

        // store button
        private void storeBtn_Click(object sender, EventArgs e)
        {
            // assigning from front end input
            string title = inputTitle.Text;
            string arthur = inputName.Text;
            string isbn = inputISBN.Text;
            string genre = inputGenre.Text;

            // creation of a object from Book class and checking which book?
            Book selected;
            selected = checkWhich();

            // assigning to the selected book
            selected.Title = title;
            selected.AuthorName = arthur;
            selected.ISBN = isbn;
            selected.Genre = genre;
        }

        // display title button
        private void displayTitleBtn_Click(object sender, EventArgs e)
        {
            Book selected;
            selected = checkWhich();
            output.Text = "This is the title of the book : " + selected.Title;
        }

        // display arthur button 
        private void dispalyArthurBtn_Click(object sender, EventArgs e)
        {
            Book selected;
            selected = checkWhich();
            output.Text = "This is the Arthur Name of the book : " + selected.AuthorName;

        }

        // display ISBN button
        private void displayISBNBtn_Click(object sender, EventArgs e)
        {
            Book selected;
            selected = checkWhich();
            output.Text = "This is the ISBM of the book : " + selected.ISBN;

        }

        // display Genre Button
        private void displayGenreBtn_Click(object sender, EventArgs e)
        {
            Book selected;
            selected = checkWhich();
            output.Text = "This is the Genre of the book : " + selected.Genre;

        }




    }
}
