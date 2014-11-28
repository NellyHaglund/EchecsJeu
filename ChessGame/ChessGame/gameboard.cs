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
            Console.Clear();

            for (int x = 0; x < 8; x++)
            {
          
                Console.WriteLine();
                for (int y = 0; y < 8; y++)
                {
                    var backgroundColor = ConsoleColor.Gray;
                    var consoleColor = ConsoleColor.DarkGray;
                    if (ColourBackground(x, y))
                    {
                        Console.BackgroundColor = backgroundColor;
                    }
                    else
                    {
                        Console.BackgroundColor = consoleColor;          
                    }
                    if (chessboard[x, y] == null)
                    {
                        if (ColourBackground(x, y))
                        {
                            Console.BackgroundColor = backgroundColor;
                        }
                        else
                        {
                            Console.BackgroundColor = consoleColor; 
                        }
                        Console.Write("   ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = chessboard[x, y].PieceColour;
                        Console.Write(" {0} ", chessboard[x, y].PieceChar);
                        Console.ResetColor();   
                    }
                }
            }
        }
        private bool ColourBackground(int x, int y)
        {
            return ((x % 2) + (y % 2)) % 2 == 0;
        }
        public void UpdatePosition(MovementOptions movement)
        {
            GiveStartPositionsToPieces();
        }
        public void CreateAndAddAllPiecesToPieceList()
        {
            var consoleColorWhite = ConsoleColor.White;
            pieceList.Add(new Pawn(new Position(1, 0), consoleColorWhite));
            pieceList.Add(new Pawn(new Position(1, 1), consoleColorWhite));
            pieceList.Add(new Pawn(new Position(1, 2), consoleColorWhite));
            pieceList.Add(new Pawn(new Position(1, 3), consoleColorWhite));
            pieceList.Add(new Pawn(new Position(1, 4), consoleColorWhite));
            pieceList.Add(new Pawn(new Position(1, 5), consoleColorWhite));
            pieceList.Add(new Pawn(new Position(1, 6), consoleColorWhite));
            pieceList.Add(new Pawn(new Position(1, 7), consoleColorWhite));
            pieceList.Add(new King(new Position(0, 4), consoleColorWhite));
            pieceList.Add(new Queen(new Position(0, 3), consoleColorWhite));
            pieceList.Add(new Knight(new Position(0, 1), consoleColorWhite));
            pieceList.Add(new Knight(new Position(0, 6), consoleColorWhite));
            pieceList.Add(new Rook(new Position(0, 0), consoleColorWhite));
            pieceList.Add(new Rook(new Position(0, 7), consoleColorWhite));
            pieceList.Add(new Bishop(new Position(0, 2), consoleColorWhite));
            pieceList.Add(new Bishop(new Position(0, 5), consoleColorWhite));

            var consoleColorBLack = ConsoleColor.Black;
            pieceList.Add(new Pawn(new Position(6, 0), consoleColorBLack));
            pieceList.Add(new Pawn(new Position(6, 1), consoleColorBLack));
            pieceList.Add(new Pawn(new Position(6, 2), consoleColorBLack));
            pieceList.Add(new Pawn(new Position(6, 3), consoleColorBLack));
            pieceList.Add(new Pawn(new Position(6, 4), consoleColorBLack));
            pieceList.Add(new Pawn(new Position(6, 5), consoleColorBLack));
            pieceList.Add(new Pawn(new Position(6, 6), consoleColorBLack));
            pieceList.Add(new Pawn(new Position(6, 7), consoleColorBLack));
            pieceList.Add(new King(new Position(7, 4), consoleColorBLack));
            pieceList.Add(new Queen(new Position(7, 3), consoleColorBLack));
            pieceList.Add(new Knight(new Position(7, 1), consoleColorBLack));
            pieceList.Add(new Knight(new Position(7, 6), consoleColorBLack));
            pieceList.Add(new Rook(new Position(7, 0), consoleColorBLack));
            pieceList.Add(new Rook(new Position(7, 7), consoleColorBLack));
            pieceList.Add(new Bishop(new Position(7, 2), consoleColorBLack));
            pieceList.Add(new Bishop(new Position(7, 5), consoleColorBLack));
        }
        public void GiveStartPositionsToPieces()
        {
            Array.Clear(chessboard, 0, 64);

            foreach (var piece in pieceList)
            {
                chessboard[piece.position.X, piece.position.Y] = piece;
            }
        }
    }
}