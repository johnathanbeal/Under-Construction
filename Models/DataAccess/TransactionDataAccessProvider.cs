using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptocurrencyTrader.Models.DataAccess
{
    public class TransactionDataAccessProvider : ITransactionDataAccessProvider
    {
        private readonly PostgresRdsDbContext _context;

        public TransactionDataAccessProvider(PostgresRdsDbContext context)
        {
            _context = context;
        }

        public void AddTransaction(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }
        public void UpdateTransaction(Transaction transaction)
        {
            _context.Transactions.Update(transaction);
            _context.SaveChanges();
        }

        public void DeleteTransaction(long transactionNumber)
        {
            var entity = _context.Transactions.FirstOrDefault(t => t.TransactionNumber == transactionNumber);
            _context.Transactions.Remove(entity);
            _context.SaveChanges();
        }

        public async Task<Transaction> GetTransactionSingleRecord(long id)
        {
            return _context.Transactions.FirstOrDefault(t => t.TransactionNumber == id);
        }

        public async Task<List<Transaction>> GetTransactionRecords()
        {
            return _context.Transactions.ToList();
        }
    }
}