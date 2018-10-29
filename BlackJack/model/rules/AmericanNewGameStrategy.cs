using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class AmericanNewGameStrategy : INewGameStrategy
    {
        public bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            a_player.GetCard(a_deck);
            a_dealer.GetCard(a_deck);
            a_player.GetCard(a_deck);

            Card c = a_deck.GetCard();
            c.Show(false);
            a_dealer.DealCard(c);

            return true;
        }
    }
}
