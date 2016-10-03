using System;
using System.Collections.Generic;
namespace _11_Files
{
    internal class StockNameComparator : IComparer<IAsset>
    {
        public int Compare(IAsset x, IAsset y)
        {
            return x.GetName().CompareTo(y.GetName());
        }
    }
}