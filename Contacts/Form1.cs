using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactDBDataSet.Phone' table. You can move, or remove it, as needed.
            this.phoneTableAdapter.Fill(this.contactDBDataSet.Phone);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact List 1.0. \n Written by :- Diwakar Singh", "About");
        }

        private void phoneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phoneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactDBDataSet);

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void contactIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void contactIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void companyLabel_Click(object sender, EventArgs e)
        {

        }

        private void companyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telephoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void telephoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientLabel_Click(object sender, EventArgs e)
        {

        }

        private void clientCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lastCallLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastCallTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

