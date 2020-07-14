using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BattleShips
{
    class Ship
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

            if (head.getCoordinateX() == tail.getCoordinateX())
            {
                if (head.getCoordinateY() > tail.getCoordinateY()) 
                {
                    yHead = tail.getCoordinateY();
                }

                else 
                {
                    yHead = head.getCoordinateY();
                }

                for (int i = 0; i < this.health; i++)
                {
                    this.coordinate[i].setCoordinateX(head.getCoordinateX());
                    this.coordinate[i].setCoordinateY(yHead);
                    yHead++;
                }
            }
            else 
            {
                if (head.getCoordinateX() > tail.getCoordinateX())
                {
                    xHead = tail.getCoordinateX();
                }

                else
                {
                    xHead = head.getCoordinateX();
                }

                for (int i = 0; i < this.health; i++)
                {
                    this.coordinate[i].setCoordinateY(head.getCoordinateY());
                    this.coordinate[i].setCoordinateX(xHead);
                    xHead++;
                }
            }
        }

        public void printCoordinate() 
        {
            for (int i = 0; i < this.health; i++) 
            {
                Console.WriteLine(this.coordinate[i].getCoordinateX());
                Console.WriteLine(this.coordinate[i].getCoordinateY());
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
