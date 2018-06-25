using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCardGame
{
    class Card
    {
        //Values that a Card object holds.
        int cardValue;
        string cardKey;



        //How making a Card object is done.
        public Card(int value, string key)
        {
            cardValue = value;
            cardKey = key;
        }

        //Accessor on a Card object if you need to get its value.
        public int CardValue
        {
            get { return cardValue; }
            set { cardValue = value; }
        }

        //Accessor for a Card object's key.
        public string CardKey
        {
            get { return cardKey; }
            set { cardKey = value; }
        }

        private static List<Card> playerDeck = new List<Card>();
        private static List<Card> opponentDeck = new List<Card>();

        public static void PlayerDeckAdd(Card card)
        {
            playerDeck.Add(card);
        }

        public static List<Card> GetPlayerDeck()
        {
            return playerDeck;
        }

        public static void PlayerDeckRemove(string chosenCard)
        {
            foreach(Card card in playerDeck)
            {
                if (chosenCard == card.CardKey)
                {
                    playerDeck.Remove(card);
                    break;
                }
            }
        }

        public static void OpponentDeckAdd(Card card)
        {
            opponentDeck.Add(card);
        }

        public static List<Card> GetOpponentDeck()
        {
            return opponentDeck;
        }

        public static void OpponentDeckRemove(string chosenCard)
        {
            foreach (Card card in playerDeck)
            {
                if (chosenCard == card.CardKey)
                {
                    playerDeck.Remove(card);
                    break;
                }
            }
        }
    }
}
