namespace MyFirstForm
{
    partial class CalculatorValue
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
            this.num = new System.Windows.Forms.Label();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Location = new System.Drawing.Point(109, 65);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(106, 36);
            this.num.TabIndex = 0;
            this.num.Text = "Value 1";
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(221, 65);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(587, 43);
            this.txtValue1.TabIndex = 1;
            this.txtValue1.TextChanged += new System.EventHandler(this.txtValue1_TextChanged);
            this.txtValue1.MouseEnter += new System.EventHandler(this.txtValue1_MouseEnter);
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(221, 132);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(587, 43);
            this.txtValue2.TabIndex = 3;
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Location = new System.Drawing.Point(109, 134);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(106, 36);
            this.txt1.TabIndex = 2;
            this.txt1.Text = "Value 2";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(12, 252);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(991, 222);
            this.txtResult.TabIndex = 5;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.Color.Green;
            this.btnCal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCal.Location = new System.Drawing.Point(221, 190);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(149, 47);
            this.btnCal.TabIndex = 4;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 84);
            this.checkedListBox1.TabIndex = 6;
            // 
            // CalculatorValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 493);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.num);
            this.Font = new System.Drawing.Font("Nokora", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CalculatorValue";
            this.Text = "CalculatorValue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalculatorValue_FormClosing);
            this.Load += new System.EventHandler(this.CalculatorValue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}