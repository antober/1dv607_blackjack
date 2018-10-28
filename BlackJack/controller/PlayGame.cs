using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BlackJack.controller
{
    class PlayGame : model.IObservers
    {
        private model.Game game;

        private view.IView view;

        private int input;

        public PlayGame(model.Game a_game, view.IView a_view)
        {
            game = a_game;
            view = a_view;
        }

        public void CardRecieved()
        {
            Thread.Sleep(1000);
			view.DisplayWelcomeMessage();

			view.DisplayDealerHand(game.GetDealerHand(), game.GetDealerScore());
			view.DisplayPlayerHand(game.GetPlayerHand(), game.GetPlayerScore());
        }

        public bool Play()
        {
            view.DisplayWelcomeMessage();
            
            view.DisplayDealerHand(game.GetDealerHand(), game.GetDealerScore());
            view.DisplayPlayerHand(game.GetPlayerHand(), game.GetPlayerScore());

            if (game.IsGameOver())
            {
                game.m_player.ClearSubscriber();
				game.m_dealer.ClearSubscriber();
                view.DisplayGameOver(game.IsDealerWinner());
            }

            input = view.GetInput();

            if (input == 'p')
            {
                game.m_player.AddSubscriber(this);
			    game.m_dealer.AddSubscriber(this);
                game.NewGame();
            }
            else if (input == 'h')
            {
                game.Hit();
            }
            else if (input == 's')
            {
                game.Stand();
            }

            return input != 'q';
        }
    }
}
