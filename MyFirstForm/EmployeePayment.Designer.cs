namespace MyFirstForm
{
    partial class EmployeePayment
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResultPayment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Time of work";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(269, 104);
            this.txtNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(488, 43);
            this.txtNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nokora", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Payment System";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Nokora", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(775, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResultPayment
            // 
            this.txtResultPayment.Location = new System.Drawing.Point(11, 209);
            this.txtResultPayment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtResultPayment.Multiline = true;
            this.txtResultPayment.Name = "txtResultPayment";
            this.txtResultPayment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultPayment.Size = new System.Drawing.Size(904, 487);
            this.txtResultPayment.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result Payments";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // EmployeePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 703);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultPayment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nokora", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeePayment";
            this.Load += new System.EventHandler(this.EmployeePayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResultPayment;
        private System.Windows.Forms.Label label3;
    }
}