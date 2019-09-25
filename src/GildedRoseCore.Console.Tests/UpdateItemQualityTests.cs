using ConsoleApplication;
using Xunit;

namespace Tests
{
    public class UpdateItemQualityTests : GildedRoseTestBase
    {
        [Fact]
        public void TestTheTruth() 
        {
            Assert.True(true);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(5)]
        [InlineData(1)]
        public void UpdateItemQuality_SellInDecrements(int sellIn)
        {
            var item = new Item
            {
                SellIn = sellIn,
                Quality = 1
            };

            _app.UpdateItemQuality(item);
            Assert.Equal((sellIn - 1), item.SellIn);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(5)]
        [InlineData(1)]
        public void UpdateItemQuality_QualityDecrements(int quality)
        {
            var item = new Item
            {
                SellIn = 1,
                Quality = quality
            };

            _app.UpdateItemQuality(item);
            Assert.Equal((quality - 1), item.Quality);
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(-5)]
        [InlineData(-1)]
        public void UpdateItemQuality_SellInPast_QualityDecrementsTwice(int sellIn)
        {
            var item = new Item
            {
                Quality = 5,
                SellIn = sellIn
            };

            _app.UpdateItemQuality(item);
            Assert.Equal(3, item.Quality);
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(-5)]
        [InlineData(-1)]
        public void UpdateItemQuality_SellInPast_QualityZero_DoesntDecrement(int sellIn)
        {
            var item = new Item
            {
                Quality = 0,
                SellIn = sellIn
            };

            _app.UpdateItemQuality(item);
            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void UpdateItemQuality_QualityWithAge_IncrememntsQuality()
        {
            var updated = _app.UpdateItemQuality(_agedBrie);
            Assert.Equal(1, updated.Quality);
        }

        [Fact]
        public void UpdateItemQuality_LegendaryItem_DoesntDecreaseQuality()
        {
            var updated = _app.UpdateItemQuality(_sulfuras);
            Assert.Equal(80, updated.Quality);
        }

        [Fact]
        public void UpdateItemQuality_LegendaryItem_DoesntDecreaseSellIn()
        {
            var updated = _app.UpdateItemQuality(_sulfuras);
            Assert.Equal(0, updated.SellIn);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(6)]
        public void UpdateItemQuality_BackstagePass_IncreasesBy2_10DaysOrLess(int sellIn)
        {
            var item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = 0,
                SellIn = sellIn
            };
            var updated = _app.UpdateItemQuality(item);
            Assert.Equal(2, updated.Quality);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(1)]
        public void UpdateItemQuality_BackstagePass_IncreasesBy3_5DaysOrLess(int sellIn)
        {
            var item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = 0,
                SellIn = sellIn
            };
            var updated = _app.UpdateItemQuality(item);
            Assert.Equal(3, updated.Quality);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-5)]
        public void UpdateItemQuality_BackstagePass_DropsToZero_AfterSellIn(int sellIn)
        {
            var item = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = 10,
                SellIn = sellIn
            };
            var updated = _app.UpdateItemQuality(item);
            Assert.Equal(0, updated.Quality);
        }

        [Fact]
        public void UpdateItemQuality_ConjuredItems_DegradeTwiceAsFast()
        {
            var updated = _app.UpdateItemQuality(_conjuredManaCake);
            Assert.Equal(4, updated.Quality);
        }
    }
}
