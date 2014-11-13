using System;
using System.Collections.Generic;

namespace ChessGame
{
    public class Queen : Piece
    {
        

        public Queen(Position position, ConsoleColor color)
        {
            this.position = position;
            PieceColour = color;
            PieceValue = 9;
            PieceChar = 'D';
            PossibleMovesThisTime = new List<Position>();
            AllPossibleMovesList = new List<List<Position>>()
            {
                new List<Position>()
                {
                    new Position(+ 1, 0),
                    new Position(+ 2, 0),
                    new Position(+ 3, 0),
                    new Position(+ 4, 0),
                    new Position(+ 5, 0),
                    new Position(+ 6, 0),
                    new Position(+ 7, 0),
                },
                new List<Position>()
                {
                    new Position(- 1, 0),
                    new Position(- 2, 0),
                    new Position(- 3, 0),
                    new Position(- 4, 0),
                    new Position(- 5, 0),
                    new Position(- 6, 0),
                    new Position(- 7, 0),
                },
                new List<Position>()
                {
                    new Position(0, + 1),
                    new Position(0, + 2),
                    new Position(0, + 3),
                    new Position(0, + 4),
                    new Position(0, + 5),
                    new Position(0, + 6),
                    new Position(0, + 7),
                },
                new List<Position>()
                {
                    new Position(0, - 1),
                    new Position(0, - 2),
                    new Position(0, - 3),
                    new Position(0, - 4),
                    new Position(0, - 5),
                    new Position(0, - 6),
                    new Position(0, - 7),
                },
                new List<Position>()
                {
                    new Position(+ 1, + 1),
                    new Position(+ 2, + 2),
                    new Position(+ 3, + 3),
                    new Position(+ 4, + 4),
                    new Position(+ 5, + 5),
                    new Position(+ 6, + 6),
                    new Position(+ 7, + 7),
                },
                new List<Position>()
                {
                    new Position(+ 1, - 1),
                    new Position(+ 2, - 2),
                    new Position(+ 3, - 3),
                    new Position(+ 4, - 4),
                    new Position(+ 5, - 5),
                    new Position(+ 6, - 6),
                    new Position(+ 7, - 7),
                },
                new List<Position>()
                {
                    new Position(- 1, + 1),
                    new Position(- 2, + 2),
                    new Position(- 3, + 3),
                    new Position(- 4, + 4),
                    new Position(- 5, + 5),
                    new Position(- 6, + 6),
                    new Position(- 7, + 7),
                },
                new List<Position>()
                {
                    new Position(- 1, - 1),
                    new Position(- 2, - 2),
                    new Position(- 3, - 3),
                    new Position(- 4, - 4),
                    new Position(- 5, - 5),
                    new Position(- 6, - 6),
                    new Position(- 7, - 7),
                }

            };
        }
    }
}