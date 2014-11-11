using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Pawn : Piece
    {

        public Pawn() { }
        public Pawn(Position position, ConsoleColor color)
        {
            this.position = position;
            PieceColour = color;
            PieceValue = 1;
            PieceChar = 'B';                
        }

    }
}