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
            this.color = color;
            listClass = new ListClass(gameboard);     
        }
       
        public void ChoosePieceToPlay()
        {
           
        }
    }
}
