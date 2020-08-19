using System;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace BattleShips
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Coordinate c1 = new Coordinate(3, 3);
            //p1.myMap.showMap();
            Player p2 = new Player();
            Coordinate Head3 = new Coordinate(0, 0);
            Coordinate Tail3 = new Coordinate(0, 2);
            Coordinate Head2 = new Coordinate(0, 5);
            Coordinate Tail2 = new Coordinate(1, 5);
            p1.landShip(Head2, Tail2);
            p2.landShip(Head3, Tail3);
            Console.WriteLine("Ships");
            //foreach (Ship Ships in p1.ships) {
            //    Ships.ShowShipCoordinate();
            //    Console.WriteLine("------");
            //}
            //Console.WriteLine(p1.findShip(Tail2));
            p1.Attack(p2.Attacked(Tail3),Tail3);
            p1.Attack(p2.Attacked(c1), c1);
            p1.myMap.showMap();
            Console.WriteLine("----------");
            foreach(var ships in p2.ships)
                Console.WriteLine(ships.Health);
        }
    }
}
