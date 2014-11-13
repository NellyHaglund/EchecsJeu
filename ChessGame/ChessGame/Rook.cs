using System;
using System.Collections.Generic;

namespace ChessGame
{
    public class Rook : Piece
    {
       

        public Rook(Position position, ConsoleColor color)
        {
            this.position = position;
            PieceColour = color;
            PieceValue = 5;
            PieceChar = 'T';
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
                }
            };
        }
    }
}