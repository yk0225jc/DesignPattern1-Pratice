//Written By Jiameng Zhou
//04/04/2021
using System;
using System.Collections.Generic;

namespace TestPart3
{
    public class Program
    {
        static void Main(string[] args)
        {

            Deck aDeck = Deck.GetDeck();
            //OldCardFactory
            //OldCardFactory oldCardFactory = new OldCardFactory();
            //oldCardFactory.Create();

            //New Card Factory
            NewCardFactory aNewDeckAssembly = new NewCardFactory();
            aNewDeckAssembly.Create();
            Console.WriteLine("Regular Deck : ");
            Console.WriteLine(aDeck.ToString());

            //Shuffle the cards
            Console.WriteLine("********************************************************");
            Console.WriteLine("Shuffle Deck : ");
            aDeck.Shuffle();
            Console.WriteLine(aDeck.ToString());
            //Create Player 1 and Plyaer 2
            Player player1 = new Player();
            Player player2 = new Player();
            List<Card> player1Hand = player1.GetHand();
            List<Card> player2Hand = player2.GetHand();
            //Player1 and 2 each draw 5 cards
            player1Hand = aDeck.Deal();
            player2Hand = aDeck.Deal();

            //Player 1 Card
            Console.WriteLine("Player 1 Card Below: ");
            foreach(Card card in player1Hand)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine("\n");

            //Player 2 Card
            Console.WriteLine("Player 2 Card Below: ");
            foreach (Card card in player2Hand)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine("\n");

            //Get the ScoreBoard
            Scoreboard aScoreBoard = Scoreboard.GetScoreBoard();
            int playerOnePoint = aScoreBoard.player1Points;
            int playerTwoPoint = aScoreBoard.player2Points;



            //Play all five cards
            while (player1Hand.Count !=0 & player2Hand.Count != 0)
            {
                //Player 1 can pick a card from the deck 
                PlayerPicksStrategy playerOneStr = new PlayerPicksStrategy();
                Card player1Card = player1.PlayCard(playerOneStr);//Card going to be played
                foreach(Card card in player1Hand) 
                {
                    if(card == player1Card)// find the same card in the player 1 hand, and remove from hand
                    {
                        player1Hand.Remove(card);
                    }
                }

                //Player 2(Computer) will randomly select a card 
                //RandomPickStrategy playerTwoStr = new RandomPickStrategy();
                //WeakestFirstStrategy playerTwoStr = new WeakestFirstStrategy();
                WeakThenStrongStrategy playerTwoStr = new WeakThenStrongStrategy();
                Card player2Card = player2.PlayCard(playerTwoStr);
                foreach(Card card in player2Hand)
                {
                    if (card == player2Card)
                    {
                        player1Hand.Remove(card);
                    }
                }

                if (player1Card.value > player2Card.value)
                {
                    playerOnePoint += 1;
                }
                else if (player1Card.value < player2Card.value)
                {
                    playerTwoPoint += 1;
                }
                else if (player1Card.value == player2Card.value)
                {
                    continue;
                }
            }
            //Determine who have more points. 
            if (playerOnePoint > playerTwoPoint)
            {
                Console.WriteLine("Player 1 Won!");
            }
            else if (playerTwoPoint > playerOnePoint)
            {
                Console.WriteLine("Player 2 Won!");
            }
            else
            {
                Console.WriteLine("Player 1 and Player 2 tie");
            }

            Console.ReadLine();



        }
    }
}
