using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planer
{
    class DinnerParty
    {
        public int NumberOfPeople;
        public decimal CostOfBeveragePerPerson;
        public decimal CostOfDecorations;
        public const int CostOfFoodPerPerson = 25;

        public void SetHealthyOption(bool HealthyOption)
        {
            if (HealthyOption == true)
            {
                CostOfBeveragePerPerson = 5M;
            }
            else
            {
                CostOfBeveragePerPerson = 20M;
            }
        }

        public void CalculateCostOfDecorations(bool fancyDecorations)
        {
            if (fancyDecorations == true)
            {
                CostOfDecorations = (15M * NumberOfPeople) + 50M;
            }
            else
            {
                CostOfDecorations = (7.5M * NumberOfPeople) + 30M;
            }
        }

        public decimal CalculateCost(bool healthyOptionChecked)
        {
            decimal totalMoney = (decimal)((CostOfBeveragePerPerson * NumberOfPeople) + CostOfDecorations + (25 * NumberOfPeople));
            if(healthyOptionChecked == true)
            {
                decimal finalCostOfHealthyOption = (decimal)(totalMoney) - (decimal)(0.05M * totalMoney);
                return finalCostOfHealthyOption;
            }
            else
            {
                return totalMoney;
            }
        }
    }
}
