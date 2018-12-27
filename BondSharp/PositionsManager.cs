using System.Collections.Generic;

namespace BondSharp
{
    public class PositionsManager
    {
        public IEnumerable<Position> GetAllPositions() => _positions;

        public void OpenPosition(Bond bond, BondTransaction transaction)
        {
            _positions.Add(new Position(bond, transaction));
        }

        public void ClosePosition()
        {
            
        }

        public void AddTransactionToOpenedPosition()
        {
            
        }

        private List<Position> _positions = new List<Position>();
    }
}