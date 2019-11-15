using System;
using System.Collections.Generic;

namespace Yahtzee
{
    class Die
    {
        public int Sides;
        public int SideDisplayed;
        public List<Die> dice = new List<Die>();

        Random rnd = new Random();
        public Die(int sides)
        {
            this.Sides = sides;
            this.SideDisplayed = rnd.Next(1, sides);
            //int randomDice1 = rnd.Next(1, 7);
            //int randomDice2 = rnd.Next(1, 7);
            //int randomDice3 = rnd.Next(1, 7);
            //int randomDice4 = rnd.Next(1, 7);
            //int randomDice5 = rnd.Next(1, 7);

            //Console.WriteLine(randomDice1);
            //Console.WriteLine(randomDice2);
            //Console.ReadLine();
        }

        public Die(int Sides, int sideDisplayed)
        {
            this.SideDisplayed = sideDisplayed;
        }

        public void Roll()
        {
            this.SideDisplayed = rnd.Next(1, this.Sides);
        }


    }
}