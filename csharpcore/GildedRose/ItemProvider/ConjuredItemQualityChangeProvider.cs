using GildedRoseKata.Constants;

namespace GildedRoseKata.ItemProvider
{
    public class ConjuredItemQualityChangeProvider : IItemQualityProvider
    {
        public string Name => ItemNames.Conjured;

        public int SellInDecrease => 1;

        public int GetSellIn(int sellIn)
        {
            sellIn -= SellInDecrease;
            return sellIn;
        }

        public int GetQuality(int quality, int sellIn)
        {
            quality -= 2;
            if (sellIn <= 0)
                quality -= 2;
            return quality < 0 ? 0 : quality;
        }
    }
}

