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
    public partial class FormCheckInOut : Form
    {
        public FormCheckInOut()
        {
            InitializeComponent();
        }

        private DateTime checkIn,checkOut;

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            checkOut = DateTime.Now;
            txtCheckOut.Text = checkIn.ToString("dddd, dd-MMM-yyyy hh:mm:ss tt");
            if (txtCheckIn.Text!="")
            {
                //double totalMin = (checkOut.AddSeconds(-checkOut.Second).AddTicks(-checkOut.Ticks) 
                //                  - 
                //                   checkIn.AddSeconds(-checkIn.Second).AddTicks(-checkIn.Ticks)
                //                ).TotalMinutes;
                string cOut = checkOut.ToString("dd-MMM-yyyy hh:mm");
                string cIn = checkIn.ToString("dd-MMM-yyyy hh:mm");
                DateTime o = DateTime.ParseExact(cOut, "dd-MMM-yyyy hh:mm",System.Globalization.CultureInfo.InvariantCulture);
                DateTime i = DateTime.ParseExact(cIn, "dd-MMM-yyyy hh:mm", System.Globalization.CultureInfo.InvariantCulture);
                double totalMin = (o - i).TotalMinutes;
                //txtResult.Text = $"Time: IN:{i.ToString("dd-MMM-yyyy hh:mm")} OUT:{o.ToString("dd-MMM-yyyy hh:mm")}  \n";
                txtResult.Text = $"You are here {totalMin} min\r\n";
                txtResult.AppendText("We are free for you 1h\r\n");
                totalMin -= 60;
                if (totalMin <= 0)
                {
                    totalMin = 0;
                    txtResult.AppendText("No need pay see you again\r\n");
                }
                else
                {
                    int mint = (int)totalMin % 60;
                    int hour = (int)totalMin / 60;
                    txtResult.AppendText($"You are stay here {hour} h and {mint} min\r\n");
                    double payment = hour * 2000;
                    if (mint==0)
                    {
                        payment += 0;
                    }
                    else if (mint <= 15)
                    {
                        payment += 500;
                    }
                    else if (mint <= 30)
                    {
                        payment += 1000;
                    }
                    else if (mint <= 45)
                    {
                        payment += 1500;
                    }
                    else
                    {
                        payment += 200;
                    }
                    txtResult.AppendText($"Payment is {payment} Riel");
                }
            }
            else
            {
                MessageBox.Show("Please Press checkIn first");
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            checkIn = DateTime.Now;
            txtCheckIn.Text=checkIn.ToString("dddd, dd-MMM-yyyy hh:mm:ss tt");
        }
    }
}
