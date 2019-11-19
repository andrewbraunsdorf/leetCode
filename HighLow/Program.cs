using System;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random newCard = new Random();
            int randomCard = newCard.Next(1, 14);
            Console.WriteLine(randomCard);
            Console.ReadLine();
        }
    }
}
