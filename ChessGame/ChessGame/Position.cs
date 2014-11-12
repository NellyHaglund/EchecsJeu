using System;
namespace ChessGame
{
    public class Position : Gameboard
    {
        public int X;
        public int Y;
        
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void UpdatePosition(Piece piece, Position position)
        {
            if (position.X >= 0 && position.X < 8 && position.Y >= 0 && position.Y < 8)
            {
                piece.position.X = piece.position.X + position.X;
                piece.position.Y = piece.position.Y + position.Y;
                chessboard[position.X, position.Y] = piece;
            }
            else
            {
                Console.WriteLine("Hoppsan! Error..");
            }
        }
    }
}