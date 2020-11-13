using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptocurrencyTrader.Models.DataAccess
{
    public class CryptoCurrencyDataAccessProvider : ICryptoCurrencyDataAccessProvider
    {
        private readonly PostgresRdsDbContext _context;

        public CryptoCurrencyDataAccessProvider(PostgresRdsDbContext context)
        {
            _context = context;
        }

        public void AddCryptoCurrency(CryptoCurrency coin)
        {
            _context.CryptoCurrencies.Add(coin);
            _context.SaveChanges();
        }

        public void UpdateCryptoCurrency(CryptoCurrency coin)
        {
            _context.CryptoCurrencies.Update(coin);
            _context.SaveChanges();
        }

        public async Task<CryptoCurrency> GetCryptoCurrencySingleRecord(string name)
        {
            return _context.CryptoCurrencies.FirstOrDefault(t => t.Name == name);
        }

        public async Task<List<CryptoCurrency>> GetCryptoCurrencyRecords()
        {
            List<CryptoCurrency> listOfRecords = _context.CryptoCurrencies.ToList();
            return listOfRecords;
        }

        public void DeleteCryptoCurrency(string name)
        {
            var entity = _context.CryptoCurrencies.FirstOrDefault(t => t.Name == name);
            _context.CryptoCurrencies.Remove(entity);
            _context.SaveChanges();
        }
    }
}