using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    interface IWinnerStrategy
    {
        bool IsWinner(model.Dealer a_dealer, model.Player a_player);
    }
}