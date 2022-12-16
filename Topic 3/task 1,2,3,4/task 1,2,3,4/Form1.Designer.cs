namespace task_1_2_3_4
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
            this.inputOne = new System.Windows.Forms.TextBox();
            this.inputTwo = new System.Windows.Forms.TextBox();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.radioSub = new System.Windows.Forms.RadioButton();
            this.radioMulti = new System.Windows.Forms.RadioButton();
            this.radioDiv = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.comparisonOne = new System.Windows.Forms.Label();
            this.comparisonTwo = new System.Windows.Forms.Label();
            this.comparisonThree = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2:";
            // 
            // inputOne
            // 
            this.inputOne.Location = new System.Drawing.Point(89, 60);
            this.inputOne.Name = "inputOne";
            this.inputOne.Size = new System.Drawing.Size(100, 20);
            this.inputOne.TabIndex = 2;
            // 
            // inputTwo
            // 
            this.inputTwo.Location = new System.Drawing.Point(88, 89);
            this.inputTwo.Name = "inputTwo";
            this.inputTwo.Size = new System.Drawing.Size(100, 20);
            this.inputTwo.TabIndex = 3;
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Location = new System.Drawing.Point(242, 55);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(63, 17);
            this.radioAdd.TabIndex = 4;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "Addition";
            this.radioAdd.UseVisualStyleBackColor = true;
            // 
            // radioSub
            // 
            this.radioSub.AutoSize = true;
            this.radioSub.Location = new System.Drawing.Point(242, 79);
            this.radioSub.Name = "radioSub";
            this.radioSub.Size = new System.Drawing.Size(80, 17);
            this.radioSub.TabIndex = 5;
            this.radioSub.TabStop = true;
            this.radioSub.Text = "Substitution";
            this.radioSub.UseVisualStyleBackColor = true;
            // 
            // radioMulti
            // 
            this.radioMulti.AutoSize = true;
            this.radioMulti.Location = new System.Drawing.Point(242, 103);
            this.radioMulti.Name = "radioMulti";
            this.radioMulti.Size = new System.Drawing.Size(86, 17);
            this.radioMulti.TabIndex = 6;
            this.radioMulti.TabStop = true;
            this.radioMulti.Text = "Multiplication";
            this.radioMulti.UseVisualStyleBackColor = true;
            // 
            // radioDiv
            // 
            this.radioDiv.AutoSize = true;
            this.radioDiv.Location = new System.Drawing.Point(242, 127);
            this.radioDiv.Name = "radioDiv";
            this.radioDiv.Size = new System.Drawing.Size(62, 17);
            this.radioDiv.TabIndex = 7;
            this.radioDiv.TabStop = true;
            this.radioDiv.Text = "Division";
            this.radioDiv.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Click Here";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comparisonOne
            // 
            this.comparisonOne.AutoSize = true;
            this.comparisonOne.Location = new System.Drawing.Point(27, 214);
            this.comparisonOne.Name = "comparisonOne";
            this.comparisonOne.Size = new System.Drawing.Size(142, 13);
            this.comparisonOne.TabIndex = 9;
            this.comparisonOne.Text = "number one and number two";
            // 
            // comparisonTwo
            // 
            this.comparisonTwo.AutoSize = true;
            this.comparisonTwo.Location = new System.Drawing.Point(27, 243);
            this.comparisonTwo.Name = "comparisonTwo";
            this.comparisonTwo.Size = new System.Drawing.Size(114, 13);
            this.comparisonTwo.TabIndex = 10;
            this.comparisonTwo.Text = "result and number One";
            // 
            // comparisonThree
            // 
            this.comparisonThree.AutoSize = true;
            this.comparisonThree.Location = new System.Drawing.Point(27, 272);
            this.comparisonThree.Name = "comparisonThree";
            this.comparisonThree.Size = new System.Drawing.Size(111, 13);
            this.comparisonThree.TabIndex = 11;
            this.comparisonThree.Text = "result and number two";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comparisonThree);
            this.Controls.Add(this.comparisonTwo);
            this.Controls.Add(this.comparisonOne);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioDiv);
            this.Controls.Add(this.radioMulti);
            this.Controls.Add(this.radioSub);
            this.Controls.Add(this.radioAdd);
            this.Controls.Add(this.inputTwo);
            this.Controls.Add(this.inputOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputOne;
        private System.Windows.Forms.TextBox inputTwo;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.RadioButton radioSub;
        private System.Windows.Forms.RadioButton radioMulti;
        private System.Windows.Forms.RadioButton radioDiv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label comparisonOne;
        private System.Windows.Forms.Label comparisonTwo;
        private System.Windows.Forms.Label comparisonThree;
    }
}

