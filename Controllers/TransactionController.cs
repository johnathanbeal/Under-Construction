using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using CryptocurrencyTrader.Services;
using CryptocurrencyTrader.Controllers.Services;
using System.Linq;

namespace CryptocurrencyTrader.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private static Transaction Transaction = new Transaction();
        
        private static List<Transaction> Transactions = new List<Transaction>();

        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(_transactionService.GetAllTransactions());
        }

        [HttpPost]
        public async Task<IActionResult> AddTransaction(Transaction transaction)
        {
            return Ok(_transactionService.AddTransaction(transaction));
        }

        /*[HttpPut]
        public async Task<IActionResult> Update()
        {

        }*/

        /*[HttpDelete]
        public async Task<IActionResult> Delete()
        {

        }*/
        [HttpGet("{id}")]
        public IActionResult GetSingleTransaction(int id)
        {
            return Ok(_transactionService.GetTransactionByTransactionNumber(id));
        }
    }
}