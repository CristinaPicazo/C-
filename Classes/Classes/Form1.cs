using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        BankAccount account1;
        private void button1_Click(object sender, EventArgs e)
        {
            account1 = new BankAccount("Cristina Picazo");
            //BankAccount account1 = new BankAccount("Cristina Picazo");
            label2.Text = "Account created in the name of: " + account1.GetAccount();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal cash = Convert.ToDecimal(textBox1.Text);
            account1.Deposit(cash);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal cash = Convert.ToDecimal(textBox1.Text);
            account1.Withdraw(cash);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = account1.Statement();
        }
    }
}
