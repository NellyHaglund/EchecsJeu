using System;
using System.Collections.Generic;

namespace ChessGame
{
    public class King : Piece
    {
        List<Position> kingMoves = new List<Position>();


        public King(Position position, ConsoleColor color)
        {
            this.position = position;
            PieceColour = color;
            PieceValue = 11;
            PieceChar = 'K';   
        }

        public override void PossibleMoves()
        {
            kingMoves.Clear();
            kingMoves.Add(new Position(position.X + 1, position.Y));
            kingMoves.Add(new Position(position.X + 1, position.Y - 1));
            kingMoves.Add(new Position(position.X + 1, position.Y + 1));
            kingMoves.Add(new Position(position.X, position.Y - 1));
            kingMoves.Add(new Position(position.X, position.Y + 1));
            kingMoves.Add(new Position(position.X - 1, position.Y - 1));
            kingMoves.Add(new Position(position.X - 1, position.Y + 1));
            kingMoves.Add(new Position(position.X - 1, position.Y));

        }
    }
}