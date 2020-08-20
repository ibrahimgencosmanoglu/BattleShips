using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShips
{
    public class Coordinate : ICoordinate
    {
        public int X { get; set; }

        public int Y { get; set; }

        public bool IsEmpty { get; set; }

        public bool IsHit { get; set; }

        public Coordinate() {
            this.X = 0;
            this.Y = 0;
            this.IsHit = false;
            this.IsEmpty = true;
        }

        public Coordinate(int x, int y) {
            this.X = x;
            this.Y = y;
            this.IsHit = false;
            this.IsEmpty = true;
        }

        public Coordinate(int x, int y, bool f) {
            this.X = x;
            this.Y = y;
            this.IsHit = false;
            this.IsEmpty = f;
        }

    }
}
