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
            c1.setCoordinateX(3);
            c1.setCoordinateY(4);
            c2.setCoordinateX(3);
            c2.setCoordinateY(3);
            Ship ship1 = new Ship();
            m1.printMap();
            m1.setShip(c1.getCoordinateX(), c1.getCoordinateY(), c2.getCoordinateX(), c2.getCoordinateY(), 2);
            ship1.setCoordinate(c1,c2);
            ship1.printCoordinate();
            m1.printMap();
        }
    }
}
