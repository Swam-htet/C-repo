namespace task_2
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
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputGenre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputWhich = new System.Windows.Forms.TextBox();
            this.storeBtn = new System.Windows.Forms.Button();
            this.displayTitleBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.displayArthurBtn = new System.Windows.Forms.Button();
            this.displayISBNBtn = new System.Windows.Forms.Button();
            this.displayGenreBtn = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // inputTitle
            // 
            this.inputTitle.Location = new System.Drawing.Point(105, 117);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Size = new System.Drawing.Size(100, 20);
            this.inputTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author Name";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(105, 154);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(100, 20);
            this.inputName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ISBN";
            // 
            // inputISBN
            // 
            this.inputISBN.Location = new System.Drawing.Point(105, 193);
            this.inputISBN.Name = "inputISBN";
            this.inputISBN.Size = new System.Drawing.Size(100, 20);
            this.inputISBN.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Genre";
            // 
            // inputGenre
            // 
            this.inputGenre.Location = new System.Drawing.Point(105, 228);
            this.inputGenre.Name = "inputGenre";
            this.inputGenre.Size = new System.Drawing.Size(100, 20);
            this.inputGenre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Which Book?";
            // 
            // inputWhich
            // 
            this.inputWhich.Location = new System.Drawing.Point(105, 276);
            this.inputWhich.Name = "inputWhich";
            this.inputWhich.Size = new System.Drawing.Size(100, 20);
            this.inputWhich.TabIndex = 1;
            // 
            // storeBtn
            // 
            this.storeBtn.Location = new System.Drawing.Point(30, 315);
            this.storeBtn.Name = "storeBtn";
            this.storeBtn.Size = new System.Drawing.Size(75, 23);
            this.storeBtn.TabIndex = 2;
            this.storeBtn.Text = "Store detail";
            this.storeBtn.UseVisualStyleBackColor = true;
            this.storeBtn.Click += new System.EventHandler(this.storeBtn_Click);
            // 
            // displayTitleBtn
            // 
            this.displayTitleBtn.Location = new System.Drawing.Point(250, 115);
            this.displayTitleBtn.Name = "displayTitleBtn";
            this.displayTitleBtn.Size = new System.Drawing.Size(143, 23);
            this.displayTitleBtn.TabIndex = 3;
            this.displayTitleBtn.Text = "Display Title";
            this.displayTitleBtn.UseVisualStyleBackColor = true;
            this.displayTitleBtn.Click += new System.EventHandler(this.displayTitleBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Book Data";
            // 
            // displayArthurBtn
            // 
            this.displayArthurBtn.Location = new System.Drawing.Point(250, 151);
            this.displayArthurBtn.Name = "displayArthurBtn";
            this.displayArthurBtn.Size = new System.Drawing.Size(143, 23);
            this.displayArthurBtn.TabIndex = 3;
            this.displayArthurBtn.Text = "Display Arthur Name";
            this.displayArthurBtn.UseVisualStyleBackColor = true;
            this.displayArthurBtn.Click += new System.EventHandler(this.dispalyArthurBtn_Click);
            // 
            // displayISBNBtn
            // 
            this.displayISBNBtn.Location = new System.Drawing.Point(250, 189);
            this.displayISBNBtn.Name = "displayISBNBtn";
            this.displayISBNBtn.Size = new System.Drawing.Size(143, 23);
            this.displayISBNBtn.TabIndex = 3;
            this.displayISBNBtn.Text = "Display ISBN";
            this.displayISBNBtn.UseVisualStyleBackColor = true;
            this.displayISBNBtn.Click += new System.EventHandler(this.displayISBNBtn_Click);
            // 
            // displayGenreBtn
            // 
            this.displayGenreBtn.Location = new System.Drawing.Point(250, 228);
            this.displayGenreBtn.Name = "displayGenreBtn";
            this.displayGenreBtn.Size = new System.Drawing.Size(143, 23);
            this.displayGenreBtn.TabIndex = 3;
            this.displayGenreBtn.Text = "Display Genre";
            this.displayGenreBtn.UseVisualStyleBackColor = true;
            this.displayGenreBtn.Click += new System.EventHandler(this.displayGenreBtn_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(255, 283);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(70, 13);
            this.output.TabIndex = 4;
            this.output.Text = "This is output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 448);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.output);
            this.Controls.Add(this.displayGenreBtn);
            this.Controls.Add(this.displayISBNBtn);
            this.Controls.Add(this.displayArthurBtn);
            this.Controls.Add(this.displayTitleBtn);
            this.Controls.Add(this.storeBtn);
            this.Controls.Add(this.inputGenre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputWhich);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputTitle);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputWhich;
        private System.Windows.Forms.Button storeBtn;
        private System.Windows.Forms.Button displayTitleBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button displayArthurBtn;
        private System.Windows.Forms.Button displayISBNBtn;
        private System.Windows.Forms.Button displayGenreBtn;
        private System.Windows.Forms.Label output;
    }
}

