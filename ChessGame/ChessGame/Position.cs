using System;
namespace ChessGame
{
    public class Position
    {
        public int X;
        public int Y;

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return " X: " + X.ToString() + " Y: " + Y.ToString();
        }




    }
}