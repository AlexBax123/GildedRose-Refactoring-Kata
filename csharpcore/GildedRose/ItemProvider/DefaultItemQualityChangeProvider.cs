using GildedRoseKata.Constants;

namespace GildedRoseKata.ItemProvider
{
    public class DefaultItemQualityChangeProvider : IItemQualityProvider
    {
        public string Name => ItemNames.DefaultName;

        public int SellInDecrease => 1;

        public int GetSellIn(int sellIn)
        {
            sellIn -= SellInDecrease;
            return sellIn;
        }

        public int GetQuality(int quality, int sellIn)
        {
            quality--;
            if (sellIn <= 0)
                quality--;
            return quality < 0 ? 0: quality;
        }
    }
}

