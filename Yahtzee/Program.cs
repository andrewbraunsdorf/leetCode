using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{

    class Game
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

        public string Input()
        {
            Console.Write("Choose: ");
            for (int option = 0; option < playersDice.Count; option++)
            {
                Console.Write("{0} ", option);
            }

            Console.WriteLine("Choose Dice to re-roll");
            string choice = Console.ReadLine();

            return choice;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Play();

        }
    }
}

