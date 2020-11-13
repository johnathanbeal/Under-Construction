using System.Collections.Generic;

namespace CryptocurrencyTrader.Services
{
    public interface ICryptoCurrencyService
    {
        List<CryptoCurrency> GetAllCurrencies();

        CryptoCurrency GetCryptoCurrencyById(int id);

        CryptoCurrency GetCryptoCurrencyByName(string name);

        List<CryptoCurrency> AddCryptoCurrency(CryptoCurrency newCoin);

        ///CryptoCurrency UpdateCryptoCurrencyById(int id);

        ///CryptoCurrency UpdateCryptoCurrencyByName(string name);

        ///CryptoCurrency UpdateCryptoCurrency(CryptoCurrency coin);

        ///CryptoCurrency DeleteCryptoCurrency(int id);

        ///CryptoCurrency DeleteCryptoCurrency(string name);

    }
}