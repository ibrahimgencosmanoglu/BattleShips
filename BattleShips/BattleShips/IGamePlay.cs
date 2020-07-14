using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShips
{
    public interface IGamePlay
    {
        public IPlayer Player1 { get; set; }
        
        public IPlayer Player2 { get; set; }

        public void InitialSetup();

        public void DrawMaps();
        
        public void EndTurn();

        public bool GameOver { get; set; }
    }
}
