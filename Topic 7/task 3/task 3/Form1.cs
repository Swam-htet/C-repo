using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_3
{
    public partial class Form1 : Form
    {
        List<int> numList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numList = new List<int>();
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            
            for(int counter = 0; counter < 100; counter++)
            {
                
                output.Text += numList[0] + "\n";

            }
        }
    }
}
