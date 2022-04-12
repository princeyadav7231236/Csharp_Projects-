using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money_Track_form
{
    class Guy
    {
        public string name;
        public int cash;
        public int GiveCash(int amount)
        {
            if(amount <= cash && amount > 0)
            {
                cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("I don't have enough money to give you $"+ amount +" " + name + " Says ...");
                return 0;
            }
        }
        public int RecieveCash(int amount)
        {
            if (amount > 0)
            {
                cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show("$"+amount + " isn't an amount I'll take " + name + " Says...");
            }
            return 0;
        }

    }
}
