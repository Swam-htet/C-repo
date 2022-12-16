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

namespace topic_11_file_input_output
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // open file => read
        private void btnLoad_Click(object sender, EventArgs e)
        {
           
            // declaration 
             StreamReader input;
             OpenFileDialog ofd;
             String file;
             DialogResult selected;

            // open file dialog box opening 
             ofd = new OpenFileDialog();

            // select is open file dialog's show dialog value
             selected = ofd.ShowDialog();

            // if select is dialogResult.OK
             if (selected == DialogResult.OK)
             {
                // file path is ofd 's file name input 
                  file = ofd.FileName;
             }
             // if select is dialogResult.no or cancel or something
             else
             {
                  return;
             }

             // read form file path
             input = new StreamReader(file);

            // show tooutput
             text.Text = input.ReadToEnd();

            // what is input.close()
             input.Close();
            

        }

        // save => write
        private void btnSave_Click(object sender, EventArgs e)
        {
            // declaration part
            StreamWriter output;
            SaveFileDialog ofd;
            String file;
            DialogResult selected;

            // open save file dialog box
            ofd = new SaveFileDialog();

            // select is ofd's show dialog 
            selected = ofd.ShowDialog();

            // if dialog result is ok
            if (selected == DialogResult.OK)
            {
                // file path to file string varaible
                file = ofd.FileName;
            }
            // select is dialog result other
            else
            {
                return;
            }

            // choose file to write the data from file path sting 
            output = new StreamWriter(file);

            // write text from text box
            output.WriteLine(text.Text);

            // clear rich text box
            text.Text = "";


            output.Close();


        }
    }
}
