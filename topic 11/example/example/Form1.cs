using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // check using system.io header
            StreamReader input;

            // for file choosing box
            OpenFileDialog ofd;

            // string to read
            string file;

            // after choosing file click open button ok, cancel or .... 
            DialogResult selected;

            // constructor for ofd
            ofd = new OpenFileDialog();

            // selected 
            selected = ofd.ShowDialog();

            // condition
            if(selected == DialogResult.OK)
            {
                file = ofd.FileName;
            }
            else
            {
                return;
            }

            input = new StreamReader(file);
            inputRichText.Text = input.ReadToEnd();
            input.Close();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // check using system.io header
            StreamWriter output;

            // for file choosing box
            SaveFileDialog sfd;

            // string to read
            string file;

            // after choosing file click open button ok, cancel or .... 
            DialogResult selected;

            // constructor for ofd
            sfd = new SaveFileDialog();

            // selected 
            selected = sfd.ShowDialog();

            // condition
            if (selected == DialogResult.OK)
            {
                file = sfd.FileName;
            }
            else
            {
                return;
            }
            output = new StreamWriter(file);
            output.WriteLine(inputRichText.Text);
            output.Close();

            

        }
    }
}
