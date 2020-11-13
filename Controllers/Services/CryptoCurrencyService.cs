using System;
using System.Collections.Generic;
using System.Linq;
using  CryptocurrencyTrader.Models.Enum;
using System.Security.Cryptography;


namespace CryptocurrencyTrader.Services
{
    public class CryptoCurrencyService : ICryptoCurrencyService
    {


        private static List<CryptoCurrency> cryptoCurrencies = new List<CryptoCurrency> 
        {
            new CryptoCurrency(),
            new CryptoCurrency{
            Id = 2, Name = "Ethereum", Symbol  = "Ξ", Ticker = "ETH", Subunits = Subunit.ether, TimestampingScheme = "PKI", HashFunction = "Ethash", Block_Reward = 3, BlockTimeSeconds = 60 
            },
            new CryptoCurrency{ Id = 3, Name = "AlchemyCoin", Block_Reward = 1000 },
        };

        public List<CryptoCurrency> GetAllCurrencies()
        {
            return cryptoCurrencies;
        }
        
        public List<CryptoCurrency> AddCryptoCurrency(CryptoCurrency coin)
        {
            cryptoCurrencies.Add(coin);
            return cryptoCurrencies;
        }

        public CryptoCurrency GetCryptoCurrencyById(int id)
        {
            return cryptoCurrencies.FirstOrDefault(c => c.Id == id);
        }

        public CryptoCurrency GetCryptoCurrencyByName(string name)
        {
            return cryptoCurrencies.FirstOrDefault(c => c.Name == name);
        }

    }
}