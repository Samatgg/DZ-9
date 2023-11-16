using System;
using System.Collections.Generic;

namespace Задача.Games
{
    public class RacingGame 
    {
        private List<IGame> games;
        private List<string> countries;

        public RacingGame(List<string> countries)
        {
            this.countries = countries;
            this.games = new List<IGame>();
        }

        public void AddGame(IGame game)
        {
            games.Add(game);
        }

        public void PlayGames()
        {
            foreach (var country in countries)
            {
                Console.WriteLine($"Команда {country}:");
                foreach (var game in games)
                {
                    game.Play();
                }
                Console.WriteLine();
            }
        }
    }
}
