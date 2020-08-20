using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace BattleShips
{
    class Player
    {
        public int ShipCounter { get; set; }
        public List<Ship> ships { get; set; }
        public Map myMap { get; set; }
        public string Name { get; set; }
        public Player(string name) {
            this.Name = name;
            myMap = new Map();
            ships = new List<Ship>();
        }

        public void SetShipCounter() {
            this.ShipCounter = ships.Count;
        }
        public void UpdateShipCounter() {
            int shipcounter = 0;
            foreach (var ship in ships) {
                if (!(ship.Sinked))
                    shipcounter++;
            }
            this.ShipCounter = shipcounter;
        }
        public void landShip(Coordinate Head,Coordinate Tail) {
            Ship s1 = new Ship();
            s1.SetShip(Head, Tail);
            s1.SetHealth();
            ships.Add(s1);
            UpdateShipCounter();
        }
        public bool findShip(Coordinate coordinate)
        {
            foreach (var ship in ships) {
                if(ship.Coordinates.Exists(c => c.X == coordinate.X && c.Y == coordinate.Y))
                    return true;
            }
                return false;
        }
        public void Attack(bool check,Coordinate coordinate) {
            if (check)
            {
                Console.WriteLine(" Enemy Ship Has Been Hit ");
                foreach (var c in this.myMap.GameMap)
                {
                    if (c.X == coordinate.X && c.Y == coordinate.Y)
                    {
                        c.IsHit = true;
                        c.IsEmpty = false;
                    }
                }
            }
            else
            {
                Console.WriteLine(" You Have Missed Your Enemy ");
                foreach (var c in this.myMap.GameMap)
                {
                    if (c.X == coordinate.X && c.Y == coordinate.Y)
                    {
                        c.IsHit = true;
                    }
                }
            }
        }

        public bool Attacked(Coordinate TargetCoordinate) {
            Ship S = new Ship();
            if (findShip(TargetCoordinate))
            {
                S = this.ships.Find(x => x.Coordinates.Exists(y => y.X == TargetCoordinate.X && y.Y == TargetCoordinate.Y));
                foreach (var coordinates in S.Coordinates) {
                    if (coordinates.X == TargetCoordinate.X && coordinates.Y == TargetCoordinate.Y)
                        coordinates.IsHit = true;
                }
                S.UpdateHealth();
                return true;
            }
            else
                return false;
        }
    }
}
