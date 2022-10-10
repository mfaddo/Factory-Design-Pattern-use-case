using PricingStrategy.Common;
using PricingStrategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingStrategy.Logic
{
    public  class PricingStrategyApplier
    {
        public static decimal ApplyStrategy(Product product)
        {
            decimal currentPrice = product.Price;

            // get the implementation based on competitors Aggregation Type (avg , min , max)
            ICompetitorAggregator competitorAggregator = Factories.
                FactorCompetitorAggregator
                (product.PricingStrategy.ProductPriceCompetitorsAggregationType);
            var SelectedPrice = competitorAggregator.CalculateValue
                (product.Competitors);

    



            //get the new price using provided configurations
           decimal newPrice = getDecimalValue(product.PricingStrategy.ProductPriceCalculationType,
                SelectedPrice, product.PricingStrategy.ChangeProductPriceBy, 
                product.PricingStrategy.SetMyPriceTo);


            decimal productCost = product.Cost;

            //get the Lower Boundary Cost using provided configurations
            decimal lowerCostBoundary =
                getDecimalValue(product.PricingStrategy.LowerCostCalculationType,
                productCost, product.PricingStrategy.LowerCostBoundaryValue,
                PricingMethod.LowerThan);

            //get the Higher Boundary Cost using provided configurations
            decimal higherCostBoundary =
                getDecimalValue(product.PricingStrategy.HigherCostCalculationType,
                productCost, product.PricingStrategy.HigherCostBoundaryValue,
                PricingMethod.HigherThan);

            

            // apply new price configuration only if new price in cost boundaries
            if (newPrice > lowerCostBoundary && newPrice < higherCostBoundary)
            {
                return newPrice;
            }
            return currentPrice;
        }


        /// <summary>
        /// This function calculate the orgiginal amount by apply 
        /// the configuration (add, minus and equal)
        /// and apply the amount or percentage method
        /// </summary>
        /// <param name="calculationType">enum with values (amount , percentage) based on this parameter this function will apply fixed amout or percentage to calculate the returned decimal</param>
        /// <param name="originalAmoun">the base amount that we need to (add , minus , equal ) from it</param>
        /// <param name="value">the value to be (added , minused) from original amout , provide null if PricingMethod is Match </param>
        /// <param name="pricingMethod">enum with values (lwoer than , higher than , match) this param decide to (sum , minus) the original amount and value</param>
        /// <returns></returns>
        private static decimal getDecimalValue(CalculationType calculationType
            ,decimal originalAmoun ,
            decimal? value,PricingMethod pricingMethod)
        {
            //get the implementation based on calculation type (amount or percentage)
            ICalculateDestinationAmount destinationAmountFactory = Factories.
                FactorAmountCalculations(calculationType);

            //get the value using above implmentation and based on (lower than , higher than , match)
            decimal calculatedValue = destinationAmountFactory.GetDestinationAmount
                (originalAmoun,
               value,
                Factories.FactorOperation(pricingMethod));
            return calculatedValue;
        }
    }
}
