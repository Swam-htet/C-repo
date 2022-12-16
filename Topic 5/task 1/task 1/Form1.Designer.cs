namespace task_1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputNum1 = new System.Windows.Forms.TextBox();
            this.inputNum2 = new System.Windows.Forms.TextBox();
            this.inputNum3 = new System.Windows.Forms.TextBox();
            this.inputWhich = new System.Windows.Forms.TextBox();
            this.storeBtn = new System.Windows.Forms.Button();
            this.findLargest = new System.Windows.Forms.Button();
            this.findSmallest = new System.Windows.Forms.Button();
            this.findAverage = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number One";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number Two";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number Three";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Which One?";
            // 
            // inputNum1
            // 
            this.inputNum1.Location = new System.Drawing.Point(120, 114);
            this.inputNum1.Name = "inputNum1";
            this.inputNum1.Size = new System.Drawing.Size(100, 20);
            this.inputNum1.TabIndex = 4;
            // 
            // inputNum2
            // 
            this.inputNum2.Location = new System.Drawing.Point(120, 147);
            this.inputNum2.Name = "inputNum2";
            this.inputNum2.Size = new System.Drawing.Size(100, 20);
            this.inputNum2.TabIndex = 5;
            // 
            // inputNum3
            // 
            this.inputNum3.Location = new System.Drawing.Point(120, 180);
            this.inputNum3.Name = "inputNum3";
            this.inputNum3.Size = new System.Drawing.Size(100, 20);
            this.inputNum3.TabIndex = 6;
            // 
            // inputWhich
            // 
            this.inputWhich.Location = new System.Drawing.Point(120, 227);
            this.inputWhich.Name = "inputWhich";
            this.inputWhich.Size = new System.Drawing.Size(100, 20);
            this.inputWhich.TabIndex = 7;
            // 
            // storeBtn
            // 
            this.storeBtn.Location = new System.Drawing.Point(68, 273);
            this.storeBtn.Name = "storeBtn";
            this.storeBtn.Size = new System.Drawing.Size(75, 23);
            this.storeBtn.TabIndex = 8;
            this.storeBtn.Text = "Store";
            this.storeBtn.UseVisualStyleBackColor = true;
            this.storeBtn.Click += new System.EventHandler(this.storeBtn_Click);
            // 
            // findLargest
            // 
            this.findLargest.Location = new System.Drawing.Point(68, 328);
            this.findLargest.Name = "findLargest";
            this.findLargest.Size = new System.Drawing.Size(75, 23);
            this.findLargest.TabIndex = 9;
            this.findLargest.Text = "Largest";
            this.findLargest.UseVisualStyleBackColor = true;
            this.findLargest.Click += new System.EventHandler(this.findLargest_Click);
            // 
            // findSmallest
            // 
            this.findSmallest.Location = new System.Drawing.Point(180, 328);
            this.findSmallest.Name = "findSmallest";
            this.findSmallest.Size = new System.Drawing.Size(75, 23);
            this.findSmallest.TabIndex = 10;
            this.findSmallest.Text = "Smallest";
            this.findSmallest.UseVisualStyleBackColor = true;
            this.findSmallest.Click += new System.EventHandler(this.findSmallest_Click);
            // 
            // findAverage
            // 
            this.findAverage.Location = new System.Drawing.Point(283, 328);
            this.findAverage.Name = "findAverage";
            this.findAverage.Size = new System.Drawing.Size(75, 23);
            this.findAverage.TabIndex = 11;
            this.findAverage.Text = "Average";
            this.findAverage.UseVisualStyleBackColor = true;
            this.findAverage.Click += new System.EventHandler(this.findAverage_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(283, 147);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 13);
            this.output.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 447);
            this.Controls.Add(this.output);
            this.Controls.Add(this.findAverage);
            this.Controls.Add(this.findSmallest);
            this.Controls.Add(this.findLargest);
            this.Controls.Add(this.storeBtn);
            this.Controls.Add(this.inputWhich);
            this.Controls.Add(this.inputNum3);
            this.Controls.Add(this.inputNum2);
            this.Controls.Add(this.inputNum1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputNum1;
        private System.Windows.Forms.TextBox inputNum2;
        private System.Windows.Forms.TextBox inputNum3;
        private System.Windows.Forms.TextBox inputWhich;
        private System.Windows.Forms.Button storeBtn;
        private System.Windows.Forms.Button findLargest;
        private System.Windows.Forms.Button findSmallest;
        private System.Windows.Forms.Button findAverage;
        private System.Windows.Forms.Label output;
    }
}

