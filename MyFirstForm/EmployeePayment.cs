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
    public partial class EmployeePayment : Form
    {
        public EmployeePayment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EmployeePayment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long time = long.Parse(txtNum.Text.Trim());
            string str = "";

            if (time >= 0)
            {
                double salary = 50, tsalary;
                if (time >= 100)
                {
                    long x1, x2;
                    double rate1 = 1.25, rate2 = 1.5;
                    double salary2;
                    long x = time - 100;
                    if (x <= 20)
                    {
                        x1 = x;
                        x2 = 0;
                    }
                    else
                    {
                        x1 = 20;
                        x2 = x - 20;
                    }
                    salary2 = (x1 * rate1) + (x2 * rate2);
                    tsalary = salary + salary2;
                    str+= "*******************************\r\n";
                    str += $"Extra Time1= {x1} h\r\n";
                    str += $"Extra Time2= {x2} h\r\n";
                    str += $"Bonus Rate1= {rate1:c2}/h\r\n";
                    str += $"Bonus Rate2= {rate2:c2}/h\r\n";
                    str += $"Bonus salary= {salary2:c2}\r\n";
                    str += $"Basic salary= {salary:c2}\r\n";
                    str += $"Total salary= {tsalary:c2} \r\n";
                    str += "*******************************\r\n";
                }
                else
                {
                    double lrate = 0.5;
                    double lsalary = (100 - time) * lrate;
                    tsalary = salary - lsalary;
                    str += "*******************************\r\n";
                    str += $"Basic salary= {salary:c2}\r\n";
                    str += $"Lost Rate= {lrate:c2}/h\r\n";
                    str += $"Lost salary= {lsalary:c2}\r\n";
                    str += $"Total salary= {tsalary:c2}\r\n";
                    str += "*******************************\r\n";
                }
            }
            else
            {
                MessageBox.Show("Invalide Input");
            }
            txtNum.Text = null;
            txtResultPayment.AppendText(str);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
