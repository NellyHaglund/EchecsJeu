using System;
using System.Collections.Generic;

namespace ChessGame
{
    public class Gameboard
    {
        public Piece[,] chessboard = new Piece[8, 8];

        public List<Piece> pieceList;

        public Gameboard()
        {
            pieceList = new List<Piece>();
            CreateAndAddAllPiecesToPieceList();
            GiveStartPositionsToPieces();
        }

        public void PrintGameboard()
        {

            for (int x = 0; x < 8; x++)
            {
                Console.WriteLine();
                for (int y = 0; y < 8; y++)
                {
                    if (chessboard[x, y] == null)
                    {

                        Console.Write("[ ]");
                    }
                    else
                    {
                        Console.ForegroundColor = chessboard[x, y].PieceColour;

                        Console.Write("[{0}]", chessboard[x, y].PieceChar);

                    }
                }
            }
        }

        public void UpdatePosition(MovementOptions movement)
        {
            //if (step.X >= 0 && step.X < 8 && step.Y >= 0 && step.Y < 8)
            //{
            chessboard[movement.myPiece.position.X, movement.myPiece.position.Y] = null;
            //piece.position.X = piece.position.X + step.X;
            //piece.position.Y = piece.position.Y + step.Y;
            chessboard[movement.futurePosition.X, movement.futurePosition.Y] = movement.myPiece;

            Console.WriteLine("hoooooopppas attt dddeeeen fffllyyytttaaaddddeee");
            Console.ReadKey();
            //}

        }

        public void CreateAndAddAllPiecesToPieceList()
        {

            pieceList.Add(new Pawn(new Position(1, 0), ConsoleColor.White));
            pieceList.Add(new Pawn(new Position(1, 1), ConsoleColor.White));
            pieceList.Add(new Pawn(new Position(1, 2), ConsoleColor.White));
            pieceList.Add(new Pawn(new Position(1, 3), ConsoleColor.White));
            pieceList.Add(new Pawn(new Position(1, 4), ConsoleColor.White));
            pieceList.Add(new Pawn(new Position(1, 5), ConsoleColor.White));
            pieceList.Add(new Pawn(new Position(1, 6), ConsoleColor.White));
            pieceList.Add(new Pawn(new Position(1, 7), ConsoleColor.White));
            pieceList.Add(new King(new Position(0, 4), ConsoleColor.White));
            pieceList.Add(new Queen(new Position(0, 3), ConsoleColor.White));
            pieceList.Add(new Knight(new Position(0, 1), ConsoleColor.White));
            pieceList.Add(new Knight(new Position(0, 6), ConsoleColor.White));
            pieceList.Add(new Rook(new Position(0, 0), ConsoleColor.White));
            pieceList.Add(new Rook(new Position(0, 7), ConsoleColor.White));
            pieceList.Add(new Bishop(new Position(0, 2), ConsoleColor.White));
            pieceList.Add(new Bishop(new Position(0, 5), ConsoleColor.White));

            pieceList.Add(new Pawn(new Position(6, 0), ConsoleColor.Red));
            pieceList.Add(new Pawn(new Position(6, 1), ConsoleColor.Red));
            pieceList.Add(new Pawn(new Position(6, 2), ConsoleColor.Red));
            pieceList.Add(new Pawn(new Position(6, 3), ConsoleColor.Red));
            pieceList.Add(new Pawn(new Position(6, 4), ConsoleColor.Red));
            pieceList.Add(new Pawn(new Position(6, 5), ConsoleColor.Red));
            pieceList.Add(new Pawn(new Position(6, 6), ConsoleColor.Red));
            pieceList.Add(new Pawn(new Position(6, 7), ConsoleColor.Red));
            pieceList.Add(new King(new Position(7, 4), ConsoleColor.Red));
            pieceList.Add(new Queen(new Position(7, 3), ConsoleColor.Red));
            pieceList.Add(new Knight(new Position(7, 1), ConsoleColor.Red));
            pieceList.Add(new Knight(new Position(7, 6), ConsoleColor.Red));
            pieceList.Add(new Rook(new Position(7, 0), ConsoleColor.Red));
            pieceList.Add(new Rook(new Position(7, 7), ConsoleColor.Red));
            pieceList.Add(new Bishop(new Position(7, 2), ConsoleColor.Red));
            pieceList.Add(new Bishop(new Position(7, 5), ConsoleColor.Red));

        }

        private void GiveStartPositionsToPieces()
        {
            foreach (var piece in pieceList)
            {
                chessboard[piece.position.X, piece.position.Y] = piece;
            }
        }
    }
}