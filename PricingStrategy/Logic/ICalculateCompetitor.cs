using PricingStrategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingStrategy.Logic
{
    public interface ICompetitorAggregator
    {
        decimal CalculateValue(List<Competitor> competitors);
    }
}
