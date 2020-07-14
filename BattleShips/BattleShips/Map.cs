using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace BattleShips
{
    public class Map
    {
        private string mapName;
        private char[,] myMap;
        string mapLine;
        string empty;

        public Map() 
        {
            this.myMap = new char[8, 8];
            initializeMap();
        }

        public void printMap() 
        {
            Console.WriteLine("  1 2 3 4 5 6 7 8");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++) 
                {
                    if (j == 0)
                    {
                        this.mapLine += (i + 1).ToString();
                        this.mapLine += ' ';
                    }
                    this.mapLine += this.myMap[i, j];
                    this.mapLine += ' ';
                }
                Console.WriteLine(mapLine);
                mapLine = empty;
                //this.mapLine.Remove(0);
            }
        }

        public void setName(string name) 
        {
            this.mapName = name;
        }

        public void setShip(int xHead, int yHead, int xTail, int yTail, int shipLength) 
        {

            int xHeadTemp;
            int yHeadTemp;

            if (xHead >= xTail)
            {
                xHeadTemp = xTail;
            }
            else 
            { 
                xHeadTemp = xHead;
            }

            if (yHead <= yTail)
                yHeadTemp = yHead;
            else
                yHeadTemp = yTail;

            if (xHead == xTail)
            {
                for (int i = 0; i < shipLength; i++) 
                {
                    this.myMap[xHeadTemp - 1, yHeadTemp - 1] = 'S';
                    yHeadTemp++;
                }
            }
            else 
            {

                for (int i = 0; i < shipLength; i++)
                {
                    this.myMap[xHeadTemp - 1, yHeadTemp - 1] = 'S';
                    xHeadTemp++;
                }
            }
        }

        public void setMap(Coordinate c, char mark) 
        {
            myMap[c.X - 1, c.Y - 1] = mark;
        }
        public bool checkShip(int x, int y) 
        {
            if (this.myMap[x - 1, y - 1] == 'S')
                return true;
            else
                return false;
        }
        private void updateMap(int xHead, int yHead, int xTail, int yTail) 
        {
            setShip(xHead, yHead, xTail, yTail, 2);
        }
        private void initializeMap() 
        {
            for (int i = 0; i < 8; i++) 
            {
                for (int j = 0; j < 8; j++) 
                {
                    this.myMap[i, j] = 'W';
                }
            }
        }
    }
}
