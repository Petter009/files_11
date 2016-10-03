using System;
using System.IO;

namespace _11_Files
{
    internal class StockIO
    {
        internal void WriteStock(StringWriter sw, Stock hp)
        {
            sw.WriteLine(hp.GetName().ToUpper());
            sw.WriteLine(hp.PricePerShare.ToString("F1"));
            sw.WriteLine(hp.NumShares) ;
        }

        internal Stock ReadStock(StringReader data)
        {
            string name = data.ReadLine();
            double price = double.Parse(data.ReadLine());
            int numshares = int.Parse(data.ReadLine());

            return  new Stock(name, price, numshares);
        }

        internal void WriteStock(FileInfo output, Stock hp)
        {
            using (StreamWriter writer = output.AppendText())
            {
                writer.WriteLine(hp.Symbol);
                writer.WriteLine(hp.PricePerShare);
                writer.WriteLine(hp.NumShares);

            }
        }

        internal Stock ReadStock(FileInfo output)
        {
            using (StreamReader reader = output.OpenText())
            {
                string name = reader.ReadLine();
                double price = Double.Parse(reader.ReadLine());
                int numshares = Int32.Parse(reader.ReadLine());

                return new Stock(name, price, numshares);
            }
            
        }
    }
}