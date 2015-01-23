﻿using System;
using System.Collections.Generic;

namespace ChessGame
{
    public abstract class Piece
    {
        public Position position;   
        public ConsoleColor PieceColour { get; set; }
        public char PieceChar { get; set; }
        public int PieceValue { get; set; }
        public List<List<Position>> AllPossibleMovesList { get; set; }
        public List<Piece> PossibleMovesThisTime { get; set; }
        public List<Piece> PossibleKillsThisTime { get; set; }
    }
}