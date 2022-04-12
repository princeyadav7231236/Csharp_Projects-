using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanerVersion2._0
{
    class Party
    {
        public const int costOfFoodPerPerson = 25;
        public decimal CostOfDecorations = 0;
        private bool fancyDecorations;
        private int numberOfPeople;

        public Party(int numberOfPeople, bool fancyDecorarions)
        {
            this.fancyDecorations = fancyDecorarions;
            this.NumberOfPeople = numberOfPeople;
        }
        public virtual int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
            {
                CostOfDecorations = (15M * NumberOfPeople) + 50M;
            }
            else
            {
                CostOfDecorations = (7.5M * NumberOfPeople) + 30M;
            }
        }

        public virtual decimal CalculateCost()
        {
            decimal TotalCost = CostOfDecorations + (costOfFoodPerPerson * NumberOfPeople);
            if (NumberOfPeople > 12)
            {
                TotalCost += 100M;
            }
            return TotalCost;
        }
    }
}
