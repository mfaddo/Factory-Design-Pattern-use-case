using PricingStrategy.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingStrategy.Models
{
    public class PricingStrategy
    {
        public PricingMethod SetMyPriceTo { get; set; }
        public CompetitorAggregationType ProductPriceCompetitorsAggregationType { get; set; }
        public CalculationType ProductPriceCalculationType { get; set; }
        public decimal? ChangeProductPriceBy { get; set; }
        public CalculationType LowerCostCalculationType { get; set; }
        public decimal LowerCostBoundaryValue { get; set; }   
        public CalculationType HigherCostCalculationType { get; set; }
        public decimal HigherCostBoundaryValue { get; set; }
    }
}
