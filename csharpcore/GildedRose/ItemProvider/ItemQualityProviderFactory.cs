using GildedRoseKata.Constants;
using System.Collections.Generic;

namespace GildedRoseKata.ItemProvider
{
    public class ItemQualityProviderFactory
    {
        private readonly IReadOnlyDictionary<string, IItemQualityProvider> _itemProviders;

        public ItemQualityProviderFactory()
        {
            var itemProviders = new Dictionary<string, IItemQualityProvider>();
            var agedBrieItemChangeProvider = new AgedBrieItemQualityChangeProvider();
            itemProviders.Add(agedBrieItemChangeProvider.Name, agedBrieItemChangeProvider);
            var backStagePassItemChangeProvider = new BackStagePassItemQualityChangeProvider();
            itemProviders.Add(backStagePassItemChangeProvider.Name, backStagePassItemChangeProvider);
            var defaultItemChangeProvider = new DefaultItemQualityChangeProvider();
            itemProviders.Add(defaultItemChangeProvider.Name, defaultItemChangeProvider);
            var sulfurasItemChangeProvider = new SulfurasItemQualityChangeProvider();
            itemProviders.Add(sulfurasItemChangeProvider.Name, sulfurasItemChangeProvider);
            var conjuredItemQualityChangeProvider = new ConjuredItemQualityChangeProvider();
            itemProviders.Add(conjuredItemQualityChangeProvider.Name, conjuredItemQualityChangeProvider);
            _itemProviders = itemProviders;
        }

        public IItemQualityProvider GetItemQualityProvider(string name)
        {
            return _itemProviders.ContainsKey(name) ? _itemProviders[name] : _itemProviders[ItemNames.DefaultName];
        }
    }
}
