using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    public class DinnerParty
    {
        const int CostOfFoodPerPerson = 25;
        public int NumberofPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;

        public void setHeathyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.0M;
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if(fancy){
                CostOfDecorations = NumberofPeople * 15.00M + 50M;
            }
            else{
                CostOfDecorations = NumberofPeople * 7.50M + 30M;
            }
        }

        public decimal CalculateCost(bool HealthyOption)
        {
            decimal totalCost = CostOfDecorations +
                ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberofPeople);
            if (HealthyOption)
            {
                totalCost *= 0.95M;
            }
            return totalCost;
        }
    }
}
