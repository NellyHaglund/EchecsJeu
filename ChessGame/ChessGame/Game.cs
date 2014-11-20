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
                whitePlayer.RandomizeMoveInPossibleMoveList();
                gameboard.PrintGameboard();
                Console.ReadLine();
                Console.Clear();

                blackPlayer.ChoosePieceToPlay();
                blackPlayer.RandomizeMoveInPossibleMoveList();
                gameboard.PrintGameboard();
                Console.ReadLine();
                
            }
        }
    }
}
