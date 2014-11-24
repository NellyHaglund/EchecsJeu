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
        public ListClass listClass;

        public Game()
        {
            gameboard = new Gameboard();
            blackPlayer = new Player(ConsoleColor.Red, gameboard);
            whitePlayer = new Player(ConsoleColor.White, gameboard);

        }

        public void StartGame()
        {

            gameboard.PrintGameboard();
            Console.ReadLine();

            bool gameOver = false;
            int turn = 0;
            while (gameOver == false)
            {

                //if (gameboard.pieceList.Contains)
                //{
                //    gameOver = true;
                //    Console.WriteLine("GAME OVER, WHITE PLAYER WON!");
                //}
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
               
                //if (listClass.playerWhiteList.Count == null)
                //{
                //    gameOver = true;
                //    Console.WriteLine("GAME OVER, BLACK PLAYER WON!");
                //}
                Console.ReadKey();


            }
        }
    }
}
