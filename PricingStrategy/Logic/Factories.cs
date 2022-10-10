using PricingStrategy.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingStrategy.Logic
{
    public static class Factories
    {
        public static ICompetitorAggregator FactorCompetitorAggregator
            (CompetitorAggregationType type)
        =>
            type switch
            {
                CompetitorAggregationType.Minimum =>
                new CalculateMinimumCompetitor(),
                CompetitorAggregationType.Maximum => 
                new CalculateMaximumCompetitor(),
                CompetitorAggregationType.Average => 
                new CalculateAverageCompetitor(),
                _ => throw new ArgumentException(
                    "Invalid CompetitorAggregationType")
            };
        

        public static ICalculateDestinationAmount 
            FactorAmountCalculations(CalculationType Type)
        =>
            Type switch
            {
                CalculationType.Amount => new CalculateDestinationByAmount(),
                CalculationType.Percentage => new CalculateDestinationByPercentage(),
                _ => throw new ArgumentException("Invalid CalculationType")
            };

        

        public static MathOperations FactorOperation(PricingMethod pricingMethod)
         =>
            pricingMethod switch
            {
                PricingMethod.HigherThan => MathOperations.Add,
                PricingMethod.LowerThan => MathOperations.Sub,
                PricingMethod.Match => MathOperations.Equal,
                _ => throw new ArgumentException(
                    "Invalid PricingMethod")
            };
        
    }
}
