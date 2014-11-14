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
           
            
                var count = directionList.Count();
                piece.PossibleMovesThisTime.Clear();
                foreach (var step in directionList)
                {
                    if (piece.PieceValue == 1)
                    {
                        GetPawnLogic(step, piece);
                    }
                    else if (piece.PieceValue == 4)
                    {
                        if (piece.position.X + step.X >= 0 && piece.position.X + step.X <= 7 &&
                            piece.position.Y + step.Y >= 0 && piece.position.Y + step.Y <= 7)
                        {
                            if (gameboard.chessboard[piece.position.X + step.X, piece.position.Y + step.Y] == null)
                            {
                                ifStepIsWithinGameboard(step, piece);
                            }
                            else
                            {
                                ifStepIsWithinGameboard(step, piece);
                            }
                        }
                    }
                    else if (piece.position.X + step.X >= 0 && piece.position.X + step.X <= 7 &&
                             piece.position.Y + step.Y >= 0 && piece.position.Y + step.Y <= 7)
                    {
                        if (gameboard.chessboard[piece.position.X + step.X, piece.position.Y + step.Y] == null)
                        {
                            ifStepIsWithinGameboard(step, piece);
                        }
                        else
                        {
                            ifStepIsWithinGameboard(step, piece);
                            return;
                        }
                    }
                 // kallar inte på metoden
                  }
                
                    
         
        }
        private void GetPawnLogic(Position step, Piece piece)
        {
            if ((piece.position.X + step.X >= 0 && piece.position.X + step.X <= 7 &&
                    piece.position.Y + step.Y >= 0 && piece.position.Y + step.Y <= 7))
            {
                if ((gameboard.chessboard[piece.position.X + step.X, piece.position.Y + step.Y] == null))
                {
                    if (piece.position.Y + step.Y == piece.position.Y)
                    {

                        if (piece.PieceColour == ConsoleColor.White)
                        {
                            if (step.X < 0)
                            {
                                return;
                            }
                        }
                        else if (piece.PieceColour == ConsoleColor.Red)
                        {
                            if (step.X > 0)
                            {
                                return;
                            }
                        }
                        ifStepIsWithinGameboard(step, piece);
                        return;
                    }
                }
                else
                {
                    if ((gameboard.chessboard[piece.position.X + step.X, piece.position.Y + step.Y] != null))
                    {
                        if (piece.PieceColour ==
                            gameboard.chessboard[piece.position.X + step.X, piece.position.Y + step.Y]
                                .PieceColour)
                        {
                            return;
                        }
                        else
                        {
                            if (piece.position.Y + step.Y != piece.position.Y)
                            {
                                if (piece.PieceColour == ConsoleColor.White)
                                {
                                    if (step.X < 0)
                                    {
                                        return;
                                    }
                                }
                                else if (piece.PieceColour == ConsoleColor.Red)
                                {
                                    if (step.X > 0)
                                    {
                                        return;
                                    }
                                }
                                ifStepIsWithinGameboard(step, piece);
                            }
                        }
                    }
                }
            }
        }

        private void ifStepIsWithinGameboard(Position step, Piece piece)
        {
            if (gameboard.chessboard[piece.position.X + step.X, piece.position.Y + step.Y] == null)
            {
                AddPossibleMovesToList(step, piece);
            }
            else if (gameboard.chessboard[piece.position.X + step.X, piece.position.Y + step.Y].PieceColour != piece.PieceColour)
            {
                AddMovesToKillList(step, piece);
            }
        }
        private void AddMovesToKillList(Position step, Piece piece)
        {
            piece.PossibleKillsThisTime.Add(step);

            Console.WriteLine(piece + "Kill: " + step);
        }

        private void AddPossibleMovesToList(Position step, Piece piece)
        {
            piece.PossibleMovesThisTime.Add(step);

            Console.WriteLine("Lade till: " + piece + piece.position +
                                " &       " + step + " i listan");
         
           
        }

        public void CheckForBestMove(Position step, Piece piece)
        {
            Piece newPiece;
            foreach (var piece1 in gameboard.pieceList)
            {
                if (piece1.position.X == step.X + piece.position.X && piece1.position.Y == step.Y + piece.position.Y)
                {
                    newPiece = piece1;
                    listClass.EnemysToKill.Add(newPiece);
                }
            }
            
            int highestValue = listClass.EnemysToKill[0].PieceValue;

            foreach (var enemyWithHighestValue in listClass.EnemysToKill)
            {
                if (enemyWithHighestValue.PieceValue > highestValue)
                {
                    highestValue = enemyWithHighestValue.PieceValue;
                }
            }

            Console.WriteLine(highestValue + "Hej !!  Pjäs");
            Console.ReadLine();
        }
    }
}