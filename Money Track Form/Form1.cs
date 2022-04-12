using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money_Track_form
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        public Form1()
        {
            InitializeComponent();
            bob = new Guy()
            {
                cash = 100,
                name = "Bob"
            };

            joe = new Guy()
            {
                cash = 50,
                name = "Joe"
            };

            UpdateForm();
        }
        public void UpdateForm()
        {
            JoeCashLabel.Text = joe.name + " has $" + joe.cash;
            BobCashLabel.Text = bob.name + " has $" + bob.cash;
            BankCashLabel.Text = "The bank has $"+ bank;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(bank >= 10)
            {
                bank -= joe.RecieveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            bob.cash += joe.GiveCash(10);
            UpdateForm();
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            joe.cash += bob.GiveCash(5);
            UpdateForm();
        }
    }
}
