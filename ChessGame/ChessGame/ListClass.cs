using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class ListClass
    {
        public List<Piece> playerWhiteList;
        public List<Piece> playerBlackList;
        public List<List<Piece>> possibleMoves;
        public List<List<Piece>> possibleKills;

        public ListClass(List<Piece> playerWhiteList, List<Piece> playerBlackList, List<List<Piece>> possibleMoves, List<List<Piece>> possibleKills)
        {
            this.playerWhiteList = playerWhiteList;
            this.playerBlackList = playerBlackList;
            this.possibleMoves = possibleMoves;
            this.possibleKills = possibleKills;
        }

        public void GetPieceList(List<Piece> listWhite, List<Piece> listBlack)
        {
            playerWhiteList = listWhite;
            playerBlackList = listBlack;

            foreach (var piece in playerWhiteList)
            {
                Console.WriteLine(piece);
            }
            Console.ReadKey();
        }

        //private void GetPossibleMoves(Piece piece)
        //{
        //    piece.ToString();
        //}
    }
}
