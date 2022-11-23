using System;
using System.Collections;

namespace Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            dice.Sides = 6;
            dice.Roll();

            Dice dice2 = new Dice();
            dice2.Sides = 6;
            dice.Roll();
            
        }
    }


    public class Dice
    {

        public int Sides { get; set; } 

        public void Roll()
        {
            Random random = new Random();
            int rng = random.Next(1, Sides + 1);
            Console.WriteLine(rng);
        }
    }
}
