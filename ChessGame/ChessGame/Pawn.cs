using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Pawn : Piece
    {
        
       
        public Pawn(Position position, ConsoleColor color)
        {
            this.position = position;
            PieceColour = color;
            PieceValue = 1;
            PieceChar = 'B';
            PossibleMovesThisTime = new List<Piece>();
            PossibleKillsThisTime = new List<Piece>();
            AllPossibleMovesList = new List<List<Position>>()
            {
                new List<Position>()
                {
                    new Position(+ 1, 0)
                },
                new List<Position>()
                {
                    new Position(- 1, 0)
                },
                new List<Position>()
                {
                    new Position(+ 1, -1)
                },
                new List<Position>()
                {
                    new Position(+ 1, +1)
                },
                new List<Position>()
                {
                    new Position(- 1, +1)
                },
                new List<Position>()
                {
                    new Position(- 1, -1)
                },
            };
        }
     

    }
}