//Written by Jiameng Zhou
//04/05/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPart3
{
    public class WeakestFirstStrategy : IStrategy
    {
        Player aPlayer = new Player();
        int cardValue = 100;
        int loopCounter = 0;
        int cardPlaceHolder;
        int indexHolder;
        public Card PlayCard()
        {
            List<Card> cards = aPlayer.GetHand();
            foreach (Card card in cards)
            {
                //If curreent card value is larger than the new card value, 
                //then the current value become the new card value.
                if (cardValue >= card.value)
                {
                    cardPlaceHolder = cardValue;//hold the current value
                    cardValue = card.value;//current value = new card value
                    indexHolder = loopCounter; // grab the new card index
                }

                loopCounter += 1;
            }
            return cards[indexHolder];
        }
    }
}
