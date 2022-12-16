namespace Task_2
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
            this.TextBoxTwo = new System.Windows.Forms.TextBox();
            this.TextBoxOne = new System.Windows.Forms.TextBox();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.Button = new System.Windows.Forms.Button();
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TextBoxTwo
            // 
            this.TextBoxTwo.Location = new System.Drawing.Point(96, 108);
            this.TextBoxTwo.Name = "TextBoxTwo";
            this.TextBoxTwo.Size = new System.Drawing.Size(245, 20);
            this.TextBoxTwo.TabIndex = 0;
            // 
            // TextBoxOne
            // 
            this.TextBoxOne.Location = new System.Drawing.Point(96, 56);
            this.TextBoxOne.Name = "TextBoxOne";
            this.TextBoxOne.Size = new System.Drawing.Size(245, 20);
            this.TextBoxOne.TabIndex = 0;
            this.TextBoxOne.Text = "Hello World";
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
            "Item 5",
            ""});
            this.ComboBox.Location = new System.Drawing.Point(96, 161);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(245, 21);
            this.ComboBox.TabIndex = 1;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(96, 258);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(65, 23);
            this.Button.TabIndex = 2;
            this.Button.Text = "Click Here";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.Location = new System.Drawing.Point(96, 213);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(83, 17);
            this.CheckBox.TabIndex = 3;
            this.CheckBox.Text = "Check Here";
            this.CheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 370);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.TextBoxOne);
            this.Controls.Add(this.TextBoxTwo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxTwo;
        private System.Windows.Forms.TextBox TextBoxOne;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.CheckBox CheckBox;
    }
}

