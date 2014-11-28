using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class MoveInfo
    {
       public MovementOptions MoveOptionInfo;

        public MoveInfo(MovementOptions moveop)
        {
            MoveOptionInfo = moveop;
        }
        public string PrintMove()
        {
            return string.Format("\r\n\r\n"+MoveOptionInfo.myPiece.ToString() + "On Position" 
                                  +MoveOptionInfo.oldPosition.ToString() + "\nMoves To: " + 
                                  MoveOptionInfo.futurePosition.ToString());
        }
    }
}
