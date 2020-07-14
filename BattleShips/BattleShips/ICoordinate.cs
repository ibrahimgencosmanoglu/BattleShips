namespace BattleShips
{
    public interface ICoordinate
    {
        public int X { get; set; }

        public int Y { get; set; }
        
        public bool IsHit { get; set; }
    }
}
