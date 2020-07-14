using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShips
{
    public class Coordinate : ICoordinate
    {
        public int X { get; set; }

        public int Y { get; set; }

        public bool IsHit { get; set; }

        public Coordinate()
        {
            X = 0;
            Y = 0;
            IsHit = false;
        }
    }
}
