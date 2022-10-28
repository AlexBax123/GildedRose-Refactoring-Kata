using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTests
    {
        private const string _agedBrie = "Aged Brie";
        private const string _backStagePass = "Backstage passes to a TAFKAL80ETC concert";
        private const string _defaultName = "nonSpecialName";
        private const string _sulfuras = "Sulfuras, Hand of Ragnaros";

        #region aged Brie


        [Fact]
        public void UpdateQuality_ShouldIncreaseQualityBy1_WhenNameIsAgedBrie_AndQualityLessThan50_AndSellINotPassed()
        {
            // Arrange
            string expectedName = _agedBrie;
            int sellIn = 10;
            int quality= 25;
            int expectedQuality = 26;
            IList<Item> items = new List<Item> { new Item { Name = expectedName, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(expectedName, items[0].Name);
            Assert.Equal(expectedQuality, items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_ShouldIncreaseQualityBy2_WhenNameIsAgedBrie_AndQualityLessthan49_AndSellIPassed()
        {
            // Arrange
            string expectedName = _agedBrie;
            int sellIn = 0;
            int quality = 48;
            int expectedQuality = 50;
            IList<Item> items = new List<Item> { new Item { Name = expectedName, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(expectedName, items[0].Name);
            Assert.Equal(expectedQuality, items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_ShouldIncreaseQualityBy1_WhenNameIsAgedBrie_AndQualityIs49_AndSellIPassed()
        {
            // Arrange
            string expectedName = _agedBrie;
            int sellIn = 0;
            int quality = 49;
            int expectedQuality = 50;
            IList<Item> items = new List<Item> { new Item { Name = expectedName, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(expectedName, items[0].Name);
            Assert.Equal(expectedQuality, items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_ShouldNotIncreaseQuality_WhenNameIsAgedBrie_AndQualityIs50()
        {
            // Arrange
            string expectedName = _agedBrie;
            int sellIn = 15;
            int quality = 50;
            int expectedQuality = 50;
            IList<Item> items = new List<Item> { new Item { Name = expectedName, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(expectedName, items[0].Name);
            Assert.Equal(expectedQuality, items[0].Quality);
        }

        #endregion aged Brie

        #region default product

        [Fact]
        public void UpdateQuality_ShouldDecreaseQualityBy1_WhenNameIsDefault_AndQualityGreaterThan0_AndSellINotPassed()
        {
            // Arrange
            string expectedName = _defaultName;
            int sellIn = 10;
            int quality = 25;
            int expectedQuality = 24;
            IList<Item> items = new List<Item> { new Item { Name = expectedName, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(expectedName, items[0].Name);
            Assert.Equal(expectedQuality, items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_ShouldDecreaseQualityBy2_WhenNameIsDefault_AndQualityGreaterThan1_AndSellIPassed()
        {
            // Arrange
            string expectedName = _defaultName;
            int sellIn = 0;
            int quality = 25;
            int expectedQuality = 23;
            IList<Item> items = new List<Item> { new Item { Name = expectedName, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(expectedName, items[0].Name);
            Assert.Equal(expectedQuality, items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_ShouldDecreaseQualityBy1_WhenNameIsDefault_AndQualityis1_AndSellInPassed()
        {
            // Arrange
            string expectedName = _defaultName;
            int sellIn = 0;
            int quality = 1;
            int expectedQuality = 0;
            IList<Item> items = new List<Item> { new Item { Name = expectedName, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(expectedName, items[0].Name);
            Assert.Equal(expectedQuality, items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_ShouldNotDecreaseQuality_WhenNameIsDefault_AndQualityis0_AndSellInPassed()
        {
            // Arrange
            string expectedName = _defaultName;
            int sellIn = 0;
            int quality = 0;
            int expectedQuality = 0;
            IList<Item> items = new List<Item> { new Item { Name = expectedName, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(expectedName, items[0].Name);
            Assert.Equal(expectedQuality, items[0].Quality);
        }
        #endregion default product

        #region backstage pass

        [Fact]
        public void UpdateQuality_ShouldIncreaseQualityBy1_WhenNameIsBackstagePass_AndQualityLessThan50_AndSellGreaterThan10()
        {
            // Arrange
            string expectedName = _backStagePass;
            int sellIn = 11;
            int quality = 25;
            int expectedQuality = 26;
            IList<Item> items = new List<Item> { new Item { Name = expectedName, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(expectedName, items[0].Name);
            Assert.Equal(expectedQuality, items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_ShouldIncreaseQualityBy2_WhenNameIsBackstagePass_AndQualityLessThan48_AndSellBetween10And6()
        {
            // Arrange
            string expectedName = _backStagePass;
            int sellIn = 10;
            int quality = 25;
            int expectedQuality = 27;
            IList<Item> items = new List<Item> { new Item { Name = expectedName, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(expectedName, items[0].Name);
            Assert.Equal(expectedQuality, items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_ShouldIncreaseQualityBy3_WhenNameIsBackstagePass_AndQualityLessthan47_AndSellInBetween5And1()
        {
            // Arrange
            string expectedName = _backStagePass;
            int sellIn = 5;
            int quality = 47;
            int expectedQuality = 50;
            IList<Item> items = new List<Item> { new Item { Name = expectedName, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(expectedName, items[0].Name);
            Assert.Equal(expectedQuality, items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_ShouldDropQualityTo0_WhenNameIsBackStagePass_AndSellIPassed()
        {
            // Arrange
            string expectedName = _backStagePass;
            int sellIn = 0;
            int quality = 25;
            int expectedQuality = 0;
            IList<Item> items = new List<Item> { new Item { Name = expectedName, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(expectedName, items[0].Name);
            Assert.Equal(expectedQuality, items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_ShouldNotIncreaseQuality_WhenNameIsBackStagePass_AndQualityIs50()
        {
            // Arrange
            string expectedName = _backStagePass;
            int sellIn = 25;
            int quality = 50;
            int expectedQuality = 50;
            IList<Item> items = new List<Item> { new Item { Name = expectedName, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(expectedName, items[0].Name);
            Assert.Equal(expectedQuality, items[0].Quality);
        }

        #endregion backstage pass

        #region Sulfuras

        [Fact]
        public void UpdateQuality_ShouldNotChangeQuality_WhenNameIsSulfuras()
        {
            // Arrange
            string expectedName = _sulfuras;
            int sellIn = 25;
            int quality = 80;
            int expectedQuality = 80;
            IList<Item> items = new List<Item> { new Item { Name = expectedName, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(expectedName, items[0].Name);
            Assert.Equal(expectedQuality, items[0].Quality);
        }
        #endregion Sulfuras

        #region SellIn

        [Theory]
        [InlineData(_agedBrie, 25, 24)]
        [InlineData(_backStagePass, 25, 24)]
        [InlineData(_defaultName, 25, 24)]
        [InlineData(_sulfuras, 25, 25)]
        public void UpdateQuality_ShouldDecreaseSellin_WhenNameIsNotSulfuras(string name, int sellIn, int expectedSellIn)
        {
            // Arrange
            string expectedName = name;
            int quality = 25;
            IList<Item> items = new List<Item> { new Item { Name = expectedName, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(expectedName, items[0].Name);
            Assert.Equal(expectedSellIn, items[0].SellIn);
        }

        #endregion SellIn

    }
}
