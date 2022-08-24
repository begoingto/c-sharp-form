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
            int num1 = int.Parse(txtValue1.Text);
            int num2 = int.Parse(txtValue2.Text);
            this.txtResult.Text = $"{num1} + {num2} ={num1 + num2}";
        }
    }
}
