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
        Random random = new Random();
        List<MovementOptions> KilledPieces;
        List<MovementOptions> PossibleFinalMoves;
        List<MovementOptions> PossibleFinalKillMoves;
        public Player(ConsoleColor color, Gameboard gameboard)
        {
            this.gameboard = gameboard;
            this.color = color;
            listClass = new ListClass(gameboard);
            PossibleFinalMoves = new List<MovementOptions>();
            PossibleFinalKillMoves = new List<MovementOptions>();
            KilledPieces = new List<MovementOptions>();
        }
        public void ChoosePieceToPlay()
        {
            PossibleFinalKillMoves.Clear();
            PossibleFinalMoves.Clear();
            listClass.SeparatePiecesIntoTwoLists();
            if (color == ConsoleColor.White)
            {
                foreach (var piece in listClass.playerWhiteList)
                {
                    SavesPossibleMoves(piece);
                    //  Console.WriteLine("White");
                    //  Console.ReadKey();

                }

            }
            else
            {
                foreach (var piece in listClass.playerBlackList)
                {
                    SavesPossibleMoves(piece);
                    //Console.WriteLine("Black");
                    //Console.ReadKey();

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


            //  piece.PossibleMovesThisTime.Clear();
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
                if (piece2.position.X == piece.position.X + step.X && piece.position.Y + step.Y == piece2.position.Y)
                {
                    if (piece.PieceColour != piece2.PieceColour)
                    {
                        MovementOptions movementOption = new MovementOptions(step, piece);
                        PossibleFinalKillMoves.Add(movementOption);
                        //Console.WriteLine(piece2 + " På position " + piece2.position +
                        //" Kan bli dödad av " + piece + " på pos: " + piece.position);
                    }




                    //  Detta använder vi sen när vi valt kill för att spara undan den döde spelaren Remove från gameboard.pieceLIst och lägg till på ny lista över döda pjäser
                    // 
                }
            }


        }

        private void AddPossibleMovesToList(Position step, Piece piece)
        {
            MovementOptions movementOption = new MovementOptions(step, piece);
            PossibleFinalMoves.Add(movementOption);


            //  Console.WriteLine("Lade till i PossibleMovesThisTime: " + piece + piece.position +
            //                     " &       " + step + " i listan");
        }

        //public void CheckForBestMove(Position step, Piece piece)
        //{
        //    Piece newPiece;
        //    int highestValue = 0;
        //    foreach (var piece1 in gameboard.pieceList)
        //    {

        //        newPiece = piece1;
        //        if (piece1.position.X == step.X + piece.position.X && piece1.position.Y == step.Y + piece.position.Y)
        //        {
        //            listClass.EnemysToKill.Add(newPiece);
        //        }
        //    }

        //    for (int i = 0; i < listClass.EnemysToKill.Count; i++)
        //    {

        //        if (listClass.EnemysToKill[i].PieceValue > highestValue)
        //        {
        //            highestValue = listClass.EnemysToKill[i].PieceValue;
        //        }

        //    }
        //  Console.WriteLine("Detta är det högsta värdet, {0}, och det är en {1}", highestValue, piece);

        //}
        public MovementOptions RandomizeMoveInPossibleMoveList()
        {

            if (PossibleFinalKillMoves.Count > 0)
            {

                //int highestValue = 0;
                //foreach (var killMove in PossibleFinalKillMoves)
                //{
                //    if (killMove.myPiece.PieceValue > highestValue)
                //    {
                //        highestValue = killMove.myPiece.PieceValue;
                //    }
                //}
                //Random random = new Random();
              
             
                int choice = new Random().Next(0, PossibleFinalKillMoves.Count);
                var movement = PossibleFinalKillMoves[choice];
                foreach (var pieceToBeRemoved in gameboard.pieceList)
                {
                    if (pieceToBeRemoved.position.X == movement.futurePosition.X && pieceToBeRemoved.position.Y == movement.futurePosition.Y)
                    {
                        gameboard.pieceList.Remove(pieceToBeRemoved);
                        break;
                    }
                }
                //gameboard.pieceList.RemoveAt();

                movement.myPiece.position.X = movement.futurePosition.X;
                movement.myPiece.position.Y = movement.futurePosition.Y;
                //foreach (var piece2 in gameboard.piecelist)
                //{
                //    if (movement.oldposition.x == movement.mypiece.position.x + movement.futureposition.x && piece2.position.y == movement.mypiece.position.y + movement.futureposition.y)
                //    {
                //        killedpieces.add(piece2);
                //        gameboard.piecelist.remove(piece2);
                //        break;
                //    }

                //}


                gameboard.GiveStartPositionsToPieces();
                return movement;
            }
            else
            {
               
                int choice = new Random().Next(PossibleFinalMoves.Count);
                if (PossibleFinalKillMoves.Count == 0)
                {
                    Console.WriteLine("Game Over");                    
                }                
                    var movement = PossibleFinalMoves[choice];
                    movement.myPiece.position.X = movement.futurePosition.X;
                    movement.myPiece.position.Y = movement.futurePosition.Y;
                    gameboard.GiveStartPositionsToPieces();
                    return movement;
                


                
                

            }
        }
    }

}