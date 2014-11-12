using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Program 
    {
      
        
        static void Main(string[] args)
        {
            var gameboard = new Gameboard();
            var king = new King(new Position(2,5), ConsoleColor.White);
            Console.WriteLine(king);

            
            gameboard.CreateChessPieceStartPositionListForWhiteAndBlackPiecesWithDifferentValuesAndColourAndChar();
            gameboard.PrintGameboard();
            Console.ReadLine();

            //gameboard.GetPieceList();

            gameboard.PrintGameboard();
            Console.ReadLine();
        }
    }
}
