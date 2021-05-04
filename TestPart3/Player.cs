//Written By Jiameng Zhou
//04/04/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPart3
{
    public class Player
    {
        public List<Card> hand = new List<Card>();

        public List<Card> GetHand()
        {
            return this.hand;
        }

        public Card PlayCard(IStrategy strategy)
        {
            return strategy.PlayCard();// <= this PlayCard() is method from IStrategy
                                          // Used to return different strategy
            
        }

        public override string ToString()
        {
            String s = "";
            foreach (Card card in hand)
            {
                s += card.ToString() + "\n";
            }
            return s;
        }

    }
}
