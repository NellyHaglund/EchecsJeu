using System;
using System.Collections.Generic;

namespace ChessGame
{
    public class Bishop : Piece
    {       
        public Bishop(Position position, ConsoleColor color)
        {
            this.position = position;
            PieceColour = color;
            PieceValue = 3;
            PieceChar = 'B';
            PossibleMovesThisTime = new List<Piece>();
            PossibleKillsThisTime = new List<Piece>();
            AllPossibleMovesList = new List<List<Position>>()
            {
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
        public override string ToString()
        {
            return "Bishop ";
        }
    }
}