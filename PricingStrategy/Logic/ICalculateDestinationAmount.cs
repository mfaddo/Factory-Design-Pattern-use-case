using PricingStrategy.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingStrategy.Logic
{
    public interface ICalculateDestinationAmount
    {
        decimal GetDestinationAmount
         (decimal originalPrice, decimal? value, MathOperations operations);
    }
}
