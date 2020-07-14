using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShips
{
    class Coordinate
    {
        private int x;
        private int y;

        public Coordinate() {
            this.x = 0;
            this.y = 0;
        }
        public void setCoordinateX(int x) 
        {
            this.x = x;
        }

        public void setCoordinateY(int y)
        {
            this.y = y;
        }

        public int getCoordinateX() 
        {
            return this.x;
        }

        public int getCoordinateY()
        {
            return this.y;
        }
    }
}
