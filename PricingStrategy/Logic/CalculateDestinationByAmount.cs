using PricingStrategy.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingStrategy.Logic
{
    public class CalculateDestinationByAmount : ICalculateDestinationAmount
    {
        public decimal GetDestinationAmount(decimal originalPrice, decimal? 
            value, MathOperations operations)
          =>
            value.HasValue ?
            operations switch
            {

                MathOperations.Sub => originalPrice - value.Value,
                MathOperations.Add => originalPrice + value.Value,
                MathOperations.Equal => originalPrice,
                _ => throw new ArgumentException("Invalid enum value for MathOperations", nameof(operations)),
            } : originalPrice;
        
    }
}
