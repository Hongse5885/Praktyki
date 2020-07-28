using System;

public class DinnerParty
{
    public int NumberOfPeople;
    public decimal CostOfBeveragesPerPerson = 0M;
    public decimal CostOfDecorations = 0M;
    public const int CostOfFoodPerPerson = 25;

    public void SetHealthyOption(bool healthyOption)
    {
        if (healthyOption)
            CostOfBeveragesPerPerson = 5.00M;
        else
            CostOfBeveragesPerPerson = 20.00M;
    }

    public void CalculateCostOfDecoration(bool fancy)
    {
        if (fancy)
            CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
        else
            CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
    }

    public decimal CalculateCost(bool healthyOption)
    {
        decimal totalCost = CostOfDecorations +
            ((CostOfBeveragesPerPerson + CostOfFoodPerPerson)
            * NumberOfPeople);
        if (healthyOption)
            return totalCost * .95M;
        else
            return totalCost;
    }
}
