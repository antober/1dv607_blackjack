using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class DealerWinsOnEqual : IWinnerStrategy
    {
        public bool IsWinner(int score, Player a_dealer)
        {
            if(score == a_dealer.CalcScore())
            {
                return true;
            }
            return false;
        }
    }
}