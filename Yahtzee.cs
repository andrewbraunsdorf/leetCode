using System;
using System.Collections.Generic;

namespace Yahtzee
{
    class Die
    {
        public int Sides;
        public int SideDisplayed;
        public List<Die> dice = new List<Die>();

        public Die()
        {
            Random rnd = new Random();
            this.Sides = 6;
            this.SideDisplayed = rnd.Next(1, 6);
        }

        public Die(int sideDisplayed)
        {

            this.SideDisplayed = sideDisplayed;
        }

        public List<Die> Dice(int count)
        {
            for (int number = 1; number < count; number++)
            {
                Die die = new Die();
                dice.Add(die);
            }
            return dice;
        }
    }

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
