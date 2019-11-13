using System;
using System.Collections.Generic;

namespace Yahtzee
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Die die = new Die();

            List<Die> dice = die.Dice(6);

            foreach (var pips in dice)
                Console.WriteLine(pips.SideDisplayed);
            Console.ReadLine();

        }
    }
}
