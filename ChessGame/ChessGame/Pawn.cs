using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Pawn : Piece
    {
        List<Position> pawnMoves = new List<Position>();
        //public Pawn() { }
        public Pawn(Position position, ConsoleColor color)
        {
            this.position = position;
            PieceColour = color;
            PieceValue = 1;
            PieceChar = 'B';                
        }
        //public override void PossibleMoves(Piece piece)
        //{
        //    pawnMoves.Clear();
        //    pawnMoves.Add(new Position(position.X + 1, position.Y));
        //    pawnMoves.Add(new Position(position.X - 1, position.Y));         

        //}

    }
}