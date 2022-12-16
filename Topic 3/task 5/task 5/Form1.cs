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
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int input = int.Parse(this.inputText.Text);

            char grade;

            if(input >= 0 && input<= 100)
            {
                if(input > 70)
                {
                    grade = 'A';
                }
                else if(input > 60 && input <= 70)
                {
                    grade = 'B';
                }
                else if(input > 50 && input <= 60)
                {
                    grade = 'C';
                }
                else if(input >40 && input <= 50)
                {
                    grade = 'D';
                }
                else if(input > 30 && input <= 40)
                {
                    grade = 'E';
                }
                else
                {
                    grade = 'F';
                }
                MessageBox.Show("This is grade : " + grade);
            }
            else
            {
                MessageBox.Show("Invalid Number");
            }
        }
    }
}
