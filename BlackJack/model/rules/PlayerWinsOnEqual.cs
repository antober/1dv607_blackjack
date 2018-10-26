using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class PlayerWinsOnEqual : IWinnerStrategy
    {
        public bool IsWinner(int score, Player a_dealer)
        {
            if(score == a_dealer.CalcScore())
            {
                return false; 
            }
            return true;
        }
    }
}