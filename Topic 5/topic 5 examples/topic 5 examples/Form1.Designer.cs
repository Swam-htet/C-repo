namespace topic_5_examples
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
            this.storeBtn = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.adjustBtn = new System.Windows.Forms.Button();
            this.displayOne = new System.Windows.Forms.Label();
            this.displayTwo = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputAge = new System.Windows.Forms.TextBox();
            this.whichPerson = new System.Windows.Forms.TextBox();
            this.inputAdjustAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // storeBtn
            // 
            this.storeBtn.Location = new System.Drawing.Point(141, 280);
            this.storeBtn.Name = "storeBtn";
            this.storeBtn.Size = new System.Drawing.Size(75, 23);
            this.storeBtn.TabIndex = 0;
            this.storeBtn.Text = "Store Details";
            this.storeBtn.UseVisualStyleBackColor = true;
            this.storeBtn.Click += new System.EventHandler(this.storeBtn_Click);
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(248, 280);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(75, 23);
            this.displayBtn.TabIndex = 1;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // adjustBtn
            // 
            this.adjustBtn.Location = new System.Drawing.Point(344, 280);
            this.adjustBtn.Name = "adjustBtn";
            this.adjustBtn.Size = new System.Drawing.Size(75, 23);
            this.adjustBtn.TabIndex = 2;
            this.adjustBtn.Text = "Adjust Age";
            this.adjustBtn.UseVisualStyleBackColor = true;
            this.adjustBtn.Click += new System.EventHandler(this.adjustBtn_Click);
            // 
            // displayOne
            // 
            this.displayOne.AutoSize = true;
            this.displayOne.Location = new System.Drawing.Point(245, 193);
            this.displayOne.Name = "displayOne";
            this.displayOne.Size = new System.Drawing.Size(83, 13);
            this.displayOne.TabIndex = 3;
            this.displayOne.Text = "label output one";
            // 
            // displayTwo
            // 
            this.displayTwo.AutoSize = true;
            this.displayTwo.Location = new System.Drawing.Point(245, 225);
            this.displayTwo.Name = "displayTwo";
            this.displayTwo.Size = new System.Drawing.Size(82, 13);
            this.displayTwo.TabIndex = 4;
            this.displayTwo.Text = "label output two";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(248, 33);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(100, 20);
            this.inputName.TabIndex = 5;
            // 
            // inputAge
            // 
            this.inputAge.Location = new System.Drawing.Point(248, 76);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(100, 20);
            this.inputAge.TabIndex = 6;
            // 
            // whichPerson
            // 
            this.whichPerson.Location = new System.Drawing.Point(248, 114);
            this.whichPerson.Name = "whichPerson";
            this.whichPerson.Size = new System.Drawing.Size(100, 20);
            this.whichPerson.TabIndex = 7;
            // 
            // inputAdjustAge
            // 
            this.inputAdjustAge.Location = new System.Drawing.Point(248, 150);
            this.inputAdjustAge.Name = "inputAdjustAge";
            this.inputAdjustAge.Size = new System.Drawing.Size(100, 20);
            this.inputAdjustAge.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Which One?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Age Adjustment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputAdjustAge);
            this.Controls.Add(this.whichPerson);
            this.Controls.Add(this.inputAge);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.displayTwo);
            this.Controls.Add(this.displayOne);
            this.Controls.Add(this.adjustBtn);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.storeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button storeBtn;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Button adjustBtn;
        private System.Windows.Forms.Label displayOne;
        private System.Windows.Forms.Label displayTwo;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputAge;
        private System.Windows.Forms.TextBox whichPerson;
        private System.Windows.Forms.TextBox inputAdjustAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

