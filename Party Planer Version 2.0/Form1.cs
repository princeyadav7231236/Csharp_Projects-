using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanerVersion2._0
{
    public partial class Form1 : Form
    {
        BirthdayParty birthdayParty;
        DinnerParty dinnerParty;
         
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, false, true);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty( (int)numericUpDown1.Value, fancyBirthday.Checked,
                CakeWriting.Text);
            DisplayBirthdayPartyCost();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(checkBox2.Checked);
            dinnerParty.CalculateCostOfDecorations(checkBox1.Checked);
            DisplayDinnerPartyCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(checkBox1.Checked);
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            dinnerParty.CalculateCostOfDecorations(checkBox1.Checked);
            DisplayDinnerPartyCost();
        }

        private void CostLabel_TextChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            dinnerParty.CalculateCostOfDecorations(checkBox1.Checked);
            DisplayDinnerPartyCost();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = CakeWriting.Text;
            DisplayBirthdayPartyCost();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DisplayBirthdayPartyCost()
        {
            CakeWriting.Text = birthdayParty.CakeWriting;
            decimal cost = birthdayParty.CalculateCost();
            birthdayCost.Text = cost.ToString("c");
        }

        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerParty.CalculateCost(checkBox2.Checked);
            CostLabel.Text = cost.ToString("c");
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.CalculateCostOfDecorations(fancyBirthday.Checked);
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged_1(object sender, EventArgs e)
        {
            birthdayParty.CalculateCostOfDecorations(fancyBirthday.Checked);
            DisplayBirthdayPartyCost();
        }
    }
}
