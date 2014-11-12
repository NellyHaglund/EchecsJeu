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
        public List<Position> possibleMoves;
        public List<Position> possibleKills;
        private Gameboard gameboard;


        public ListClass(Gameboard gameboard)
        {
            this.gameboard = gameboard;
            playerBlackList = new List<Piece>();
            playerWhiteList = new List<Piece>();
            possibleKills = new List<Position>();
            possibleMoves = new List<Position>();
            SeparatePiecesIntoTwoLists();
        }

        public void SeparatePiecesIntoTwoLists()
        {

            foreach (var piece in gameboard.pieceList)
            {
                if (piece.PieceColour == ConsoleColor.Red)
                {
                    playerBlackList.Add(piece);
                }
                else
                {
                    playerWhiteList.Add(piece);
                }
            }

        }

    }
}
