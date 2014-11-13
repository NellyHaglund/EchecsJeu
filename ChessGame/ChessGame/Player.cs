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
                    Console.WriteLine("White");
                    Console.ReadKey();
                }
            }
            else
            {
                foreach (var piece in listClass.playerBlackList)
                {
                    SavesPossibleMoves(piece);
                    Console.WriteLine("Black");
                    Console.ReadKey();
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
                // if(piece.position.X >= 0 && piece.position.X < 8 && piece.position.Y >= 0 && piece.position.Y < 8)
                //{
                if (piece.position.X + step.X >= 0 && piece.position.X + step.X <= 7 && piece.position.Y+ step.Y >= 0 && piece.position.Y + step.Y <= 7)
                {


                    if (gameboard.chessboard[piece.position.X + step.X, piece.position.Y + step.Y] == null)
                    {

                        listClass.possibleMoves.Add(step);
                        Console.WriteLine("Lade till: " + piece.ToString() +  piece.position.ToString() + " &       " + step.ToString() + " i listan");
                    }
                    else
                    {
                        Console.WriteLine("Lade inte till: " + piece.ToString() + piece.position.ToString() + " &       " + step.ToString() + " i listan");
                    }
                }
                //}                 
            }
        }
    }
}