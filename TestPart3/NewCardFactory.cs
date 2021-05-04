using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPart3
{
    public class NewCardFactory : IDeckOfCards
    {
        Deck aDeck = Deck.GetDeck();

        public void Create()
        {
            List<Card> cards = aDeck.GetCards();
            //Heart Cards
            cards.Add(new Card("Ace", 14, "Hearts"));
            cards.Add(new Card("Two", 15, "Hearts"));
            cards.Add(new Card("Three",16, "Hearts"));
            cards.Add(new Card("Four", 17, "Hearts"));
            cards.Add(new Card("Five", 18, "Hearts"));
            cards.Add(new Card("Six", 19, "Hearts"));
            cards.Add(new Card("Seven", 20, "Hearts"));
            cards.Add(new Card("Eight", 21, "Hearts"));
            cards.Add(new Card("Nine", 22, "Hearts"));
            cards.Add(new Card("Ten", 23, "Hearts"));
            cards.Add(new Card("Jack", 24, "Hearts"));
            cards.Add(new Card("Queen", 25, "Hearts"));
            cards.Add(new Card("King", 26, "Hearts"));
            //Diamonds Cards
            cards.Add(new Card("Ace", 1, "Diamonds"));
            cards.Add(new Card("Two", 2, "Diamonds"));
            cards.Add(new Card("Three", 3, "Diamonds"));
            cards.Add(new Card("Four", 4, "Diamonds"));
            cards.Add(new Card("Five", 5, "Diamonds"));
            cards.Add(new Card("Six", 6, "Diamonds"));
            cards.Add(new Card("Seven", 7, "Diamonds"));
            cards.Add(new Card("Eight", 8, "Diamonds"));
            cards.Add(new Card("Nine", 9, "Diamonds"));
            cards.Add(new Card("Ten", 10, "Diamonds"));
            cards.Add(new Card("Jack", 11, "Diamonds"));
            cards.Add(new Card("Queen", 12, "Diamonds"));
            cards.Add(new Card("King", 13, "Diamonds"));
            //Club Cards
            cards.Add(new Card("Ace", 1, "Clubs"));
            cards.Add(new Card("Two", 2, "Clubs"));
            cards.Add(new Card("Three", 3, "Clubs"));
            cards.Add(new Card("Four", 4, "Clubs"));
            cards.Add(new Card("Five", 5, "Clubs"));
            cards.Add(new Card("Six", 6, "Clubs"));
            cards.Add(new Card("Seven", 7, "Clubs"));
            cards.Add(new Card("Eight", 8, "Clubs"));
            cards.Add(new Card("Nine", 9, "Clubs"));
            cards.Add(new Card("Ten", 10, "Clubs"));
            cards.Add(new Card("Jack", 11, "Clubs"));
            cards.Add(new Card("Queen", 12, "Clubs"));
            cards.Add(new Card("King", 13, "Clubs"));
            //Spade Cards
            cards.Add(new Card("Ace", 1, "Spades"));
            cards.Add(new Card("Two", 2, "Spades"));
            cards.Add(new Card("Three", 3, "Spades"));
            cards.Add(new Card("Four", 4, "Spades"));
            cards.Add(new Card("Five", 5, "Spades"));
            cards.Add(new Card("Six", 6, "Spades"));
            cards.Add(new Card("Seven", 7, "Spades"));
            cards.Add(new Card("Eight", 8, "Spades"));
            cards.Add(new Card("Nine", 9, "Spades"));
            cards.Add(new Card("Ten", 10, "Spades"));
            cards.Add(new Card("Jack", 11, "Spades"));
            cards.Add(new Card("Queen", 12, "Spades"));
            cards.Add(new Card("King", 13, "Spades"));


            //Console.WriteLine(aDeck.ToString());
        }
    }
}
