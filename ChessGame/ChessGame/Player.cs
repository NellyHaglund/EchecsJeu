using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Player
    {
        private ListClass listClass;
        private ConsoleColor color;
        private Gameboard gameboard;

        public Player(ConsoleColor color, Gameboard gameboard)
        {
            this.color = color;
            listClass = new ListClass(gameboard);
        }

        public void ChoosePieceToPlay()
        {
            //var blackList = listClass.playerBlackList;
            //var whiteList = listClass.playerWhiteList;

            if (color == ConsoleColor.White)
            {
                foreach (var piece in listClass.playerWhiteList)
                {
                    SavesPossibleMoves(piece);
                }
            }
            else
            {
                foreach (var piece in listClass.playerBlackList)
                {
                    SavesPossibleMoves(piece);

                }
            }

        }
        public void SavesPossibleMoves(Piece piece)
        {
             

             foreach (var directionList  in piece.AllPossibleMovesList)
             {
                 TryAllDirections(directionList);

             }
          
        }

        private  void TryAllDirections(List<Position> directionList)
        {
            foreach (var position in directionList)
            {
                
                
                    listClass.possibleMoves.Add(position);
                
               
            }
        }

    }
}