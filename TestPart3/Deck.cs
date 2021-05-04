//Written By Jiameng Zhou
//04/02/2021
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestPart3
{
    public class Deck
    {
        
        private static Deck aDeck = new Deck();
        private List<Card> cards = new List<Card>();

        public static Deck GetDeck()
        {
            return aDeck;
        }

        public List<Card> GetCards()
        {
            return cards;   
        }
        public List<Card> Deal()
        {
            Random random = new Random();
            List<Card> usedCards = new List<Card>();

            for (int i = 0; i < 5; i++)
            {
                int rng = random.Next(cards.Count);// create a random index number
                Card result = cards[rng];
                usedCards.Add(result); // add removed card to another list
                cards.RemoveAt(rng); // remove a card
            }


            return usedCards;//later usedCards will be the cards on player hand
        }
        public override string ToString()
        {
            String s = "";
            foreach (Card card in cards)
            {
                s += card.ToString() + "\n";
            }
            return s;
        }

        public void Shuffle()
        {

            int cardCount = cards.Count;

            for (int i = 0; i< cardCount; i++)
            {
                Random random = new Random();
                int tempValue = random.Next(i + 1);
                Card placeHolder = cards[i]; // place holder = A Card
                cards[i] = cards[tempValue]; // A card = a random card(B)
                cards[tempValue] = placeHolder; // B card  =  (old)A Card
            }

        }

    }
}
