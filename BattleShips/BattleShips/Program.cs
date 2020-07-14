using System;

namespace BattleShips
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Map m1 = new Map();
            Coordinate c1 = new Coordinate();
            Coordinate c2 = new Coordinate();
            c1.X = 3;
            c1.Y = 4;
            c2.X = 3;
            c2.Y = 3;
            Ship ship1 = new Ship();
            m1.printMap();
            m1.setShip(c1.X, c1.Y, c2.X, c2.Y, 2);
            ship1.setCoordinate(c1,c2);
            ship1.printCoordinate();
            m1.printMap();
        }
    }
}
