using System;
using System.Collections.Generic;

namespace ChessGame
{
    public class Queen : Piece
    {
         List<Position> DownDown = new List<Position>();
         List<Position> UpUp = new List<Position>();
         List<Position> RightRight = new List<Position>();
         List<Position> LeftLeft = new List<Position>();
         List<Position> DownRight = new List<Position>();
         List<Position> DownLeft = new List<Position>();
         List<Position> UpLeft = new List<Position>();
         List<Position> UpRight = new List<Position>();
        public Queen(Position position, ConsoleColor color)
        {
            this.position = position;
            PieceColour = color;
            PieceValue = 9;
            PieceChar = 'D';   
        }

        //public override List<List<Position>> PossibleMoves(Piece piece)
        //{

        //    DownDown.Add(new Position(position.X + 1, position.Y));
        //    DownDown.Add(new Position(position.X + 2, position.Y));
        //    DownDown.Add(new Position(position.X + 3, position.Y));
        //    DownDown.Add(new Position(position.X + 4, position.Y));
        //    DownDown.Add(new Position(position.X + 5, position.Y));
        //    DownDown.Add(new Position(position.X + 6, position.Y));
        //    DownDown.Add(new Position(position.X + 7, position.Y));           
        //    // Rör sig lodrätt uppåt
        //    UpUp.Add(new Position(position.X - 1, position.Y));
        //    UpUp.Add(new Position(position.X - 2, position.Y));
        //    UpUp.Add(new Position(position.X - 3, position.Y));
        //    UpUp.Add(new Position(position.X - 4, position.Y));
        //    UpUp.Add(new Position(position.X - 5, position.Y));
        //    UpUp.Add(new Position(position.X - 6, position.Y));
        //    UpUp.Add(new Position(position.X - 7, position.Y));
        //    // Rör sig vågrätt höger
        //    RightRight.Add(new Position(position.X, position.Y + 1));
        //    RightRight.Add(new Position(position.X, position.Y + 2));
        //    RightRight.Add(new Position(position.X, position.Y + 3));
        //    RightRight.Add(new Position(position.X, position.Y + 4));
        //    RightRight.Add(new Position(position.X, position.Y + 5));
        //    RightRight.Add(new Position(position.X, position.Y + 6));
        //    RightRight.Add(new Position(position.X, position.Y + 7));
        //    // Rör sig vågrätt vänster
        //    LeftLeft.Add(new Position(position.X, position.Y - 1));
        //    LeftLeft.Add(new Position(position.X, position.Y - 2));
        //    LeftLeft.Add(new Position(position.X, position.Y - 3));
        //    LeftLeft.Add(new Position(position.X, position.Y - 4));
        //    LeftLeft.Add(new Position(position.X, position.Y - 5));
        //    LeftLeft.Add(new Position(position.X, position.Y - 6));
        //    LeftLeft.Add(new Position(position.X, position.Y - 7));
        //    // Diagonalt nedåt mot höger
        //    DownRight.Add(new Position(position.X + 1, position.Y + 1));
        //    DownRight.Add(new Position(position.X + 2, position.Y + 2));
        //    DownRight.Add(new Position(position.X + 3, position.Y + 3));
        //    DownRight.Add(new Position(position.X + 4, position.Y + 4));
        //    DownRight.Add(new Position(position.X + 5, position.Y + 5));
        //    DownRight.Add(new Position(position.X + 6, position.Y + 6));
        //    DownRight.Add(new Position(position.X + 7, position.Y + 7));
        //    // Diagonalt nedåt mot vänster
        //    DownLeft.Add(new Position(position.X + 1, position.Y - 1));
        //    DownLeft.Add(new Position(position.X + 2, position.Y - 2));
        //    DownLeft.Add(new Position(position.X + 3, position.Y - 3));
        //    DownLeft.Add(new Position(position.X + 4, position.Y - 4));
        //    DownLeft.Add(new Position(position.X + 5, position.Y - 5));
        //    DownLeft.Add(new Position(position.X + 6, position.Y - 6));
        //    DownLeft.Add(new Position(position.X + 7, position.Y - 7));
        //    // Diagonalt uppåt mot vänster
        //    UpLeft.Add(new Position(position.X - 1, position.Y + 1));
        //    UpLeft.Add(new Position(position.X - 2, position.Y + 2));
        //    UpLeft.Add(new Position(position.X - 3, position.Y + 3));
        //    UpLeft.Add(new Position(position.X - 4, position.Y + 4));
        //    UpLeft.Add(new Position(position.X - 5, position.Y + 5));
        //    UpLeft.Add(new Position(position.X - 6, position.Y + 6));
        //    UpLeft.Add(new Position(position.X - 7, position.Y + 7));
        //    // Diagonalt uppåt mot höger
        //    UpRight.Add(new Position(position.X - 1, position.Y - 1));
        //    UpRight.Add(new Position(position.X - 2, position.Y - 2));
        //    UpRight.Add(new Position(position.X - 3, position.Y - 3));
        //    UpRight.Add(new Position(position.X - 4, position.Y - 4));
        //    UpRight.Add(new Position(position.X - 5, position.Y - 5));
        //    UpRight.Add(new Position(position.X - 6, position.Y - 6));
        //    UpRight.Add(new Position(position.X - 7, position.Y - 7));

        //    foreach (var item in DownLeft)
        //    {
        //        Console.WriteLine(item.X + "" + item.Y);
        //        Console.ReadKey();
        //    }
        //}
    }
}