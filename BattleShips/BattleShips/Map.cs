using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Net.Http.Headers;
using System.Text;

namespace BattleShips
{
    public class Map
    {
        public List<Coordinate> GameMap { get; set; }

        public Map() {
            GameMap = new List<Coordinate>();
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    this.GameMap.Add(new Coordinate(i, j));
                }
            }
        }

        public void showMap() {
            string Line = "";
            int Counter = 0;
            foreach (var coordinates in GameMap) {
                if (coordinates.IsEmpty && !(coordinates.IsHit))
                    Line += "~ ";
                else if (coordinates.IsEmpty && coordinates.IsHit)
                    Line += "X ";
                else if (!(coordinates.IsEmpty) && coordinates.IsHit)
                    Line += "O ";
                Counter++;
                if (Counter % 8 == 0) {
                    Console.WriteLine(Line);
                    Line = "";
                }
            }
        }
    }
}