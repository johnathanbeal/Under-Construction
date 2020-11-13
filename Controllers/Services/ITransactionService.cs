using System.Collections.Generic;

namespace CryptocurrencyTrader.Controllers.Services
{
    public interface ITransactionService
    {
        List<Transaction> GetAllTransactions();

        Transaction GetTransactionByTransactionNumber(int id);

        List<Transaction> AddTransaction(Transaction transaction);

        void UpdateTransaction(Transaction transaction);

        void DeleteTransaction(int id);

    }
}
