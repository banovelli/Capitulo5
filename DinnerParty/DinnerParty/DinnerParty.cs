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
        private int numberOfPeople;
        public int NumberOfPeople {
            get { 
                return numberOfPeople; 
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            } 
        }
        private bool fancyDecorations;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            setHeathyOption(healthyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }

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
                CostOfDecorations = NumberOfPeople * 15.00M + 50M;
            }
            else{
                CostOfDecorations = NumberOfPeople * 7.50M + 30M;
            }
        }

        public decimal CalculateCost(bool HealthyOption)
        {
            decimal totalCost = CostOfDecorations +
                ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);
            if (HealthyOption)
            {
                return totalCost * .95M;
            }
            return totalCost;
        }
    }
}
