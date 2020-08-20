using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Transactions;

namespace BattleShips
{
    public class Ship : IShip
    {
        public int Health { get; set; }
        public List<Coordinate> Coordinates { get;set; }
        public bool Sinked { get; set; }

        public Ship() {
            Coordinates = new List<Coordinate>();
            this.Sinked = false;
        }

        public void SetHealth() {
            this.Health = Coordinates.Count;
        }

        public void UpdateHealth() {
            int health = 0;
            foreach (var coordinate in Coordinates) {
                if (!coordinate.IsHit)
                    health++;
            }
            if (health == 0)
                this.Sinked = true;
            this.Health = health;
        }
        public void SetShip(Coordinate Head , Coordinate Tail) {

            Coordinate Temp = new Coordinate();
            int loopX;
            int loopY;
            if (Head.X > Tail.X || Head.Y > Tail.Y) {
                Temp = Head;
                Head = Tail;
                Tail = Temp;
            }
            loopX = Tail.X - Head.X;
            loopY = Tail.Y - Head.Y;
            Temp.X = Head.X;
            Temp.Y = Head.Y;
            if (Head.X == Tail.X)
            {
                for (int i = 0; i <= loopY; i++) { /// for(int i = 0; i<=Tail.Y-Head.Y; i++) yapinca Head.Y kendini arttiriyor sebebi ? temp e Head i atiyorum ondan mi?
                    this.Coordinates.Add(new Coordinate(Temp.X, Temp.Y, false));
                    Temp.Y++;
                }
            }
            else 
            {
                for (int i = 0; i <= loopX; i++) /// for(int i = 0; i<=Tail.X-Head.X; i++) yapinca Head.X kendini arttiriyor sebebi ?
                {
                    this.Coordinates.Add(new Coordinate(Temp.X, Temp.Y, false));
                    Temp.X++;
                }
            }
        }

        public bool CheckShipCoordinate(Coordinate Head, Coordinate Tail)
        {
            Coordinate Temp = new Coordinate();
            int LoopY;
            int LoopX;
            if (Head.X > Tail.X || Head.Y > Tail.Y)
            {
                Temp = Head;
                Head = Tail;
                Tail = Temp;
            }
            LoopY = Tail.Y - Head.Y;
            LoopX = Tail.X - Head.X;
            Temp = Head;
            if (Head.X == Tail.X)
            {
                foreach (Coordinate coordinates in Coordinates)
                {
                    for (int i = 0; i <= LoopY; i++)
                    {
                        if (coordinates.X == Temp.X && coordinates.Y == Temp.Y)
                            return true;
                        Temp.Y++;
                    }
                }
            }
            else {
                foreach (Coordinate coordinates in Coordinates) {
                    for (int i = 0; i <= LoopX; i++) {
                        if (coordinates.X == Temp.X && coordinates.Y == Temp.Y)
                            return true;
                        Temp.X++;
                    }
                    Temp = Head;
                }
            }
            return false;
        }
    }
}