using System;
using System.Collections.Generic;

namespace Yahtzee
{
   class game
    {
        public List<Die> playersDice = new List<Die>();

        public void Play()
        {
            for (int diceRoll = 0; diceRoll < 5; diceRoll++)
            {
                playersDice.Add(new Die(6));
            }
        }

        public void Roll()
        {
            for (int rollNumber = 0; rollNumber < playersDice.Count; rollNumber++)
            {
                playersDice[rollNumber].Roll();

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // array of rolls
            // list of dice

            // Console.WriteLine();
            Console.ReadLine();

        }
    }
}
