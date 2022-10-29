
namespace GildedRoseKata.ItemProvider
{
    public interface IItemQualityProvider
    {
        int GetQuality(int quality, int sellIn);
        int GetSellIn(int sellIn);

        public string Name { get; }

        public int SellInDecrease { get; }

    }
}

