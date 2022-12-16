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
            this.output = new System.Windows.Forms.Label();
            this.inputBase = new System.Windows.Forms.TextBox();
            this.inputPower = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(12, 34);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(79, 13);
            this.output.TabIndex = 0;
            this.output.Text = "This is output : ";
            // 
            // inputBase
            // 
            this.inputBase.Location = new System.Drawing.Point(105, 66);
            this.inputBase.Name = "inputBase";
            this.inputBase.Size = new System.Drawing.Size(100, 20);
            this.inputBase.TabIndex = 1;
            // 
            // inputPower
            // 
            this.inputPower.Location = new System.Drawing.Point(105, 102);
            this.inputPower.Name = "inputPower";
            this.inputPower.Size = new System.Drawing.Size(100, 20);
            this.inputPower.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Base : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Power :";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(105, 142);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(100, 23);
            this.btn.TabIndex = 5;
            this.btn.Text = "Calculate Power";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 229);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputPower);
            this.Controls.Add(this.inputBase);
            this.Controls.Add(this.output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label output;
        private System.Windows.Forms.TextBox inputBase;
        private System.Windows.Forms.TextBox inputPower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn;
    }
}

