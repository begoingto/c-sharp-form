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
    public partial class CalculatorValue : Form
    {
        public CalculatorValue()
        {
            InitializeComponent();
        }

        private void txtValue1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CalculatorValue_Load(object sender, EventArgs e)
        {
        }

        private void CalculatorValue_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtValue1.Text.Trim());
            int num2 = int.Parse(txtValue2.Text.Trim());
            //this.txtResult.Text = $"{num1} + {num2} ={num1 + num2}";
            this.txtResult.AppendText($"{num1} + {num2} ={num1 + num2}\r\n");
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValue1_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
