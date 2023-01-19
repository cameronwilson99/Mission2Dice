using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] dice = new int[11];

            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.Write("How many dice rolls would you like to simulate?\t");
            int numRolls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = " + numRolls.ToString() + ".\n");

            for (int i = 0; i < numRolls; i++)
            {
                int roll1 = r.Next(6);
                int roll2 = r.Next(6);

                int total = roll1 + roll2;

                dice[total]++;
            }

            for (int i = 0; i < 11; i++)
            {
                double percentage = dice[i] / Convert.ToDouble(numRolls) * 100;
                int numberResults = Convert.ToInt32(percentage);
                Console.Write(i+2 + ":\t");

                for (int j = 0; j < numberResults; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
