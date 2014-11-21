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
            return string.Format("\r\n\r\n"+MoveOptionInfo.myPiece.ToString() + "On position " +MoveOptionInfo.oldPosition.ToString() + " moves to " + MoveOptionInfo.futurePosition.ToString());
        }
    }
}
