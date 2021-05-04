//Written by Jiameng Zhou
//04/05/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPart3
{
    public class WeakThenStrongStrategy : IStrategy
    {
        Player aPlayer = new Player();
        int cardValue1 = 100;// for find the smallest value
        int loopCounter = 0;
        int cardPlaceHolder;
        int indexHolder;

        int cardValue2 = 0;
        int cardPlaceHolder2;
        int loopCounter2 = 0;

        public Card PlayCard()
        {
            List<Card> cards = aPlayer.GetHand();

            //If player have >= 4 cards, then return the weakest card
            if(cards.Count >= 4)
            {
                foreach(Card card in cards)
                {
                    //If curreent card value is larger than the new card value, 
                    //then the current value become the new card value.
                    if (cardValue1 >= card.value)
                    {
                        cardPlaceHolder = cardValue1;//hold the current value
                        cardValue1 = card.value;//current value = new card value
                        indexHolder = loopCounter; // grab the new card index
                    } 
                    
                    loopCounter += 1;
                }
                return cards[indexHolder];
            }
            //If player have less than 4 card, then return the strongest card.
            else 
            {
                foreach(Card card in cards)
                {
                    //If the current card value is less than the new card value,
                    // then the current card value become the new card value.
                    if(cardValue2 < card.value)
                    {
                        cardPlaceHolder2 = cardValue2;//hold the current card value
                        cardValue2 = card.value; //current card = new card value
                        indexHolder = loopCounter2;//grab the index of that new card
                        

                    }

                    loopCounter2 += 1;
                }
                return cards[indexHolder];
            }


            
        }
    }
}
