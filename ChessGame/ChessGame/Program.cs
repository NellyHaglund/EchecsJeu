﻿using System;
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
            

            gameboard.CreateChessPieceStartPositionListForWhiteAndBlackPiecesWithDifferentValuesAndColourAndChar();
            gameboard.PrintGameboard();
            Console.ReadLine();
        }
    }
}
