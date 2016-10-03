using System;

namespace _11_Files
{
    public class Stock : IAsset
    {
        public Stock()  { }

        public Stock(string v1, double v2, int v3)
        {
            symbol = v1;
            pricepershare = v2;
            numshares = v3;
                  
        }

        private string symbol;

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        private double pricepershare;

        public double PricePerShare
        {
            get { return pricepershare; }
            set { pricepershare = value; }
        }
        private int numshares;


        public int NumShares
        {
            get { return numshares; }
            set { numshares = value; }
        }

        public long Id { get; internal set; }

        public double GetValue()
        {
            return (pricepershare * numshares);
        }

        public static double TotalValue(Stock[] stocks)
        {
          return stocks[0].GetValue() + stocks[1].GetValue();
        }
        public override string ToString()
        {
            return "Stock[symbol=" + symbol + ",pricePerShare=" + pricepershare.ToString().Replace(',','.') + ",numShares=" + numshares +"]";
        }
        public override bool Equals(Object o)
        {
            if (o is Stock)
            {
                Stock s = (Stock)o;
                if (symbol == s.Symbol && pricepershare == s.PricePerShare && numshares == s.NumShares)
                { return true; }
                else
                    return false;
            }
            else
                return false;
        }

        public static object TotalValue(IAsset[] portfolio)
        {
            double result = 0;
            foreach (var Asset in portfolio)
            {
                result += Asset.GetValue();
            }
            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public string GetName()
        {
            return symbol;
        }
    }
    
}