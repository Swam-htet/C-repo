namespace example_2_list
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLargest = new System.Windows.Forms.Button();
            this.btnSmallest = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(101, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(200, 215);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(325, 215);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 13);
            this.output.TabIndex = 2;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(190, 98);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number to add : ";
            // 
            // btnLargest
            // 
            this.btnLargest.Location = new System.Drawing.Point(101, 257);
            this.btnLargest.Name = "btnLargest";
            this.btnLargest.Size = new System.Drawing.Size(75, 23);
            this.btnLargest.TabIndex = 5;
            this.btnLargest.Text = "Largest";
            this.btnLargest.UseVisualStyleBackColor = true;
            this.btnLargest.Click += new System.EventHandler(this.btnLargest_Click);
            // 
            // btnSmallest
            // 
            this.btnSmallest.Location = new System.Drawing.Point(200, 257);
            this.btnSmallest.Name = "btnSmallest";
            this.btnSmallest.Size = new System.Drawing.Size(75, 23);
            this.btnSmallest.TabIndex = 6;
            this.btnSmallest.Text = "Smallest";
            this.btnSmallest.UseVisualStyleBackColor = true;
            this.btnSmallest.Click += new System.EventHandler(this.btnSmallest_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(101, 299);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(174, 23);
            this.btnCount.TabIndex = 7;
            this.btnCount.Text = "Count 5 to 10";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnSmallest);
            this.Controls.Add(this.btnLargest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input);
            this.Controls.Add(this.output);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLargest;
        private System.Windows.Forms.Button btnSmallest;
        private System.Windows.Forms.Button btnCount;
    }
}

