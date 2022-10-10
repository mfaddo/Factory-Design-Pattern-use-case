using PricingStrategy.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingStrategy.Logic
{
    public class CalculateDestinationByPercentage : ICalculateDestinationAmount
    {
        public decimal GetDestinationAmount(decimal originalPrice, 
            decimal? value, MathOperations operations)
             =>
            value.HasValue ?
            operations switch
            {

                MathOperations.Sub => originalPrice - getPercentage(originalPrice,value.Value),
                MathOperations.Add => originalPrice + getPercentage(originalPrice, value.Value),
                MathOperations.Equal => originalPrice,
                _ => throw new ArgumentException("Invalid enum value for MathOperations"
                    , nameof(operations)),
            } : originalPrice;

        private decimal getPercentage(decimal originalPrice, decimal value) 
            => (value * originalPrice) / 100;
    }


}
