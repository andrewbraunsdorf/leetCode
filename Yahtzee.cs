using System;

namespace Yahtzee
{
 
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 7);

            Console.WriteLine(dice);
            Console.ReadLine();

        }
    }
}
