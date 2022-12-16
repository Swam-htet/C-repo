namespace task_3
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
            this.inputOne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTwo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputOne
            // 
            this.inputOne.Location = new System.Drawing.Point(188, 108);
            this.inputOne.Name = "inputOne";
            this.inputOne.Size = new System.Drawing.Size(100, 20);
            this.inputOne.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the upper range number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dividing Number";
            // 
            // inputTwo
            // 
            this.inputTwo.Location = new System.Drawing.Point(188, 152);
            this.inputTwo.Name = "inputTwo";
            this.inputTwo.Size = new System.Drawing.Size(100, 20);
            this.inputTwo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Click Here";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(51, 247);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputTwo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputTwo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label output;
    }
}

