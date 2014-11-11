using System;
using System.Collections.Generic;

namespace ChessGame
{
    public class Bishop : Piece
    {
        List<Position> BishopMoves = new List<Position>();
        List<Position> DownDown = new List<Position>();
        List<Position> UpUp = new List<Position>();
        List<Position> RightRight = new List<Position>();
        List<Position> LeftLeft = new List<Position>();
        List<Position> DownRight = new List<Position>();
        List<Position> DownLeft = new List<Position>();
        List<Position> UpLeft = new List<Position>();
        List<Position> UpRight = new List<Position>();
        public Bishop(Position position, ConsoleColor color)
        {
            this.position = position;
            PieceColour = color;
            PieceValue = 3;
            PieceChar = 'B';   
        }

        public override void PossibleMoves()
        {
            BishopMoves.Clear();
            // Diagonalt nedåt mot höger
            DownRight.Add(new Position(position.X + 1, position.Y + 1));
            DownRight.Add(new Position(position.X + 2, position.Y + 2));
            DownRight.Add(new Position(position.X + 3, position.Y + 3));
            DownRight.Add(new Position(position.X + 4, position.Y + 4));
            DownRight.Add(new Position(position.X + 5, position.Y + 5));
            DownRight.Add(new Position(position.X + 6, position.Y + 6));
            DownRight.Add(new Position(position.X + 7, position.Y + 7));
            // Diagonalt nedåt mot vänster
            DownLeft.Add(new Position(position.X + 1, position.Y - 1));
            DownLeft.Add(new Position(position.X + 2, position.Y - 2));
            DownLeft.Add(new Position(position.X + 3, position.Y - 3));
            DownLeft.Add(new Position(position.X + 4, position.Y - 4));
            DownLeft.Add(new Position(position.X + 5, position.Y - 5));
            DownLeft.Add(new Position(position.X + 6, position.Y - 6));
            DownLeft.Add(new Position(position.X + 7, position.Y - 7));
            // Diagonalt uppåt mot vänster
            UpLeft.Add(new Position(position.X - 1, position.Y + 1));
            UpLeft.Add(new Position(position.X - 2, position.Y + 2));
            UpLeft.Add(new Position(position.X - 3, position.Y + 3));
            UpLeft.Add(new Position(position.X - 4, position.Y + 4));
            UpLeft.Add(new Position(position.X - 5, position.Y + 5));
            UpLeft.Add(new Position(position.X - 6, position.Y + 6));
            UpLeft.Add(new Position(position.X - 7, position.Y + 7));
            // Diagonalt uppåt mot höger
            UpLeft.Add(new Position(position.X - 1, position.Y - 1));
            UpLeft.Add(new Position(position.X - 2, position.Y - 2));
            UpLeft.Add(new Position(position.X - 3, position.Y - 3));
            UpLeft.Add(new Position(position.X - 4, position.Y - 4));
            UpLeft.Add(new Position(position.X - 5, position.Y - 5));
            UpLeft.Add(new Position(position.X - 6, position.Y - 6));
            UpLeft.Add(new Position(position.X - 7, position.Y - 7));



        }
    }
}