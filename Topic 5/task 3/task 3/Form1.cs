using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_3
{
    public partial class Form1 : Form
    {
        // declaration of object
        Movie m1, m2, m3, m4;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m1 = new Movie();
            m2 = new Movie();
            m3 = new Movie();
            m4 = new Movie();

        }

        // checking which movie to store
        private Movie checkingWhich()
        {
            Movie which;
            int num = Int32.Parse(inputWhich.Text);
            if (num == 1)
            {
                which = m1;
            }
            else if (num == 2)
            {
                which = m2;

            }
            else if (num == 3)
            {
                which = m3;
            }
            else
            {
                which = m4;
            }
            return which;

        }

        // store button function
        private void storeDisplay_Click(object sender, EventArgs e)
        {
            string movieTitle = inputTitle.Text;
            int movieYear = Int32.Parse(inputYear.Text);
            int movieRuntime = Int32.Parse(inputRuntime.Text);


            Movie selected;
            selected = checkingWhich();

            selected.Title = movieTitle;
            selected.Year = movieYear;
            selected.Runtime = movieRuntime;
        }

        // display function
        private void displayBtn_Click(object sender, EventArgs e)
        {
            Movie displayMovie = checkRuntime(m1,m2,m3,m4);
            output.Text = displayMovie.Title + " is the first movie that has a runtime with a certain\n minumum and miaximum range.\n";
        }

        // checking the movie 's runtime within 60 to 120 minmutes
        private Movie checkRuntime(Movie mm1, Movie mm2, Movie mm3, Movie mm4)
        {
            Movie range;

            if (mm1.Runtime >= 60 && mm1.Runtime<= 120)
            {
                range = mm1;
            }
            else if(mm2.Runtime >= 60 && mm2.Runtime <= 120)
            {
                range = mm2;
            }
            else if(mm3.Runtime >= 60 && mm3.Runtime <= 120){
                range = mm3;
            }
            else
            {
                range = mm4;
            }
            return range;
        }

    }
}
