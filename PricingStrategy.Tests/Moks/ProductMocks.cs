using PricingStrategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingStrategy.Tests.Moks
{
    internal class ProductMocks
    {
        public static Product CreateProductObject()
        {
            return new Product
            {
                Id = 1,
                Competitors = new List<Competitor>
                {
                    new Competitor { CompetitorPrice = 30, Name = "c1" },
                    new Competitor { CompetitorPrice = 60, Name = "c2" },
                    new Competitor { CompetitorPrice = 70, Name = "c3" },
                },
                Cost = 40,
                Price = 55
            };
        }
    }
}
