using System.Collections.Generic;

namespace BattleShips
{
    public interface IShip
    {
       List<Coordinate> Coordinates { get; set; }
       bool Sinked { get; set; }
    }
}
