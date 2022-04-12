using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swapping_Class_instances
{
    class Elephant
    {
        public int EarSize;
        public string Name;
        public void WhoAmI()
        {
            System.Windows.Forms.MessageBox.Show("My name is " + Name +
                ". My Ears are "+ EarSize + " inches tall.", Name + " Says...");
        }
        public void tellMe(string message, Elephant WhoSaidIt)
        {
            MessageBox.Show(WhoSaidIt.Name + " Says: "+ message);
        }
        public void speakTo(Elephant WhoToTalkTo, string message)
        {
            WhoToTalkTo.tellMe(message, this);
        }
        
    }
}
