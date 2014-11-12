using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Player
    {
        private ConsoleColor color;
        public List<Piece> playerWhiteList;
        public List<Piece> playerBlackList;
        public List<List<Position>> choosenPieceList;
        public Player(ConsoleColor color)
        {
            this.color = color;
        }
        public void GetPieceList(List<Piece> listWhite, List<Piece> listBlack)
        {
            playerWhiteList = listWhite;
            playerBlackList = listBlack;
            foreach (var piece in playerBlackList)
            {
                GetPossibleMovesList(piece);
            }
        }

        public void GetPossibleMovesList(Piece piece)
        {
            //choosenPieceList = piece.PossibleMoves();
        }

    }
}
