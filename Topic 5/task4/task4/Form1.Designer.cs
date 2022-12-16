namespace task4
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputArtist = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputGenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputWhich = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // storeBtn
            // 
            this.storeBtn.Location = new System.Drawing.Point(74, 314);
            this.storeBtn.Name = "storeBtn";
            this.storeBtn.Size = new System.Drawing.Size(75, 23);
            this.storeBtn.TabIndex = 0;
            this.storeBtn.Text = "Store Details";
            this.storeBtn.UseVisualStyleBackColor = true;
            this.storeBtn.Click += new System.EventHandler(this.storeBtn_Click);
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(173, 313);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(75, 23);
            this.displayBtn.TabIndex = 1;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Artist";
            // 
            // inputArtist
            // 
            this.inputArtist.Location = new System.Drawing.Point(130, 150);
            this.inputArtist.Name = "inputArtist";
            this.inputArtist.Size = new System.Drawing.Size(100, 20);
            this.inputArtist.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre";
            // 
            // inputGenre
            // 
            this.inputGenre.Location = new System.Drawing.Point(130, 183);
            this.inputGenre.Name = "inputGenre";
            this.inputGenre.Size = new System.Drawing.Size(100, 20);
            this.inputGenre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title";
            // 
            // inputTitle
            // 
            this.inputTitle.Location = new System.Drawing.Point(130, 118);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Size = new System.Drawing.Size(100, 20);
            this.inputTitle.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Which one?";
            // 
            // inputWhich
            // 
            this.inputWhich.Location = new System.Drawing.Point(130, 237);
            this.inputWhich.Name = "inputWhich";
            this.inputWhich.Size = new System.Drawing.Size(100, 20);
            this.inputWhich.TabIndex = 3;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(296, 118);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 13);
            this.output.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.output);
            this.Controls.Add(this.inputWhich);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputGenre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputArtist);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputArtist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputWhich;
        private System.Windows.Forms.Label output;
    }
}

