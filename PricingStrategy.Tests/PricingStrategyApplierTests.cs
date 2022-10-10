using PricingStrategy.Logic;
using PricingStrategy.Tests.Moks;

namespace PricingStrategy.Tests
{
    [TestClass]
    public class PricingStrategyApplierTests
    {
       
        [TestMethod]
        public void Apply_Higher_Than_Average_Competitor_NotViolateCostBoundary_ReturnsAVGPricePlusValue()
        {
            //arrange 
            var product = ProductMocks.CreateProductObject();
            product.PricingStrategy = PricingStrategyMocks.CreateAvgCompetitorHigherThan();

            var newPrice = PricingStrategyApplier.ApplyStrategy(product);

            //assert 
            var expectedOutput = product.Competitors.Average
                (c => c.CompetitorPrice) +
                product.PricingStrategy.ChangeProductPriceBy.Value;

            Assert.AreEqual(newPrice,expectedOutput );
        }

        [TestMethod]
        public void Apply_Lower_Than_Average_Competitor_NotViolateCostBoundary_ReturnsAVGPriceMinusValue()
        {
            //arrange 
            var product = ProductMocks.CreateProductObject();
            product.PricingStrategy = PricingStrategyMocks.CreateAvgCompetitorLowerThan();

            var newPrice = PricingStrategyApplier.ApplyStrategy(product);

            //assert 
            var expectedOutput = product.Competitors.Average
                (c => c.CompetitorPrice) -
                product.PricingStrategy.ChangeProductPriceBy.Value;

            Assert.AreEqual(newPrice, expectedOutput);
        }


        [TestMethod]
        public void Apply_Match_Average_Competitor_NotViolateCostBoundary_ReturnsAVGPrice()
        {
            //arrange 
            var product = ProductMocks.CreateProductObject();
            product.PricingStrategy = PricingStrategyMocks.CreateAvgCompetitorMatch();

            var newPrice = PricingStrategyApplier.ApplyStrategy(product);

            //assert 
            var expectedOutput = product.Competitors.Average
                (c => c.CompetitorPrice);

            Assert.AreEqual(newPrice, expectedOutput);
        }

        [TestMethod]
        public void Apply_Lower_Min_Competitor_ViolateCostBoundary_ReturnsOriginalPrice()
        {
            //arrange 
            var product = ProductMocks.CreateProductObject();
            product.PricingStrategy = PricingStrategyMocks.CreateMinCompetitorLower();

            var newPrice = PricingStrategyApplier.ApplyStrategy(product);

            //assert 

            Assert.AreEqual(newPrice, product.Price);
        }


        // you can add Test cases to cover the Applier class
        // which they too many =D
    }
}