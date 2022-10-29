using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.Constants;

namespace GildedRoseTests
{
    public class GildedRoseTests
    {
        #region aged Brie


        [Fact]
        public void UpdateQuality_ShouldIncreaseQualityBy1_WhenNameIsAgedBrie_AndQualityLessThan50_AndSellINotPassed()
        {
            // Arrange
            string expectedName = ItemNames.AgedBrie;
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
            string expectedName = ItemNames.AgedBrie;
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
            string expectedName = ItemNames.AgedBrie;
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
            string expectedName = ItemNames.AgedBrie;
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
            string expectedName = "WhateverItemName";
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
            string expectedName = "WhateverItemName";
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
            string expectedName = "WhateverItemName";
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
            string expectedName = "WhateverItemName";
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
            string expectedName = ItemNames.BackStagePass;
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
            string expectedName = ItemNames.BackStagePass;
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
            string expectedName = ItemNames.BackStagePass;
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
            string expectedName = ItemNames.BackStagePass;
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
            string expectedName = ItemNames.BackStagePass;
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
            string expectedName = ItemNames.Sulfuras;
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
        [InlineData(ItemNames.AgedBrie, 25, 24)]
        [InlineData(ItemNames.BackStagePass, 25, 24)]
        [InlineData("whatever", 25, 24)]
        [InlineData(ItemNames.Sulfuras, 25, 25)]
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

        #region conjured product

        [Theory]
        [InlineData(25, 23)]
        [InlineData(2, 0)]
        public void UpdateQuality_ShouldDecreaseQualityBy2_WhenNameIsConjured_AndQualityGreaterThan1_AndSellINotPassed(int quality, int expectedQuality)
        {
            // Arrange
            string expectedName = ItemNames.Conjured;
            int sellIn = 10;
            IList<Item> items = new List<Item> { new Item { Name = expectedName, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(expectedName, items[0].Name);
            Assert.Equal(expectedQuality, items[0].Quality);
        }

        [Theory]
        [InlineData(25, 21)]
        [InlineData(4, 0)]
        public void UpdateQuality_ShouldDecreaseQualityBy4_WhenNameIsDefault_AndQualityGreaterThan3_AndSellIPassed(int quality, int expectedQuality)
        {
            // Arrange
            string expectedName = ItemNames.Conjured;
            int sellIn = 0;
            IList<Item> items = new List<Item> { new Item { Name = expectedName, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(expectedName, items[0].Name);
            Assert.Equal(expectedQuality, items[0].Quality);
        }

        [Theory]
        [InlineData(3, 0)]
        [InlineData(2, 0)]
        [InlineData(1, 0)]
        public void UpdateQuality_ShouldDecreaseQualityTo0_WhenNameIsConjured_AndQualityLessThan4_AndSellInPassed(int quality, int expectedQuality)
        {
            // Arrange
            string expectedName = ItemNames.Conjured;
            int sellIn = 0;
            IList<Item> items = new List<Item> { new Item { Name = expectedName, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal(expectedName, items[0].Name);
            Assert.Equal(expectedQuality, items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_ShouldNotDecreaseQuality_WhenNameIsConjured_AndQualityis0_AndSellInPassed()
        {
            // Arrange
            string expectedName = ItemNames.Conjured;
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
        #endregion conjured product

    }
}
