using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_4
{
    public partial class Form1 : Form
    {
        List<User> numList = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOne = Int32.Parse(inputOne.Text);
                int numberTwo = Int32.Parse(inputTwo.Text);
                User current = new User(numberOne, numberTwo);
                numList.Add(current);
                string outputText = "Number one : " + current.Num1 + ", Number two : " + current.Num2 + ", Result : " + current.div();
                MessageBox.Show(outputText);
            }
            catch(FormatException er)
            {
                MessageBox.Show(er.Message);
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
