namespace MyFirstForm
{
    partial class Salarytext
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
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpouse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChildren = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastSalary = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salary Tax System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salary";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(145, 114);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(267, 43);
            this.txtSalary.TabIndex = 2;
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(145, 164);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(267, 43);
            this.txtBonus.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bonus";
            // 
            // txtSpouse
            // 
            this.txtSpouse.Location = new System.Drawing.Point(145, 215);
            this.txtSpouse.Name = "txtSpouse";
            this.txtSpouse.Size = new System.Drawing.Size(267, 43);
            this.txtSpouse.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Spouse";
            // 
            // txtChildren
            // 
            this.txtChildren.Location = new System.Drawing.Point(145, 266);
            this.txtChildren.Name = "txtChildren";
            this.txtChildren.Size = new System.Drawing.Size(267, 43);
            this.txtChildren.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "Children";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(145, 345);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(178, 39);
            this.btnCal.TabIndex = 9;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Last Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 36);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tax";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtLastSalary
            // 
            this.txtLastSalary.AutoSize = true;
            this.txtLastSalary.Location = new System.Drawing.Point(177, 483);
            this.txtLastSalary.Name = "txtLastSalary";
            this.txtLastSalary.Size = new System.Drawing.Size(0, 36);
            this.txtLastSalary.TabIndex = 14;
            // 
            // txtTax
            // 
            this.txtTax.AutoSize = true;
            this.txtTax.Location = new System.Drawing.Point(177, 432);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(0, 36);
            this.txtTax.TabIndex = 13;
            this.txtTax.Click += new System.EventHandler(this.txtTax_Click);
            // 
            // Salarytext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 648);
            this.Controls.Add(this.txtLastSalary);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtChildren);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSpouse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nokora", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Salarytext";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salarytext";
            this.Load += new System.EventHandler(this.Salarytext_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChildren;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtLastSalary;
        private System.Windows.Forms.Label txtTax;
    }
}