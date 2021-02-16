using System;

namespace Labstats_potato
{
    public class Labstats
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The difference between red and russett potatoes is: " + potatoLogic(-1) + " Potatoes!");
        }
        public static int potatoLogic(int num)
        {
            int num_bags;
            if (num >0 && num < 41)
            {
                num_bags = num;
            }
            else
            {
            Random rand_num = new Random();
            // get a random number between 1 and 40
            num_bags = rand_num.Next(1, 41);
            }

            int num_russett = 0;
            int num_red = 0;
            for (int i = 1; i <= num_bags; i++)
            {
                //if bag # is even, add it to red potatoes, else add it to russett
                if (i % 2 == 0)
                {
                    num_red += i * i;
                }
                else
                {
                    num_russett += i * i;
                }
            }

            //return the difference between the two potatoes, Absolute valued to avoid negatives
            return Math.Abs(num_red - num_russett);
        }
    }
}
