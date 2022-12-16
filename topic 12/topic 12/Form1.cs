using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace topic_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PhuMyat\Documents\own.accdb");
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM student", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);


            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;


        }
    }
}
