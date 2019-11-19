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
            public int SuitValue;
            public int RandomCardValue;

            public string[] Suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            public int[] Values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            public Card()
            {
                Random newCard = new Random();
                this.CardValue = newCard.Next(1, 14);
                this.CardValue = newCard.Next(0, 4);
                Console.WriteLine(CardValue);
                Console.WriteLine(SuitValue);
            }

            public Card(int RandomCardValue)
            {
                Random randomCardValue = new Random();
                this.RandomCardValue = randomCardValue.Next(1, 14);
                //Console.WriteLine("randomCardValue: {0}", randomCardValue);
                Console.WriteLine("RandomCardValue: {0}", RandomCardValue);
            }

            public Card(int CardValue, int SuitValue)
            {
                this.CardValue = CardValue;
                this.SuitValue = SuitValue;

            }
        }

        static void Main(string[] args)
        {

            var card = new Card();
            var cards = new Card(10);

            Console.ReadLine();
        }
    }
}
