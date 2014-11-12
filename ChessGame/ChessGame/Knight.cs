using System;
using System.Collections.Generic;

namespace ChessGame
{
    public class Knight : Piece
    {
        List<List<Position>> KnightMoves;
        public Knight(Position position, ConsoleColor color)
        {
            this.position = position;
            PieceColour = color;
            PieceValue = 4;
            PieceChar = 'H';
            KnightMoves = new List<List<Position>>()
            {
                new List<Position>()
                {
                    new Position(+ 1, - 2)
                },
                new List<Position>()
                {
                    new Position(+ 2, - 1)
                },
                new List<Position>()
                {
                    new Position(+ 2, + 1)
                },
                new List<Position>()
                {
                    new Position(+ 1, + 2)
                },
                new List<Position>()
                {
                    new Position(- 1, + 2)
                },
                new List<Position>()
                {
                    new Position(- 2, + 1)
                },
                new List<Position>()
                {
                    new Position(- 2, - 1)
                },
                new List<Position>()
                {
                    new Position(- 1, - 2)
                },

            };
        }

    }
}