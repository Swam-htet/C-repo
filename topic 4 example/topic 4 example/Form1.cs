using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic_4_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // example
            /*
            // taking input and type convetion
            int baseNumber = Int32.Parse(inputBase.Text);
            int powerNumber = Int32.Parse(inputPower.Text);

            int ans = baseNumber;

            // testing for loopint
            // intialization / condiuation / upkeep condition
            
            for(int counter = 0; counter < powerNumber - 1; counter++)
            {
                ans = ans * baseNumber;
            }
            */

            // while looping
            /*
            int counter = 0;
            while(counter < powerNumber - 1)
            {
                ans = ans * baseNumber;
                counter++;
            }
            */


            DialogResult response;
            int ans, time = 1;
            int baseNumber = Int32.Parse(inputBase.Text);
            ans = baseNumber;

            response = MessageBox.Show("Should I rasie to another power?", "Keep on powering?",MessageBoxButtons.YesNo);

            while(response == DialogResult.Yes)
            {
                ans = ans * baseNumber;
                time++;
                response = MessageBox.Show("Should I raise another power? Currently  " + baseNumber + "power  " + time , "Keep on powering?", MessageBoxButtons.YesNo);
            }
            MessageBox.Show("Rased  " +time+"  to   " + ans);
        }
    }
}
