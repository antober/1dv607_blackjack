using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class Soft17HitStragety : IHitStrategy
    {
        private const int g_hitLimit = 17;

        public bool DoHit(model.Player a_dealer)
        {
            if(a_dealer.CalcScore() < g_hitLimit)
            {
                return true;
            }
            else if(a_dealer.CalcScore() == g_hitLimit)
            {
                return a_dealer.GetHand().Any(c => c.GetValue() == Card.Value.Ace);
            }
            else
            {
                return false;
            }
        }
    }
}
