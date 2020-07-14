using System.Collections.Generic;

namespace BattleShips
{
    public interface IShip
    {
        public List<ICoordinate> Coordinates { get; set; }
        public bool Sinked { get; set; }
    }
}
