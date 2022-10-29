using GildedRoseKata.ItemProvider;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        private readonly ItemQualityProviderFactory _itemQualityProviderFactory;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
            _itemQualityProviderFactory = new ItemQualityProviderFactory();
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                var item = Items[i];
                UpdateQuality(item);
            }
        }

        private void UpdateQuality(Item item)
        {
            IItemQualityProvider provider = _itemQualityProviderFactory.GetItemQualityProvider(item.Name);
            var quality = provider.GetQuality(item.Quality,item.SellIn);
            var sellIn = provider.GetSellIn(item.SellIn);
            item.Quality = quality;
            item.SellIn = sellIn;
        }
    }
}
