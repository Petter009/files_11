using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace _11_Files
{
    internal class Portfolio
    {
        private List<IAsset> stocks;

        public Portfolio(List<IAsset> stocks)
        {
            this.stocks = stocks;
        }

        public Portfolio()
        {
            stocks = new List<IAsset>();
        }

        internal double GetTotalValue()
        {
            double result = 0;
            foreach (var Asset in stocks)
            {
                result += Asset.GetValue();
            }
            return result; 
        }

        internal void AddAsset(IAsset asset)
        {
            stocks.Add(asset);
        }

        internal IList<IAsset> GetAssets()
        {
            ReadOnlyCollection<IAsset> facade = new ReadOnlyCollection<IAsset>(stocks);
            return facade;
        }

        internal IAsset GetAssetByName(string v)
        {
            for (int i = 0; i < stocks.Count; i++)
            {
                if (stocks[i].GetName() == v)
                { return stocks[i];  };
            }
            return null;
        }

        internal IList<IAsset> GetAssetsSortedByName()
        {
            stocks.Sort(new StockNameComparator());
                return stocks;
        }

        internal IList<IAsset> GetAssetsSortedByValue()
        {
            stocks.Sort(new StockValueComparator());
            return stocks;
        }
    }
}