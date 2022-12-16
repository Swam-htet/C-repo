namespace topic_7_example
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCal = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(162, 276);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 0;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(276, 276);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(162, 151);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number to Add";
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(315, 157);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 13);
            this.output.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label output;
    }
}

