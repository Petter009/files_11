using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11_Files

{
    internal class MemoryStockRepository : IStockRepository
    {
        private long id = 0;
        private Dictionary<long, Stock> stocks = new Dictionary<long, Stock>();

        public void Clear()
        {
            stocks.Clear();
        }

        public ICollection FindAllStocks()
        {
            return stocks;
        }

        public Stock LoadStock(long id)
        {
            return stocks[id];
        }

        public long NextId()
        {
            return ++id;
        }

        public void SaveStock(Stock stock)
        {
            stock.Id = NextId();
            stocks.Add(stock.Id, stock);
        }
    }
}