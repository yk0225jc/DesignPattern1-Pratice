//Written By Jiameng Zhou
//04/04/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPart3
{
    public class PlayerPicksStrategy : IStrategy
    {
        Player aPlayer = new Player();
        public Card PlayCard()
        {
            List<Card> hand = aPlayer.GetHand();
            Console.WriteLine("Please Pick a card that you want to play, choose a index number between 1 - " + hand.Count);
            int userChoice = Console.Read();
            return hand[userChoice];
        }


    }
}

