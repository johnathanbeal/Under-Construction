using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptocurrencyTrader.Models.DataAccess
{
    public interface ITransactionDataAccessProvider
    {
        void AddTransaction(Transaction transaction);
        void UpdateTransaction(Transaction transaction);

        void DeleteTransaction(long id);

        Task<Transaction> GetTransactionSingleRecord(long id);

        Task<List<Transaction>> GetTransactionRecords();
    }
}