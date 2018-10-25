using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.controller
{
    class PlayGame
    {
        private model.Game a_game;

        private view.IView a_view;

        private int _input;

        public PlayGame(model.Game a_game, view.IView a_view)
        {
            this.a_game = a_game;
            this.a_view = a_view;
        }
        public bool Play()
        {
            this.a_view.DisplayWelcomeMessage();
            
            this.a_view.DisplayDealerHand(this.a_game.GetDealerHand(), this.a_game.GetDealerScore());
            this.a_view.DisplayPlayerHand(this.a_game.GetPlayerHand(), this.a_game.GetPlayerScore());

            if (this.a_game.IsGameOver())
            {
                this.a_view.DisplayGameOver(this.a_game.IsDealerWinner());
            }

            this._input = this.a_view.GetInput();

            if (_input == 'p')
            {
                this.a_game.NewGame();
            }
            else if (_input == 'h')
            {
                this.a_game.Hit();
            }
            else if (_input == 's')
            {
                this.a_game.Stand();
            }

            return _input != 'q';
        }
    }
}
