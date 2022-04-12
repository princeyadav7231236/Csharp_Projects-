using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables_and_data_types_in_csharp
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        double reimburseRate = 0.39;
        double amountOwned;

        public Form1()
        {
            InitializeComponent();
        }
        public int MyMethod(bool yesNo)
        {
            if (yesNo)
            {
                MessageBox.Show("4565");
                return 45;
            }
            else
            {
                MessageBox.Show("785");
                return 78;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            startingMileage = (int)StartingMileageValue.Value;
            endingMileage = (int)EndingMileageValue.Value;

            if(startingMileage >= endingMileage)
            {
                MessageBox.Show("The Starting Mileage must be less then the Ending Mileage", "Cannot Calculate");
            }   
            else
            {
            milesTraveled = (double)(endingMileage - startingMileage);
            amountOwned = milesTraveled * reimburseRate;
            label4.Text = "$" + amountOwned;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " Miles", "Miles Traveled");
        }
    }
}
