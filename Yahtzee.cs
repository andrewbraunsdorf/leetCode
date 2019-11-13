using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Die
    {
        public int Sides;
        public int SideDisplayed;
        public List<Die> = new List<Die>();

        Random rnd = new Random();
        public Die(int sides)
        {
            this.Sides = sides;
            this.SideDisplayed = rnd.Next(1, sides);
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
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine();
            //Console.ReadLine();

        }
    }
}
