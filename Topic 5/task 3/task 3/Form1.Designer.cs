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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.inputYear = new System.Windows.Forms.TextBox();
            this.inputRuntime = new System.Windows.Forms.TextBox();
            this.inputWhich = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.storeDisplay = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year of Release";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Runtime(minutes)";
            // 
            // inputTitle
            // 
            this.inputTitle.Location = new System.Drawing.Point(161, 130);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Size = new System.Drawing.Size(100, 20);
            this.inputTitle.TabIndex = 4;
            // 
            // inputYear
            // 
            this.inputYear.Location = new System.Drawing.Point(161, 165);
            this.inputYear.Name = "inputYear";
            this.inputYear.Size = new System.Drawing.Size(100, 20);
            this.inputYear.TabIndex = 5;
            // 
            // inputRuntime
            // 
            this.inputRuntime.Location = new System.Drawing.Point(161, 200);
            this.inputRuntime.Name = "inputRuntime";
            this.inputRuntime.Size = new System.Drawing.Size(100, 20);
            this.inputRuntime.TabIndex = 6;
            // 
            // inputWhich
            // 
            this.inputWhich.Location = new System.Drawing.Point(161, 260);
            this.inputWhich.Name = "inputWhich";
            this.inputWhich.Size = new System.Drawing.Size(100, 20);
            this.inputWhich.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Which One?";
            // 
            // storeDisplay
            // 
            this.storeDisplay.Location = new System.Drawing.Point(75, 310);
            this.storeDisplay.Name = "storeDisplay";
            this.storeDisplay.Size = new System.Drawing.Size(75, 23);
            this.storeDisplay.TabIndex = 9;
            this.storeDisplay.Text = "Store Details";
            this.storeDisplay.UseVisualStyleBackColor = true;
            this.storeDisplay.Click += new System.EventHandler(this.storeDisplay_Click);
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(186, 310);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(75, 23);
            this.displayBtn.TabIndex = 10;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(300, 119);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 13);
            this.output.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.output);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.storeDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputWhich);
            this.Controls.Add(this.inputRuntime);
            this.Controls.Add(this.inputYear);
            this.Controls.Add(this.inputTitle);
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
        private System.Windows.Forms.TextBox inputTitle;
        private System.Windows.Forms.TextBox inputYear;
        private System.Windows.Forms.TextBox inputRuntime;
        private System.Windows.Forms.TextBox inputWhich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button storeDisplay;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Label output;
    }
}

