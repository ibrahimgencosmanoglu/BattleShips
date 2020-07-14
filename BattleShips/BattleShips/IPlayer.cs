using System.Collections.Generic;

namespace BattleShips
{
    public interface IPlayer
    {
        public List<IShip> Ships { get; set; }
        
        public List<ICoordinate> Map { get; set; }
        
        public bool Attack(ICoordinate coordinate);

        public bool Attacked(ICoordinate coordinate);
    }
}
