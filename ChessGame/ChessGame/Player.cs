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
            this.gameboard = gameboard;
            this.color = color;
            listClass = new ListClass(gameboard);
        }

        public void ChoosePieceToPlay()
        {
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
            foreach (var directionList in piece.AllPossibleMovesList)
            {
                TryAllDirections(directionList, piece);
            }
        }
        private void TryAllDirections(List<Position> directionList, Piece piece)
        {
            foreach (var step in directionList)
            {
                if (piece.position.X >= 0 && piece.position.X < 8 && piece.position.Y >= 0 && piece.position.Y < 8)
                {
                    if (gameboard.chessboard[piece.position.X + step.X, piece.position.Y + step.Y] == null)
                    {
                        listClass.possibleMoves.Add(step);
                    }
                    else
                    {
                        Console.WriteLine("Lägger inte till i PossibleMoves");
                    }
                }
                else
                {
                    Console.WriteLine("Du är inte inom gameboard");
                }

            }
        }
    }
}