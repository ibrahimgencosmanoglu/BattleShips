using System;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace BattleShips
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Coordinate Shoot = new Coordinate();
            Player p1 = new Player("Player 1");
            Player p2 = new Player("Player 2");
            GamePlay.InitialSetup(p1, p2);
            while (!(GamePlay.GameOver(p1, p2))) {
                if (GamePlay.Turn % 2 == 0)
                {
                    GamePlay.TurnPlay(p1, p2);
                }
                else
                {
                    GamePlay.TurnPlay(p2,p1);
                }
            }
        }
    }
}
