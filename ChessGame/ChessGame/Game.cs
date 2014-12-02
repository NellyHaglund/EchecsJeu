using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Game
    {

        private Gameboard gameboard;
        private Player blackPlayer;
        private Player whitePlayer;
        private MoveInfo moveinfo;
        public Game()
        {
            gameboard = new Gameboard();
            blackPlayer = new Player(ConsoleColor.Black, gameboard);
            whitePlayer = new Player(ConsoleColor.White, gameboard);
        }
        public void BeepSound()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(12, 10);
            Console.WriteLine("Chessgame by Nelly, Robin & Jakob".ToUpper());
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            for (int x = 0; x < 8; x++)
            {
                System.Threading.Thread.Sleep(200);
                System.Console.Beep(1900, 250);
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

                    if (gameboard.chessboard[x, y] == null)
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
                        Console.ForegroundColor = gameboard.chessboard[x, y].PieceColour;
                        Console.Write(" {0} ", gameboard.chessboard[x, y].PieceChar);
                        Console.ResetColor();
                    }
                }
            }
            Console.SetCursorPosition(8, 4);
            Console.WriteLine("CHESS\nPRESS ANY KEY TO START");
            Console.ReadKey();
            
        }
        private bool ColourBackground(int x, int y)
        {
            return ((x % 2) + (y % 2)) % 2 == 0;
        }

        public void StartGame()
        {
            BeepSound();

            gameboard.PrintGameboard();            

            bool gameOver = false;
            int turn = 0;

            while (gameOver == false)
            {
                Console.Clear();
                whitePlayer.ChoosePieceToPlay();
                var moveInfo = whitePlayer.RandomizeMoveInPossibleMoveList();
                moveinfo = new MoveInfo(moveInfo);
                turn++;
                gameboard.PrintGameboard();
                Console.WriteLine(moveinfo.PrintMove());
                Console.WriteLine("\r\nTurn: " + turn);
                whitePlayer.PrintWhiteKilledPieces();
                blackPlayer.PrintBlackKilledPieces();

                Console.ReadKey();
               // System.Threading.Thread.Sleep(1000);
                Console.Clear();

                blackPlayer.ChoosePieceToPlay();
                moveInfo = blackPlayer.RandomizeMoveInPossibleMoveList();
                moveinfo = new MoveInfo(moveInfo);
                turn++;
                gameboard.PrintGameboard();
                Console.WriteLine(moveinfo.PrintMove());
                Console.WriteLine("\r\nTurn: " + turn);
                whitePlayer.PrintWhiteKilledPieces();
                blackPlayer.PrintBlackKilledPieces();

                Console.ReadKey();
                //System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
