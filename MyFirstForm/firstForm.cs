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
    public partial class firstForm : Form
    {
        public firstForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;
            bool user = username.ToLower() == "admin";
            bool pwd = password == "admin";

            if (user && pwd)
            {
                this.Hide();
                new CalculatorValue().Show();
                //MessageBox.Show("Open Program");
            }
            else if(user)
            {
                MessageBox.Show("Incorrect Password");
            }
            else
            {
                MessageBox.Show("Invalided user name");
            }
        }
    }
}
