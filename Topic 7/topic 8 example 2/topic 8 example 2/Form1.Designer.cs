namespace topic_8_example_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.inputReal = new System.Windows.Forms.TextBox();
            this.inputUser = new System.Windows.Forms.TextBox();
            this.inputPW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Real Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add User Name :";
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(365, 58);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 13);
            this.output.TabIndex = 2;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(74, 211);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 3;
            this.btn.Text = "Click Here";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // inputReal
            // 
            this.inputReal.Location = new System.Drawing.Point(146, 55);
            this.inputReal.Name = "inputReal";
            this.inputReal.Size = new System.Drawing.Size(100, 20);
            this.inputReal.TabIndex = 4;
            // 
            // inputUser
            // 
            this.inputUser.Location = new System.Drawing.Point(146, 92);
            this.inputUser.Name = "inputUser";
            this.inputUser.Size = new System.Drawing.Size(100, 20);
            this.inputUser.TabIndex = 5;
            // 
            // inputPW
            // 
            this.inputPW.Location = new System.Drawing.Point(146, 128);
            this.inputPW.Name = "inputPW";
            this.inputPW.Size = new System.Drawing.Size(100, 20);
            this.inputPW.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add password :";
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(74, 169);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(55, 17);
            this.check.TabIndex = 8;
            this.check.Text = "Admin";
            this.check.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputPW);
            this.Controls.Add(this.inputUser);
            this.Controls.Add(this.inputReal);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox inputReal;
        private System.Windows.Forms.TextBox inputUser;
        private System.Windows.Forms.TextBox inputPW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox check;
    }
}

