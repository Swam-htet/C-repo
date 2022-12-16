using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_2_3_4_5
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // examples
            //this.MouseDown += new MouseEventHandler(form_mouseDown);
            //this.MouseMove += new MouseEventHandler(form_mouseMove);
            //this.MouseMove += new MouseEventHandler(form_cursorLocation);

            // topic 2
            //btn.MouseMove += new MouseEventHandler(form_btnRun);

            // topic 3
            //label.MouseMove += new MouseEventHandler(form_labelMove);

            // topic 4
            this.MouseDoubleClick += new MouseEventHandler(form_labelDoubleClick);

            // topic 5
            // this.MouseWheel += new MouseEventHandler(form_mouseWheel);
        }
        // example one
        private void form_mouseDown(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }

        // example two
        private void form_mouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }

        // example three
        private void form_cursorLocation(object sender, MouseEventArgs e)
        {

            label.Text = "X , Y : ( " + e.X + ", " + e.Y + " )";
        }

        // topic 2
        private void form_btnRun(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            btn.Location = new Point(r.Next(0, 250), r.Next(0, 250));
        }

        // topic 3
        private void form_labelMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            label.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }

        //topic 4
        private void form_labelDoubleClick(object sender, MouseEventArgs e)
        {
            label.BackColor = Color.FromArgb(255, 255, 255);
            
        }

        // topic 5
        private void form_mouseWheel(object sender, MouseEventArgs e)
        {

            int widthWheel = label.Size.Width;
            int heightWheel = label.Size.Height;

            widthWheel += e.Delta;
            heightWheel += e.Delta;

            label.Text = "width : " + widthWheel + "|| height: " + heightWheel;
            label.Size = new Size(widthWheel, heightWheel);
        }

    }
}
