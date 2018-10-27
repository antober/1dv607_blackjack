using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class PlayerWinsOnEqual : IWinnerStrategy
    {
        private int g_maxScore = 21;
        public bool IsWinner(Dealer a_dealer, Player a_player)
        {
            if (a_player.CalcScore() > g_maxScore)
            {
                return true;
            }
            if (a_dealer.CalcScore() > g_maxScore) 
            {
                return false;
            }
            else if (a_dealer.CalcScore() == a_dealer.CalcScore())
            {
                return false;
            }
            else
            {
                return a_dealer.CalcScore() > a_player.CalcScore();
            }
        }
    }
}