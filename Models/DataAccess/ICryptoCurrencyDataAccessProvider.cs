using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptocurrencyTrader.Models.DataAccess
{
    public interface ICryptoCurrencyDataAccessProvider
    {
        void AddCryptoCurrency(CryptoCurrency coin);
        void UpdateCryptoCurrency(CryptoCurrency coin);

        void DeleteCryptoCurrency(string id);

        Task<CryptoCurrency> GetCryptoCurrencySingleRecord(string id);

        Task<List<CryptoCurrency>> GetCryptoCurrencyRecords();
    }
}

