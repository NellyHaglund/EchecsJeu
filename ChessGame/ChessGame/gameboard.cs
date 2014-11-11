using System;
using System.Collections.Generic;

namespace ChessGame
{
    public class Gameboard
    {
        public Piece[,] chessboard = new Piece[8,8];
        List<Piece> whitePieceList = new List<Piece>();

        List<Piece> blackPieceList = new List<Piece>();

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

        public void CreateChessPieceStartPositionListForWhiteAndBlackPiecesWithDifferentValuesAndColourAndChar()
        {
            
            whitePieceList.Add(chessboard[1, 0] = new Pawn(new Position(1, 0), ConsoleColor.White));
            whitePieceList.Add(chessboard[1, 1] = new Pawn(new Position(1, 1), ConsoleColor.White));
            whitePieceList.Add(chessboard[1, 2] = new Pawn(new Position(1, 2), ConsoleColor.White));
            whitePieceList.Add(chessboard[1, 3] = new Pawn(new Position(1, 3), ConsoleColor.White));
            whitePieceList.Add(chessboard[1, 4] = new Pawn(new Position(1, 4), ConsoleColor.White));
            whitePieceList.Add(chessboard[1, 5] = new Pawn(new Position(1, 5), ConsoleColor.White));
            whitePieceList.Add(chessboard[1, 6] = new Pawn(new Position(1, 6), ConsoleColor.White));
            whitePieceList.Add(chessboard[1, 7] = new Pawn(new Position(1, 7), ConsoleColor.White));
            whitePieceList.Add(chessboard[0, 4] = new King(new Position(0, 4), ConsoleColor.White));
            whitePieceList.Add(chessboard[0, 3] = new Queen(new Position(0, 3), ConsoleColor.White));
            whitePieceList.Add(chessboard[0, 1] = new Knight(new Position(0, 1), ConsoleColor.White));
            whitePieceList.Add(chessboard[0, 6] = new Knight(new Position(0, 6), ConsoleColor.White));
            whitePieceList.Add(chessboard[0, 0] = new Rook(new Position(0, 0), ConsoleColor.White));
            whitePieceList.Add(chessboard[0, 7] = new Rook(new Position(0, 7), ConsoleColor.White));
            whitePieceList.Add(chessboard[0, 2] = new Bishop(new Position(0, 2), ConsoleColor.White));
            whitePieceList.Add(chessboard[0, 5] = new Bishop(new Position(0, 5), ConsoleColor.White));


            blackPieceList.Add(chessboard[6, 0] = new Pawn(new Position(6, 0), ConsoleColor.Red));
            blackPieceList.Add(chessboard[6, 1] = new Pawn(new Position(6, 1), ConsoleColor.Red));
            blackPieceList.Add(chessboard[6, 2] = new Pawn(new Position(6, 2), ConsoleColor.Red));
            blackPieceList.Add(chessboard[6, 3] = new Pawn(new Position(6, 3), ConsoleColor.Red));
            blackPieceList.Add(chessboard[6, 4] = new Pawn(new Position(6, 4), ConsoleColor.Red));
            blackPieceList.Add(chessboard[6, 5] = new Pawn(new Position(6, 5), ConsoleColor.Red));
            blackPieceList.Add(chessboard[6, 6] = new Pawn(new Position(6, 6), ConsoleColor.Red));
            blackPieceList.Add(chessboard[6, 7] = new Pawn(new Position(6, 7), ConsoleColor.Red));
            blackPieceList.Add(chessboard[7, 4] = new King(new Position(7, 4), ConsoleColor.Red));
            blackPieceList.Add(chessboard[7, 3] = new Queen(new Position(7, 3), ConsoleColor.Red));
            blackPieceList.Add(chessboard[7, 1] = new Knight(new Position(7, 1), ConsoleColor.Red));
            blackPieceList.Add(chessboard[7, 6] = new Knight(new Position(7, 6), ConsoleColor.Red));
            blackPieceList.Add(chessboard[7, 0] = new Rook(new Position(7, 0), ConsoleColor.Red));
            blackPieceList.Add(chessboard[7, 7] = new Rook(new Position(7, 7), ConsoleColor.Red));
            blackPieceList.Add(chessboard[7, 2] = new Bishop(new Position(7, 2), ConsoleColor.Red));
            blackPieceList.Add(chessboard[7, 5] = new Bishop(new Position(7, 5), ConsoleColor.Red));
            
        }
    }
}