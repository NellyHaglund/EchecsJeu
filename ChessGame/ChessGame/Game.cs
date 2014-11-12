using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Game
    {
       ListClass listClass = new ListClass();
       Gameboard gameboard = new Gameboard();
       Player blackPlayer = new Player(ConsoleColor.Black);
       Player whitePlayer = new Player(ConsoleColor.White);

        public void StartGame()
        {

            gameboard.CreateChessPieceStartPositionListForWhiteAndBlackPiecesWithDifferentValuesAndColourAndChar();
            gameboard.PrintGameboard();
            Console.ReadLine();

            bool gameOver = false;
            //listClass.GetPieceList(gameboard.whitePieceList, gameboard.blackPieceList);
            while (gameOver)
            {
                

               
            }


        }
    }
}
