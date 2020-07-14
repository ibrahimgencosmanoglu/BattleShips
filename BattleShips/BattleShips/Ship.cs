using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BattleShips
{
    public class Ship
    {
        private Coordinate[] coordinate;
        private int health;
        private string shipName;
        public Ship() 
        {
            coordinate = new Coordinate[2];
            initializeCoordinate(2, this.coordinate);
            this.health = 2;
            setShipName(this.health);
            
    }
        public Ship(int health)
        {
            coordinate = new Coordinate[2];
            initializeCoordinate(health, this.coordinate);
            this.health = health;
            setShipName(this.health);
        }

        private void initializeCoordinate(int number, Coordinate[] c) {
            for (int i = 0; i < number; i++) {
                c[i] = new Coordinate();
            }
        }
        public int getHealth()
        {
            return this.health;
        }
        private void setShipName(int shipSize) 
        {
            this.shipName = "Ship " + shipSize.ToString();
        }

        public void damageRecieved() 
        {
            this.health--;
            if (this.health == 0) {
                Console.WriteLine("Ship has been Destroyed");
            }
        }
        public void setCoordinate(Coordinate head, Coordinate tail) 
        {

            int yHead;
            int xHead;

            if (head.X == tail.X)
            {
                if (head.Y > tail.Y) 
                {
                    yHead = tail.Y;
                }

                else 
                {
                    yHead = head.Y;
                }

                for (int i = 0; i < this.health; i++)
                {
                    this.coordinate[i].X = head.X;
                    this.coordinate[i].Y = yHead;
                    yHead++;
                }
            }
            else 
            {
                if (head.X > tail.X)
                {
                    xHead = tail.X;
                }

                else
                {
                    xHead = head.X;
                }

                for (int i = 0; i < this.health; i++)
                {
                    this.coordinate[i].Y =head.Y;
                    this.coordinate[i].X = xHead;
                    xHead++;
                }
            }
        }

        public void printCoordinate() 
        {
            for (int i = 0; i < this.health; i++) 
            {
                Console.WriteLine(this.coordinate[i].X);
                Console.WriteLine(this.coordinate[i].Y);
            }
        }

        //public void setHead(int xHead , int yHead) {
        //     = xHead;
        //    this.yCoordinateHead = yHead;
        //}

        //public int getXCoordinateHead()
        //{
        //    return this.xCoordinateHead;
        //}

        //public int getXCoordinateTail()
        //{
        //    return this.xCoordinateTail;
        //}

        //public int getYCoordinateHead()
        //{
        //    return this.yCoordinateHead;
        //}

        //public int getYCoordinateTail()
        //{
        //    return this.yCoordinateTail;
        //}

        //public void setTail(int xTail, int yTail)
        //{
        //    this.xCoordinateTail = xTail;
        //    this.yCoordinateTail = yTail;
        //}
    }
}
