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
    public partial class Salarytext : Form
    {
        public Salarytext()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salary, bonus;
            int spouse, children;
            salary = double.Parse(txtSalary.Text);
            bonus = double.Parse(txtBonus.Text);
            spouse = int.Parse(txtSpouse.Text);
            children = int.Parse(txtChildren.Text);
            if (salary >= 0 && bonus >= 0)
            {
                int s = 0;
                s = spouse >= 1 ? 1 : s;

                if (children >= 9)
                {
                    children = 9;
                }
                else if (children <= 0)
                {
                    children = 0;
                }
                double family = 150000 * (spouse + children);
                double tax, l_salary;
                salary = salary - family;
                if (salary <= 1200000)
                {
                    tax = 0;
                }
                else if (salary <= 2000000)
                {
                    tax = salary * 0.05 - 60000;
                }
                else if (salary <= 8500000)
                {
                    tax = salary * 0.1 - 160000;
                }
                else if (salary <= 12500000)
                {
                    tax = salary * 0.15 - 585000;
                }
                else
                {
                    tax = salary * 0.2 - 1210000;
                }

                tax += bonus * 0.2;
                l_salary = (salary + family + bonus) - tax;

                this.txtTax.Text = $"{tax:#,##0.##} R";
                this.txtLastSalary.Text = $"{l_salary:#,##0.##} R";
            }
            else
            {
                string invalide = salary < 0 ? $"Salary :{salary}" : $"Bonus {bonus}";
                MessageBox.Show($"Sorry your value {invalide} invalided.");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtTax_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Salarytext_Load(object sender, EventArgs e)
        {

        }
    }
}
