using System;
using System.Collections.Generic;
using APIClub.Domain;
using System.Linq;
using FileHelpers;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace APIClub.EntityFrameworkCore.Seed.Host
{
    internal class DefaultStocksCreator
    {
        private APIClubDbContext _context;

        public DefaultStocksCreator(APIClubDbContext context)
        {
            _context = context;
        }

        internal void Create()
        {
            ImportStockRecordsFromFile().Wait();
        }

        private async Task ImportStockRecordsFromFile()
        {
            var engine = new FileHelperAsyncEngine<StockRecord>();
            using (engine.BeginReadFile(@"C:\Users\Marco\Source\Repos\APIClub\aspnet-core\src\APIClub.EntityFrameworkCore\EntityFrameworkCore\Seed\Host\companylist.csv"))
            {
                foreach (var record in engine)
                {
                    await InsertIfNotExists(record);
                }
            }

        }

        private async Task InsertIfNotExists(StockRecord record)
        {
            if (_context.Stocks.IgnoreQueryFilters().Any(x => x.Symbol == record.Symbol))
                return;

            await _context.Stocks.AddAsync(new Stock
            {
                Symbol = record.Symbol,
                Name = record.Name,
                CreatorUserId = 1,
                LastModificationTime = DateTime.Now
            });

            await _context.SaveChangesAsync();
        }
    }

    [DelimitedRecord(";")]
    [IgnoreFirst]
    internal class StockRecord
    {
        public string Symbol;
        public string Name;
    }
}