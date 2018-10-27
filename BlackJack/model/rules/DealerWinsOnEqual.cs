using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class DealerWinsOnEqual : IWinnerStrategy
    {
        private int g_maxScore = 21;
        public bool IsWinner(Dealer a_dealer, Player a_player)
        {
            if (a_player.CalcScore() > g_maxScore)
            {
                return true;
            }
            else if (a_dealer.CalcScore() > g_maxScore) 
            {
                return false;
            }
            else if (a_dealer.CalcScore() == a_dealer.CalcScore())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}