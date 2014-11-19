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

            ChessGame.Position lastStep = null;
            var count = directionList.Count();
            piece.PossibleMovesThisTime.Clear();
            foreach (var step in directionList)
            {
                lastStep = step;
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

            }
            if (lastStep != null)
            {
                CheckForBestMove(lastStep, piece);
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
            foreach (var piece2 in gameboard.pieceList)
            {
                /// FAAAAAAAAAAAAAAAAN!

                if (piece2.position.X && piece2.position.Y == piece.position.X+step.X && piece.position.Y+step)
                {
                    piece.PossibleKillsThisTime.Add(piece2);
                    Console.WriteLine("Lade till" + piece2 + "Kill: " + step + "++++++++++++++++++++++++++++++++++++++++++");
                }
            }

            
            Console.WriteLine("Lade till" + piece + "Kill: " + step);
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
            int highestValue = 0;
            foreach (var piece1 in gameboard.pieceList)
            {

                newPiece = piece1;
                if (piece1.position.X == step.X + piece.position.X && piece1.position.Y == step.Y + piece.position.Y)
                {
                    listClass.EnemysToKill.Add(newPiece);
                }
            }

            for (int i = 0; i < listClass.EnemysToKill.Count; i++)
            {

                if (listClass.EnemysToKill[i].PieceValue > highestValue)
                {
                    highestValue = listClass.EnemysToKill[i].PieceValue;
                }

            }

            Console.WriteLine("Detta är det högsta värdet, {0}, och det är en {1}", highestValue, piece);




            Console.ReadLine();
        }
    }
}