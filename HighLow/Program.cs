using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Program
    {
        public class Card
        {

            public int CardValue;
            public int CardSuit;
            public int RandomCardValue;

            public string[] Suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            public int[] Values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            public Card()
            {
                Random newCard = new Random();
                this.CardValue = newCard.Next(1, 14);
                this.CardSuit = newCard.Next(0, 4);
                Console.WriteLine("Card: {0}", CardValue);
                Console.WriteLine("Suit: {0}", CardSuit);
            }

            public Card(int RandomCardValue)
            {
                Random randomCardValue = new Random();
                this.RandomCardValue = randomCardValue.Next(1, 14);
                //Console.WriteLine("randomCardValue: {0}", randomCardValue);
                Console.WriteLine("RandomCardValue: {0}", RandomCardValue);
            }

            public Card(int CardValue, int CardSuit)
            {
                this.CardValue = CardValue;
                this.CardSuit = CardSuit;

            }
        }

        public class Game
        {
            public void PlayGame()
            {
                var startingCard = new Card();
                var nextCard = new Card();

                int guesses = 0;


                Console.WriteLine("Starting Card: {0}", startingCard);
                Console.WriteLine("Next Card: {0}", nextCard);

                Console.WriteLine("{0} {1}", startingCard.CardValue, startingCard.CardSuit);
            }

            //public Card DrawCard()
            //{
            //    Card startingCard = new Card();
            //    Console.WriteLine("Starting Card: {0}", startingCard);
            //    return startingCard;
            //}
        }

        static void Main(string[] args)
        {

            var card = new Card();
            var cards = new Card(10);
            var game = new Game();

            Console.ReadLine();
        }
    }
}
