using System;


public class Transaction
{
    public DateTime TransactionDate { get; set; }

    public TransactionType Type { get; set; }

    public string Symbol { get; set; }

    public string CryptoCurrency { get; set;}

    public Decimal TransactionAmount { get; set;}

    public Decimal CurrencyValue { get; set; }

}