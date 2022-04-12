using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swapping_Class_instances
{
    public partial class Form1 : Form
    {
        Elephant Lloyd;
        Elephant Lucinda;
        public Form1()
        {
            InitializeComponent();
            Lucinda = new Elephant()
            {
                Name = "Lucinda",
                EarSize = 33
            };
            Lloyd = new Elephant()
            {
                Name = "Lloyd",
                EarSize = 40
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant temp;
            temp = Lucinda;
            Lucinda = Lloyd;
            Lloyd = temp;
            MessageBox.Show("Objects Swapped.", "Swapped");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lloyd.tellMe("Hi", Lucinda);
            Lloyd.speakTo(Lucinda, "Hello");
            Lloyd = Lucinda;
            Lloyd.EarSize = 4531;
            Lloyd.WhoAmI();
        }
    }
}
