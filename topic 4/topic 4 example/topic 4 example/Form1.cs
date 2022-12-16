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
            /*
            // for looping
            int baseNumber = Int32.Parse(inputBase.Text);
            int powerNumber = Int32.Parse(inputPower.Text);
            int ans = baseNumber;
            for(int counter = 0; counter < powerNumber -1; counter++)
            {
                ans *= baseNumber;
            }
            MessageBox.Show("This is total : " + ans);
            */


            /*
            // data declaration for while loop and do while loop
            DialogResult response;
            int ans;
            int baseNum;
            int times = 1;
            baseNum = Int32.Parse(inputBase.Text);
            ans = baseNum;
            */

            /*
            // while loop
            // 3 parameters in message box show method => content text, form header, yes no cancal input button
            response = MessageBox.Show("Should I raise to another power?", "Keep onPowering ? ", MessageBoxButtons.YesNo);
            while (response == DialogResult.Yes)
            {
                 ans = ans * baseNum;
                 times = times + 1;
                 response = MessageBox.Show("Should I raise to another power? Currently "+ baseNum + "^" + times, "Keep on Powering?", MessageBoxButtons.YesNo);
            }
            */

            
            /*
            //do while loop
            do
            {
                response = MessageBox.Show("Should I raise to another power? Currently "
                + baseNum + "^" + times, "Keep on Powering?", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    ans = ans * baseNum;
                    times = times + 1;
                }
            }
            while (response == DialogResult.Yes);
            
            */


            // total output result
            // MessageBox.Show("Raised " + times + " to " + ans);
            
        }
    
    }
}
