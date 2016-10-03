using System;
using System.Collections.Generic;

namespace _11_Files
{
    internal class StockValueComparator : IComparer<IAsset>
    {
        public int Compare(IAsset x, IAsset y)
        {
            return y.GetValue().CompareTo(x.GetValue());
        }
    }
}