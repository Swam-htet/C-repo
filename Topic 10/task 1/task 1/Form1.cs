using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    public partial class Form1 : Form
    {
        // taskCase list
        List<TastData> datalist = new List<TastData>();
        
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
                int b = Int32.Parse(inputBase.Text);
                int p = Int32.Parse(inputPower.Text);
                datalist.Add(new TastData(b, p));
                int index = datalist.Count - 1;
                output.Text = "Base : " + datalist[index].BaseNumber + ",  Power : " + datalist[index].PowerNumber + ",  Result : " + datalist[index].calculatePower();
            }
            catch
            {
                MessageBox.Show("Input Error. Try again.");
            }
            
        }
    }
}
