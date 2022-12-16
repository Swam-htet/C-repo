using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // part one
            TextBoxTwo.Text = TextBoxOne.Text;

            //part two
            MessageBox.Show("This is your selected item > " + ComboBox.SelectedItem);

            //part three
            CheckBox.Checked = true;

        }
    }
}
