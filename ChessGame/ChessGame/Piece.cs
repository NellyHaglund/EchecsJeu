using System;
using System.Collections.Generic;

namespace ChessGame
{
    public class Piece
    {

        public Position position;   
        public ConsoleColor PieceColour { get; set; }
        public char PieceChar { get; set; }
        public int PieceValue { get; set; }

        //public virtual List<List<Position>> PossibleMoves()
        //{
        //    return
        //}
    }
}