using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randon_Sandwitch_maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MenuMaker Menu = new MenuMaker() { Randomizer = new Random()};
            label1.Text = Menu.GetMenuItem();
            label2.Text = Menu.GetMenuItem();
            label3.Text = Menu.GetMenuItem();
            label4.Text = Menu.GetMenuItem();
            label5.Text = Menu.GetMenuItem();
            label6.Text = Menu.GetMenuItem();
            
        }
       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
