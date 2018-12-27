using System;
using System.Linq;
using Xunit;

namespace BondSharp.Tests
{
    public class PositionsManagerTests
    {
        [Fact]
        public void OpenPositionAddsPositionToList()
        {
            var manager = new PositionsManager();
            var bond = new Bond();
            var transaction = new BondTransaction(DateTime.Now, bond.Ticker, 42);
            manager.OpenPosition(bond, transaction);
            
            var positions = manager.GetAllPositions().ToArray();
            Assert.Equal(1, positions.Length);
            Assert.Equal(1, positions[0].Transactions.Count);
            Assert.Equal(42, positions[0].Transactions[0].MoneyAmount);
        }
    }
}