using GildedRoseKata.Constants;

namespace GildedRoseKata.ItemProvider
{
    public class BackStagePassItemQualityChangeProvider : IItemQualityProvider
    {
        public string Name => ItemNames.BackStagePass;
        public int SellInDecrease => 1;

        public int GetSellIn(int sellIn)
        {
            sellIn -= SellInDecrease;
            return sellIn;
        }

        public int GetQuality(int quality, int sellInn)
        {
            if (sellInn <= 0)
            {
                return 0;
            }
            quality++;
            if (sellInn < 11)
            {
                quality++;
            }
            if (sellInn < 6)
            {
                quality++;
            }
            return quality <= 50 ? quality : 50;
        }
    }
}

