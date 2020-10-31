using CryptocurrencyTrader.Models.Enum;

namespace CryptocurrencyTrader.Models
{
    public class IssuanceSchedule
    {
        public bool Decentralized { get; set; }

        public string Description { get; set; }

        public long HalfLife { get; set; }

        public HalfLife HalfLifeUnit { get; set; }
    }
}