using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstForm
{
    public partial class ComboBoxDayMonthYear : Form
    {
        public ComboBoxDayMonthYear()
        {
            InitializeComponent();
        }

        private void ComboBoxDayMonthYear_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            for (int i = year - 100; i <= year+100; i++)
            {
                comboYear.Items.Add(i);
            }
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            comboYear.SelectedItem = year;
            comboMonth.SelectedIndex = month -1;
            comboDay.SelectedIndex = day-1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            createDay();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            createDay();
        }

        private void createDay()
        {
            int month =comboMonth.SelectedIndex +1;
            int year = int.Parse(comboYear.SelectedItem+"");
            if (month >= 1)
            {
                int maxDay = DateTime.DaysInMonth(year, month);
                comboDay.Items.Clear();
                for (int i = 1; i <= maxDay; i++)
                {
                    comboDay.Items.Add(i);
                }
            }
        }
    }
}
