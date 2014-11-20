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
        public Position futurePosition;   // = step


        public MovementOptions(Position step, Piece piece)
        {


            futurePosition = step;
            myPiece = piece;
            futurePosition.X = piece.position.X + step.X;
            futurePosition.Y = piece.position.Y + step.Y;
                
        }

            
    }
}
