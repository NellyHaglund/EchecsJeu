using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Player
    {
        ListClass listClass = new ListClass();
        private ConsoleColor color;
        private Gameboard gameboard;
        
        public Player(ConsoleColor color)

        {
            this.color = color;
            
        }

        public void ContactGame()
        {
            listClass.GetPieceList(gameboard.whitePieceList, gameboard.blackPieceList);

        }
       
        public void ChoosePieceToPlay()
        {
           
        }
    }
}
