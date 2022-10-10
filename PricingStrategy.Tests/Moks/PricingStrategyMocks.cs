using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingStrategy.Tests.Moks
{
    internal class PricingStrategyMocks
    {
        public static PricingStrategy.Models.PricingStrategy CreateAvgCompetitorHigherThan()
        {
            return new Models.PricingStrategy {
                ChangeProductPriceBy = 1,
                HigherCostBoundaryValue = 100,
                LowerCostBoundaryValue = 1, 
                LowerCostCalculationType =
                Common.CalculationType.Amount, 
                HigherCostCalculationType = 
                Common.CalculationType.Amount, 
                ProductPriceCalculationType = 
                Common.CalculationType.Amount, 
                ProductPriceCompetitorsAggregationType = 
                Common.CompetitorAggregationType.Average, 
                SetMyPriceTo = Common.PricingMethod.HigherThan 
            };
        }

        public static PricingStrategy.Models.PricingStrategy CreateAvgCompetitorLowerThan()
        {
            return new Models.PricingStrategy
            {
                ChangeProductPriceBy = 1,
                HigherCostBoundaryValue = 100,
                LowerCostBoundaryValue = 1,
                LowerCostCalculationType =
                Common.CalculationType.Amount,
                HigherCostCalculationType =
                Common.CalculationType.Amount,
                ProductPriceCalculationType =
                Common.CalculationType.Amount,
                ProductPriceCompetitorsAggregationType =
                Common.CompetitorAggregationType.Average,
                SetMyPriceTo = Common.PricingMethod.LowerThan
            };
        }

        public static PricingStrategy.Models.PricingStrategy CreateAvgCompetitorMatch()
        {
            return new Models.PricingStrategy
            {
                ChangeProductPriceBy = null,
                HigherCostBoundaryValue = 100,
                LowerCostBoundaryValue = 1,
                LowerCostCalculationType =
                Common.CalculationType.Amount,
                HigherCostCalculationType =
                Common.CalculationType.Amount,
                ProductPriceCalculationType =
                Common.CalculationType.Amount,
                ProductPriceCompetitorsAggregationType =
                Common.CompetitorAggregationType.Average,
                SetMyPriceTo = Common.PricingMethod.Match
            };
        }

        public static PricingStrategy.Models.PricingStrategy CreateMinCompetitorLower()
        {
            return new Models.PricingStrategy
            {
                ChangeProductPriceBy = 5,
                HigherCostBoundaryValue = 100,
                LowerCostBoundaryValue = 1,
                LowerCostCalculationType =
                Common.CalculationType.Amount,
                HigherCostCalculationType =
                Common.CalculationType.Amount,
                ProductPriceCalculationType =
                Common.CalculationType.Amount,
                ProductPriceCompetitorsAggregationType =
                Common.CompetitorAggregationType.Minimum,
                SetMyPriceTo = Common.PricingMethod.LowerThan
            };
        }
    }
}
