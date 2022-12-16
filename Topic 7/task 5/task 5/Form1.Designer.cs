namespace task_5
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.inputArthur = new System.Windows.Forms.TextBox();
            this.inputYear = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arthur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "year :";
            // 
            // inputTitle
            // 
            this.inputTitle.Location = new System.Drawing.Point(101, 153);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Size = new System.Drawing.Size(100, 20);
            this.inputTitle.TabIndex = 4;
            // 
            // inputArthur
            // 
            this.inputArthur.Location = new System.Drawing.Point(101, 182);
            this.inputArthur.Name = "inputArthur";
            this.inputArthur.Size = new System.Drawing.Size(100, 20);
            this.inputArthur.TabIndex = 5;
            // 
            // inputYear
            // 
            this.inputYear.Location = new System.Drawing.Point(100, 213);
            this.inputYear.Name = "inputYear";
            this.inputYear.Size = new System.Drawing.Size(100, 20);
            this.inputYear.TabIndex = 6;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(253, 155);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 13);
            this.output.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Search with year :";
            // 
            // inputSearch
            // 
            this.inputSearch.Location = new System.Drawing.Point(101, 307);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(100, 20);
            this.inputSearch.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.output);
            this.Controls.Add(this.inputYear);
            this.Controls.Add(this.inputArthur);
            this.Controls.Add(this.inputTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputTitle;
        private System.Windows.Forms.TextBox inputArthur;
        private System.Windows.Forms.TextBox inputYear;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Button button1;
    }
}

