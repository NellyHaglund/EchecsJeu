using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Player
    {
        private ListClass listClass;
        private ConsoleColor color;
        private Gameboard gameboard;

        public Player(ConsoleColor color, Gameboard gameboard)
        {
            this.gameboard = gameboard;
            this.color = color;
            listClass = new ListClass(gameboard);
        }

        public void ChoosePieceToPlay()
        {
            if (color == ConsoleColor.White)
            {
                foreach (var piece in listClass.playerWhiteList)
                {
                    SavesPossibleMoves(piece);
                    Console.WriteLine("White");
                    Console.ReadKey();
                }
            }
            else
            {
                foreach (var piece in listClass.playerBlackList)
                {
                    SavesPossibleMoves(piece);
                    Console.WriteLine("Black");
                    Console.ReadKey();
                }
            }
        }
        public void SavesPossibleMoves(Piece piece)
        {
            foreach (var directionList in piece.AllPossibleMovesList)
            {
                TryAllDirections(directionList, piece);
            }
        }
        private void TryAllDirections(List<Position> directionList, Piece piece)
        {
            piece.PossibleMovesThisTime.Clear();
            foreach (var step in directionList)
            {
                ifStepIsWithinGameboard(step, piece);

            }
        }

        private void ifStepIsWithinGameboard(Position step, Piece piece)
        {
            if (piece.position.X + step.X >= 0 && piece.position.X + step.X <= 7 &&
                    piece.position.Y + step.Y >= 0 && piece.position.Y + step.Y <= 7)
            {
                if (gameboard.chessboard[piece.position.X + step.X, piece.position.Y + step.Y] == null)
                {
                    AddPossibleMovesToList(step, piece);
                }
                else if (gameboard.chessboard[piece.position.X + step.X, piece.position.Y + step.Y].PieceColour != piece.PieceColour)
                {
                    AddMovesToKillList(step, piece);
                }
            }
        }

        private void AddMovesToKillList(Position step, Piece piece)
        {
            listClass.possibleKills.Add(step);

            Console.WriteLine(piece + "Kill: " + step);
        }

        private void AddPossibleMovesToList(Position step, Piece piece)
        {
            piece.PossibleMovesThisTime.Add(step);

            Console.WriteLine("Lade till: " + piece + piece.position +
                                " &       " + step + " i listan");
        }
    }
}