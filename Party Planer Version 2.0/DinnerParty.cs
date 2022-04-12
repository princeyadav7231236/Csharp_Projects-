using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanerVersion2._0 
{
    class DinnerParty : Party
    {
        public decimal CostOfBeveragePerPerson;
        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations) 
            :base(numberOfPeople, fancyDecorations)
        {
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }
                 
        public void SetHealthyOption(bool HealthyOption)
        {
            if (HealthyOption)
            {
                CostOfBeveragePerPerson = 5M;
            }
            else
            {
                CostOfBeveragePerPerson = 20M;
            }
        }
                
        public decimal CalculateCost(bool healthyOptionChecked)
        {
            decimal totalMoney = (CostOfBeveragePerPerson * NumberOfPeople) + base.CalculateCost();
            if(healthyOptionChecked)           
                return totalMoney * .95M;
            else            
                return totalMoney;            
        }
    }
}
