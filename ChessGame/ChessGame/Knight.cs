﻿using System;
using System.Collections.Generic;

namespace ChessGame
{
    public class Knight : Piece
    {
       
        public Knight(Position position, ConsoleColor color)
        {
            this.position = position;
            PieceColour = color;
            PieceValue = 4;
            PieceChar = 'H';
            AllPossibleMovesList = new List<List<Position>>()
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