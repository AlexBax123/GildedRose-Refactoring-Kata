using GildedRoseKata.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var BackStagePassItemChangeProvider = new BackStagePassItemQualityChangeProvider();
            itemProviders.Add(BackStagePassItemChangeProvider.Name, BackStagePassItemChangeProvider);
            var DefaultItemChangeProvider = new DefaultItemQualityChangeProvider();
            itemProviders.Add(DefaultItemChangeProvider.Name, DefaultItemChangeProvider);
            var SulfurasItemChangeProvider = new SulfurasItemQualityChangeProvider();
            itemProviders.Add(SulfurasItemChangeProvider.Name, SulfurasItemChangeProvider);
            _itemProviders = itemProviders;
        }

        public IItemQualityProvider GetItemQualityProvider(string name)
        {
            return _itemProviders.ContainsKey(name) ? _itemProviders[name] : _itemProviders[ItemNames.DefaultName];
        }
    }
}
