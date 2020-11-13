using System;
using CryptocurrencyTrader.Models.Enum;

public class Transaction
{
    public int TransactionNumber { get; set; } = 0;
    
    public DateTime TransactionDate { get; set; } = DateTime.Now;

    public string Type { get; set; } = TransactionType.Legal.ToString();

    public string Symbol { get; set; } = "^";

    public int CryptoCurrencyId { get; set; } = 3;

    public Decimal TransactionAmount { get; set;} = 100.00m;

    public Decimal CurrencyValue { get; set; } = 100.00m;

}
