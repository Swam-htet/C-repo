using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task4
{
    public partial class Form1 : Form
    {
        // object declaration of Album class
        Album a1, a2, a3, a4, a5, a6;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // object assigning
            a1 = new Album();
            a2 = new Album();
            a3 = new Album();
            a4 = new Album();
            a5 = new Album();
            a6 = new Album();
        }


        // checking the which one?
        private Album whichCheck()
        {
            Album which;
            int num = Int32.Parse(inputWhich.Text);

            if(num == 1)
            {
                which = a1;
            }
            else if(num == 2)
            {
                which = a2;
            }
            else if(num == 3)
            {
                which = a3;
            }
            else if(num == 4)
            {
                which = a4;
            }
            else if(num == 5)
            {
                which = a5;
            }
            else
            {
                which = a6;
            }
            return which;
        }

        // display function
        private void displayBtn_Click(object sender, EventArgs e)
        {
            output.Text = checkGanre(a1,a2,a3,a4,a5,a6);
        }

        private string checkGanre(Album aa1,Album aa2, Album aa3, Album aa4, Album aa5, Album aa6)
        {
            string outputString ="This is the Album list: ";
            string check = inputGenre.Text;
            if(aa1.Genre == check)
            {
                outputString += aa1.Title + " ,";
            }
            if (aa2.Genre == check)
            {
                outputString += aa2.Title +" ,";
            }
            if (aa3.Genre == check)
            {
                outputString += aa3.Title + " ,";
            }
            if (aa4.Genre == check)
            {
                outputString += aa4.Title + " ,";
            }
            if (aa5.Genre == check)
            {
                outputString += aa5.Title + " ,";
            }
            if (aa6.Genre == check)
            {
                outputString += aa6.Title + " ,";
            }
            return outputString;
        }

        // store function
        private void storeBtn_Click(object sender, EventArgs e)
        {
            string albumTitle = inputTitle.Text;
            string albumArtist = inputArtist.Text;
            string albumGenre = inputGenre.Text;

            Album selected = whichCheck();

            selected.Title = albumTitle;
            selected.Artist = albumArtist;
            selected.Genre = albumGenre;

            
        }


    }
}
