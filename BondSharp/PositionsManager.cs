using System.Collections.Generic;

namespace BondSharp
{
    public class PositionsManager
    {
        IEnumerable<Position> GetAllPositions() => _positions;

        void OpenPosition()
        {
            
        }

        void ClosePosition()
        {
            
        }

        void AddTransactionToOpenedPosition()
        {
            
        }

        private List<Position> _positions = new List<Position>();
    }
}