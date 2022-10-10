using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingStrategy.Common
{
   public enum PricingMethod
    {
        LowerThan=1,
        HigherThan,
        Match
    }
    public enum CompetitorAggregationType
    {
        Average=1,
        Maximum,
        Minimum
    }

    public enum CalculationType
    {
        Amount=1,
        Percentage
    }

    public enum MathOperations
    {
        Add = 1,
        Sub,
        Equal

    }

}
