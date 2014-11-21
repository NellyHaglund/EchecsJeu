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
        private Piece piece;
        private MoveInfo moveinfo;

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

            while (gameOver == false)
            {

                Console.Clear();
                whitePlayer.ChoosePieceToPlay();
                var moveInfo = whitePlayer.RandomizeMoveInPossibleMoveList();
                moveinfo = new MoveInfo(moveInfo);
                
                gameboard.PrintGameboard();
                Console.WriteLine(moveinfo.PrintMove());


                Console.ReadLine();
                Console.Clear();

                blackPlayer.ChoosePieceToPlay();
                
               moveInfo = blackPlayer.RandomizeMoveInPossibleMoveList();
               moveinfo = new MoveInfo(moveInfo);
               gameboard.PrintGameboard();
               Console.WriteLine(moveinfo.PrintMove());
               Console.ReadLine();
             

            }
        }
    }
}
