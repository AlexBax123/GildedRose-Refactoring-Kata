using GildedRoseKata.Constants;

namespace GildedRoseKata.ItemProvider
{
    public class AgedBrieItemQualityChangeProvider : IItemQualityProvider
    {
        public string Name => ItemNames.AgedBrie;

        public int SellInDecrease => 1;

        public int GetSellIn(int sellIn)
        {
            sellIn -= SellInDecrease;
            return sellIn;
        }

        public int GetQuality(int quality, int sellIn)
        {
            quality++;
            if (sellIn <= 0)
            {
                quality++;
            }
            return quality <= 50 ? quality : 50;
        }
    }
}

