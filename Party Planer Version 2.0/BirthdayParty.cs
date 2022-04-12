using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanerVersion2._0
{
    class BirthdayParty : Party
    {
        public int CakeSize;
        
        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string CakeWriting)
            :base(numberOfPeople, fancyDecorations)
        {
            calculateCakeSize();
            this.cakeWriting = CakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }

        private void calculateCakeSize()
        {
            if (NumberOfPeople <= 4)
                CakeSize = 8;
            else
                CakeSize = 16;
        }

        private string cakeWriting = "";
        public string CakeWriting
        {
            get
            {
                return this.cakeWriting;
            }
            set
            {
                int maxLength;
                if (CakeSize == 8)
                {
                    maxLength = 16;
                }
                else
                {
                    maxLength = 40;
                }
                if (value.Length > maxLength)
                {
                    MessageBox.Show("Too many letters for a " + CakeSize + " inch cake.");
                    if (maxLength > this.cakeWriting.Length)
                        maxLength = this.cakeWriting.Length;
                    this.cakeWriting = cakeWriting.Substring(0, maxLength);
                }
                else
                {
                    this.cakeWriting = value; 
                }
            }
        }

        public override decimal CalculateCost()
        { 
            decimal cakeCost;
            if (CakeSize == 8)
                cakeCost = 40M + CakeWriting.Length * 0.25M;
            else
                cakeCost = 75M + CakeWriting.Length * 0.25M;
            return base.CalculateCost() + cakeCost;
        }

        public override int NumberOfPeople
        {
            get
            {
                return base.NumberOfPeople;
            }
            set
            {
                base.NumberOfPeople = value;
                calculateCakeSize();
                this.CakeWriting = cakeWriting;
            }
        }

        
    }
}
