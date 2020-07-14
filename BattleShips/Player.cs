using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShips
{
    class Player
    {
        private string name;
        private Map targetMap;
        private Map myMap;
        private Ship shipW2;
        private Ship shipW3;

        public Player() 
        {
            targetMap = new Map();
            targetMap.setName("Target Map");
            myMap = new Map();
            myMap.setName("My Map");
            shipW2 = new Ship();
            shipW3 = new Ship(3);
        }

        public void Torpedo(int x, int y, Player enemy) {
            if (enemy.myMap.checkShip(x,y)) {
                Console.WriteLine("You Hit The Target");
                this.targetMap.setMap(x, y, 'X');
                enemy.myMap.setMap(x, y, 'X');
                //if()
            }
        }
    }
}
