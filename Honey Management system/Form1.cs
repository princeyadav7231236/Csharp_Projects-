using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Honey_Consumption
{
    public partial class Form1 : Form
    {
        Queen queen;
        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nector Collector", "Honey Manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg Care", "Baby Bee Turtoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive Maintenance", "Sting Petrol" }, 149);
            workers[3] = new Worker(new string[] { "Nector Collector", "Honey Manufacturing",
            "Egg Care", "Baby Bee Turtoring", "Hive Maintenance", "Sting Petrol"}, 155);
            queen = new Queen(workers);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void assignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(WorkerBeeJob.Text, (int)Shifts.Value) == false)
                MessageBox.Show("No worker are available to do the job '" + WorkerBeeJob.Text +
                    "'", "The Queen Bee says ...");
            else
                MessageBox.Show("The job '" + WorkerBeeJob.Text + "' will be done in " +
                    Shifts.Value + " Shifts", "The Queen Bee says...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}
