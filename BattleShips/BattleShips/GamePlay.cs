using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BattleShips
{
    static class GamePlay 
    {
        public static int Turn = 0;
        public static Coordinate GetCoordinateFromUser(string name) {
            Console.WriteLine("Enter "+ name +" X Coordinate between 1-8");
            string X = Console.ReadLine();
            Console.WriteLine("Enter "+ name +" Y Coordinate between 1-8");
            string Y = Console.ReadLine();
            int XCoordinate = Int32.Parse(X);
            int YCoordinate = Int32.Parse(Y);

            return (new Coordinate(XCoordinate-1, YCoordinate-1));
        }
        public static void InitialSetup(Player p1, Player p2) {
            Console.WriteLine("Player 1 first Ship");
            p1.landShip(GetCoordinateFromUser("Head"), GetCoordinateFromUser("Tail"));
            Console.WriteLine("Player 1 second Ship");
            p1.landShip(GetCoordinateFromUser("Head"), GetCoordinateFromUser("Tail"));
            Console.WriteLine("Player 2 first Ship");
            p2.landShip(GetCoordinateFromUser("Head"), GetCoordinateFromUser("Tail"));
            Console.WriteLine("Player 2 second Ship");
            p2.landShip(GetCoordinateFromUser("Head"), GetCoordinateFromUser("Tail"));
        }

        public static void SetShips(Player p, Coordinate Head, Coordinate Tail) {
            if (CheckLand(p, Head, Tail))
            {
                p.landShip(Head, Tail);
                Console.WriteLine("Ships are landed");
            }
            else {
                Console.WriteLine("Ships cannot landed check for another place");
            }
        }
        public static void TurnPlay(Player p1, Player p2) {
            Console.WriteLine(p1.Name + "'s Turn");
            p1.myMap.showMap();
            Coordinate c = GetCoordinateFromUser("Shoot");
            p1.Attack(p2.Attacked(c),c);
            p1.UpdateShipCounter();
            p2.UpdateShipCounter();
            Turn++;
        }
        public static bool CheckLand(Player p, Coordinate Head, Coordinate Tail) {
            if (Head == Tail)
                return false;
            foreach (var ship in p.ships) {
                if (ship.CheckShipCoordinate(Head, Tail))
                    return false;
            }
            return true;
        }

        public static bool GameOver(Player p1, Player p2) {
            if (p1.ShipCounter == 0)
            {
                Console.WriteLine("Player 2 WINS !!!");
                return true;
            }
            else if (p2.ShipCounter == 0)
            {
                Console.WriteLine("Player 1 WINS !!!");
                return true;
            }
            else
                return false;
        }
    }
}
