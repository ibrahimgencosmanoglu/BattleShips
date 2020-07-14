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

        public void Torpedo(Coordinate target, Player enemy) {
            if (enemy.myMap.checkShip(target.X, target.Y)) {
                Console.WriteLine("You Hit The Target");
                this.targetMap.setMap(target, 'X');
                enemy.myMap.setMap(target, 'X');
                //if()
            }
        }

        private void findShip()
        {
            Ship shipTemp = new Ship();

        }
    }
}
