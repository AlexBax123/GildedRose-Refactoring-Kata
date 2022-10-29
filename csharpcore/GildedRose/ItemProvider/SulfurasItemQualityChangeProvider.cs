using GildedRoseKata.Constants;

namespace GildedRoseKata.ItemProvider
{
    public class SulfurasItemQualityChangeProvider : IItemQualityProvider
    {
        private const int sulfuralDefaultQuality = 80;

        public string Name => ItemNames.Sulfuras;

        public int SellInDecrease => 0;

        public int GetQuality(int quality, int sellIn)
        {
            return sulfuralDefaultQuality;
        }

        public int GetSellIn(int sellIn)
        {
            sellIn -= SellInDecrease;
            return sellIn;
        }
    }
}

