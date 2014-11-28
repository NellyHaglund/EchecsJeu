using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    
  public  class MovementOptions
    {
        public Piece myPiece;
        public Position futurePosition;   
        public Position oldPosition;

        public MovementOptions(Position step, Piece piece)
        {          
            futurePosition = new Position(piece.position.X,piece.position.Y);
            oldPosition = new Position(futurePosition.X, futurePosition.Y);
            myPiece = piece;
            futurePosition.X = piece.position.X + step.X;
            futurePosition.Y = piece.position.Y + step.Y;                
        }            
    }
}
