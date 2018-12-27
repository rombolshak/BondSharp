using System.Collections.Generic;

namespace BondSharp
{
    public class Position
    {
        public Position(Bond bond, BondTransaction firstTransaction)
        {
            Bond = bond;
            Transactions.Add(firstTransaction);
        }

        public Bond Bond { get; }

        public List<Transaction> Transactions { get; } = new List<Transaction>();
    }
}