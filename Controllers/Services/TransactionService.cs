using System;
using System.Collections.Generic;
using System.Linq;
using CryptocurrencyTrader.Models.Enum;
using System.Security.Cryptography;

namespace CryptocurrencyTrader.Services
{
    public class TransactionService
    {    

        private static List<Transaction> transactions = new List<Transaction> 
        {
            new Transaction{ TransactionNumber = 1, TransactionDate = new DateTime(2020,02,29), Symbol = "DASH", CryptoCurrencyId = 1, TransactionAmount = 99.99m, CurrencyValue =  1.11m },
            new Transaction{ TransactionNumber = 2, TransactionDate = new DateTime(04/01/2020), Symbol = "LTC", CryptoCurrencyId = 2, TransactionAmount = 99.99m, CurrencyValue =  1.11m },
            new Transaction{ TransactionNumber = 3, TransactionDate = new DateTime(08/18/2020), Symbol = "XBT", CryptoCurrencyId = 3, TransactionAmount = 99.99m, CurrencyValue =  1.11m },
            new Transaction{ TransactionNumber = 4, TransactionDate = new DateTime(11/05/2020), Symbol = "XMR", CryptoCurrencyId = 4, TransactionAmount = 99.99m, CurrencyValue =  1.11m },
            new Transaction{ TransactionNumber = 5, TransactionDate = DateTime.Now, Symbol = "XRP", CryptoCurrencyId = 5, TransactionAmount = 1.00m, CurrencyValue = 1.00m },
        };

        public List<Transaction> GetAllTransactions()
        {
            return transactions;
        }

        public Transaction GetTransactionByTransactionNumber(int number)
        {
            return transactions.Where(t => t.TransactionNumber == number).FirstOrDefault();
        }

        public List<Transaction> AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
            return transactions;
        }

        public void UpdateTransaction(Transaction updatedTransaction)
        {
            if (updatedTransaction != null)
            {
                transactions.Single(t => t.TransactionNumber == updatedTransaction.TransactionNumber).TransactionDate = updatedTransaction.TransactionDate;
                ///transactions.Single(t => t.TransactionNumber == updatedTransaction.TransactionNumber).TransactionType = updatedTransaction.TransactionType;            
                transactions.Single(t => t.TransactionNumber == updatedTransaction.TransactionNumber).Symbol = updatedTransaction.Symbol;
                transactions.Single(t => t.TransactionNumber == updatedTransaction.TransactionNumber).CryptoCurrencyId = updatedTransaction.CryptoCurrencyId;
                transactions.Single(t => t.TransactionNumber == updatedTransaction.TransactionNumber).TransactionAmount = updatedTransaction.TransactionAmount;
                transactions.Single(t => t.TransactionNumber == updatedTransaction.TransactionNumber).CurrencyValue = updatedTransaction.CurrencyValue;
            }
        }

        public void DeleteTransaction(int id)
        {
            transactions.Where(t => t.TransactionNumber != id).ToList();
        }
    }
}

public enum TransactionType
    {
        Speculation,
        Darknet,

        Laundering,

        Ransomware,

        Evasion,

        Theft,

        Hacking,

        Legal
    }