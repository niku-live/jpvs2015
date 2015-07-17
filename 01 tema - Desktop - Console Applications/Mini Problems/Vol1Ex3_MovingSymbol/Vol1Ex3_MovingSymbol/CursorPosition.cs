namespace Vol1Ex3_MovingSymbol
{
    public class CursorPosition
    {
        public const int MaxX = 79;
        public const int MaxY = 25;

        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public CursorPosition(int x, int y)
        {            
            PositionX = x;
            PositionY = y;
        }

        public void MoveBy(int diffX, int diffY)
        {
           if ((PositionX + diffX >= 0) && (PositionX + diffX <= MaxX))
           {
               PositionX += diffX;
           }
           if ((PositionY + diffY >= 0) && (PositionY + diffY <= MaxY))
           {
               PositionY += diffY;
           }
        }
    }
}
