using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingStrategy.Models
{
    public class Product
    {
        public int Id { get; set; }
        public PricingStrategy PricingStrategy { get; set; }
        public List<Competitor> Competitors { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        public Product()
        {
            Competitors = new List<Competitor> { };
        }
    }
}
