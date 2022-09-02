namespace MyFirstForm
{
    partial class ComboBoxDayMonthYear
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
            this.comboDay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboDay
            // 
            this.comboDay.FormattingEnabled = true;
            this.comboDay.Location = new System.Drawing.Point(61, 111);
            this.comboDay.Name = "comboDay";
            this.comboDay.Size = new System.Drawing.Size(121, 44);
            this.comboDay.TabIndex = 0;
            this.comboDay.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Day";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Month";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboMonth
            // 
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboMonth.Location = new System.Drawing.Point(231, 111);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(121, 44);
            this.comboMonth.TabIndex = 2;
            this.comboMonth.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboYear
            // 
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Location = new System.Drawing.Point(393, 111);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(121, 44);
            this.comboYear.TabIndex = 4;
            this.comboYear.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // ComboBoxDayMonthYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 241);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboDay);
            this.Font = new System.Drawing.Font("Nokora", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ComboBoxDayMonthYear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBoxDayMonthYear";
            this.Load += new System.EventHandler(this.ComboBoxDayMonthYear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboYear;
    }
}