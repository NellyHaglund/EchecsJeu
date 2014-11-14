﻿using System;
using System.Collections.Generic;

namespace ChessGame
{
    public class King : Piece
    {
        
         

        public King(Position position, ConsoleColor color)
        {
            this.position = position;
            PieceColour = color;
            PieceValue = 11;
            PieceChar = 'K';
            PossibleMovesThisTime = new List<Position>();
            PossibleKillsThisTime = new List<Position>();
            AllPossibleMovesList = new List<List<Position>>()
            {
                new List<Position>()
                {
                    new Position(- 1, 0)
                },
                new List<Position>()
                {
                    new Position( - 1,+ 1)
                },
                new List<Position>()
                {
                    new Position(- 1, - 1)
                },
                new List<Position>()
                {
                    new Position(0, + 1)
                },
                new List<Position>()
                {
                    new Position(0, - 1)
                },
                new List<Position>()
                {
                    new Position( + 1,+ 1)
                },
                new List<Position>()
                {
                    new Position( + 1, - 1)
                },
                new List<Position>()
                {
                    new Position( + 1, 0)
                },
            
            };
        }

       
    }
}