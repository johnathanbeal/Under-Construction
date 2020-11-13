using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using CryptocurrencyTrader.Services;
using  CryptocurrencyTrader.Models.Enum;
using System;
using System.Security.Cryptography;

namespace CryptocurrencyTrader.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CurrencyController : ControllerBase
    {
        private readonly ICryptoCurrencyService _coinService;
        public CurrencyController(ICryptoCurrencyService coinService)
        {
            this._coinService = coinService;

        }

        /* private static CryptoCurrency Currency = new CryptoCurrency();
        private static List<CryptoCurrency> Currencies = new List<CryptoCurrency>()
        {
            new CryptoCurrency(),
            new CryptoCurrency{
            Id = 2, Name = "Ethereum", Plural = "Etheria", Symbol  = "Ξ", Ticker = "ETH", Subunits = Subunit.ether, Creator = "Vitalik Buterin", Implementation  = "[multiple]",
            InitialReleaseDate = new DateTime(2020, 02, 29), InitialReleaseVersion = new Version(0,0,1), LatestReleaseDate = new DateTime(2020, 02, 29), LatestReleaseVersion = new Version(0,0,1), 
            Status = DevelopmentStatus.Active, Website = new Uri("https://www.ethereum.org"), LedgerStart = new DateTime(2020,2,28), TimestampingScheme = "PKI", HashFunction  = null,
            Block_Reward = 3, BlockTimeMinutes = 1, BlockExplorer = new Uri("https://www.beal-planet.com/en/history/"), CirculatingSupply = 1, CirculatingSupplyDate = new DateTime(2020, 02, 29),
            SupplyLimit = 1 },
           
            new CryptoCurrency{ Id = 3, Name = "AlchemyCoin", Block_Reward = 1000 },

        }; */

        [HttpGet("GetAll")]
        public IActionResult Get()
        {            
            return Ok(_coinService.GetAllCurrencies());
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(_coinService.GetCryptoCurrencyById(id));
        }

        [HttpGet("{name}")]
        public IActionResult GetSingle(string name)
        {
            return Ok(_coinService.GetCryptoCurrencyByName(name));
        }

        [HttpPost("{id}")]
        public IActionResult AddCurrency(CryptoCurrency coin)
        {
            return Ok(_coinService.AddCryptoCurrency(coin));
        }
/* 
        [HttpPut("{id}")]
        public IActionResult UpdateCurrency(int id)
        {
            var coin = _coinService.GetCryptoCurrencyById(id);
            return Ok(_coinService.UpdateCurrency(coin));
        } */
/* 
        [HttpPut("{name}")]
        public IActionResult UpdateCurrency(string name)
        {
            var coin = GetCryptoCurrencyByName(name);
            return Ok(_coinService.UpdateCurrency(coin));
        } */
    }
}