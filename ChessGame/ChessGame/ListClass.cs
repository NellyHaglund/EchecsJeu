﻿using System;
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
        private Gameboard gameboard;


        public ListClass(Gameboard gameboard)
        {
            this.gameboard = gameboard;
            playerBlackList = new List<Piece>();
            playerWhiteList = new List<Piece>();
            SeparatePiecesIntoTwoLists();
        }

        public void SeparatePiecesIntoTwoLists()
        {

            foreach (var piece in gameboard.pieceList)
            {
                if (piece.PieceColour == ConsoleColor.Black)
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
