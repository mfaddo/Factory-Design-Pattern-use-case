using PricingStrategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingStrategy.Logic
{
    public class CalculateMinimumCompetitor : ICompetitorAggregator
    {
        public decimal CalculateValue(List<Competitor> competitors)
        {
            return competitors.Min(c => c.CompetitorPrice);
        }
    }
}
