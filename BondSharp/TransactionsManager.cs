using System.Collections.Generic;

namespace BondSharp
{
    public class TransactionsManager
    {
        public IEnumerable<Transaction> GetAllTransactions() => _transactions;

        public void AddTransaction(Transaction transaction) => _transactions.Add(transaction);
        
        private readonly List<Transaction> _transactions = new List<Transaction>();
    }
}