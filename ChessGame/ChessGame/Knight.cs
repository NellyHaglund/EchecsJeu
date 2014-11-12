using System;
using System.Collections.Generic;

namespace ChessGame
{
    public class Knight : Piece
    {
        List<Position> KnightMoves = new List<Position>();
        public Knight(Position position, ConsoleColor color)
        {
            this.position = position;
            PieceColour = color;
            PieceValue = 4;
            PieceChar = 'H';   
        }

        //public override List<List<Position>> PossibleMoves(Piece piece)
        //{
        //    KnightMoves.Clear();
        //    KnightMoves.Add(new Position(position.X + 1, position.Y - 2));
        //    KnightMoves.Add(new Position(position.X + 2, position.Y - 1));
        //    KnightMoves.Add(new Position(position.X + 2, position.Y + 1));
        //    KnightMoves.Add(new Position(position.X + 1, position.Y + 2));
        //    KnightMoves.Add(new Position(position.X - 1, position.Y + 2));
        //    KnightMoves.Add(new Position(position.X - 2, position.Y + 1));
        //    KnightMoves.Add(new Position(position.X - 2, position.Y - 1));
        //    KnightMoves.Add(new Position(position.X - 1, position.Y - 2));

        //}
    }
}