using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Rules
    {

        enum GameState
        {
            Active = 1,
            NotActive = 0
        }
        enum PlayerState
        {
            Turn = 1,
            NotTurn = 0,
            JumpedOver = -1
        }

        public Rules()
        {

        }

        public bool CanCardBePlayed(Card card, params Card[] table)
        {
            return true;
        }


    }
}
