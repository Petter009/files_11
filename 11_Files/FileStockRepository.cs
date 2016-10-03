using System;
using System.Collections;
using System.IO;

namespace _11_Files
{
    internal class FileStockRepository : IStockRepository, IFileRepository
    {
        private long id = 1;
        private DirectoryInfo repositoryDir;

        public FileStockRepository(DirectoryInfo repositoryDir)
        {
            this.repositoryDir = repositoryDir;
        }

        public void Clear()
        {
            foreach  (FileInfo output in repositoryDir.GetFiles())
            {
                output.Delete();
            };
        }

        public ICollection FindAllStocks()
        {
            ICollection allfiles = repositoryDir.GetFiles();
            return allfiles;
        }

        public Stock LoadStock(long id)
        {
            FileInfo output = new FileInfo(repositoryDir + "stock" + id + ".txt");
            using (StreamReader reader = output.OpenText())
            {
                string name = reader.ReadLine();
                double price = Double.Parse(reader.ReadLine());
                int numshares = Int32.Parse(reader.ReadLine());

                return new Stock(name, price, numshares);
            }
        }

        public long NextId()
        {
            return ++id;
        }

        public void SaveStock(Stock yhoo)
        {
            yhoo.Id = id;
            FileInfo output = new FileInfo(repositoryDir + "stock" + yhoo.Id + ".txt");
            using (StreamWriter writer = output.AppendText())
            {
                
                writer.WriteLine(yhoo.Symbol);
                writer.WriteLine(yhoo.PricePerShare);
                writer.WriteLine(yhoo.NumShares);

            }
            ++id;
        }

        public string StockFileName(int v)
        {
            return "stock" + v + ".txt";
        }

        string IFileRepository.StockFileName(Stock hp)
        {
            return "stock" + hp.Id + ".txt";
        }
    }
}