using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCardGame
{
    class Player
    {
        private string _playerName;

        public string PlayerName
        {
            get { return _playerName; }
            set { _playerName = value; }
        }

        public Player(string PlayerName)
        {
            _playerName = PlayerName;
        }
    }

    class Card
    {

        private static Random rng = new Random();

        public static List<Card> Shuffle(List<Card> shuffleDeck)
        {

            int n = shuffleDeck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card choice = shuffleDeck[k];
                shuffleDeck[k] = shuffleDeck[n];
                shuffleDeck[n] = choice;

            }



            return shuffleDeck;

        }
    }
}
