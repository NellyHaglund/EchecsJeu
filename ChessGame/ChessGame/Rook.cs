using System;
using System.Collections.Generic;

namespace ChessGame
{
    public class Rook : Piece
    {
        List<Position> RookMoves = new List<Position>();
        List<Position> DownDown = new List<Position>();
        List<Position> UpUp = new List<Position>();
        List<Position> RightRight = new List<Position>();
        List<Position> LeftLeft = new List<Position>();


        public Rook(Position position, ConsoleColor color)
        {
            this.position = position;
            PieceColour = color;
            PieceValue = 5;
            PieceChar = 'T';   
        }

        //public override List<List<Position>> PossibleMoves(Piece piece)
        //{
        //    RookMoves.Clear();
        //    // Rör sig lodrätt nedåt
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


        //}
    }
}