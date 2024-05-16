using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLo
{
    static class HiLoGame
    {
        public const int MAXIMUM = 10;
        static Random random = new Random();
        static int currentNumber = random.Next(1, MAXIMUM + 1);
        private static int pot = 10;

        public static int GetPot() {  return pot; }

        public static void Guess(bool higher)
        {
            int nextNumber = random.Next(1, MAXIMUM + 1);
            if ((higher && nextNumber >= currentNumber) ||
                (!higher && nextNumber <= currentNumber))
            {
                Console.WriteLine("You guessed right!");
                pot++;
            }
            else
            {
                Console.WriteLine("You guessed wrong!");
                pot--;
            }

            currentNumber = nextNumber;
            Console.WriteLine($"The current number is: {currentNumber}.");
        }

        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (currentNumber >= half)
                Console.WriteLine($"The number is at least: {half}.");
            
            else
                Console.WriteLine($"The number is the at most: {half}.");
                pot--;
            
        }
    }
}
