using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Pawn : Piece
    {
        List<List<Position>> pawnMoves;
       
        public Pawn(Position position, ConsoleColor color)
        {
            this.position = position;
            PieceColour = color;
            PieceValue = 1;
            PieceChar = 'B';
            pawnMoves = new List<List<Position>>()
            {
                new List<Position>()
                {
                    new Position(+ 1, 0)
                },
                new List<Position>()
                {
                    new Position(- 1, 0)
                },
                new List<Position>()
                {
                    new Position(+ 1, -1)
                },
                new List<Position>()
                {
                    new Position(+ 1, +1)
                },
                new List<Position>()
                {
                    new Position(- 1, +1)
                },
                new List<Position>()
                {
                    new Position(- 1, -1)
                },
            };
        }
     

    }
}