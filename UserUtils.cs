using System;

namespace AquariumSimulation
{
    public class UserUtils
    {
        public static int GetNumber(string text)
        {
            int number;

            Console.Write(text);

            while (int.TryParse(Console.ReadLine(), out number) == false)
            {
                Console.WriteLine($"\nCan't convert to {nameof(Int32)}. Try again");
                Console.Write(text);
            }

            return number;
        }

        public static void WaitForClick(string text = "\nPress any key to continue... ")
        {
            Console.Write(text);
            Console.ReadKey(true);
        }
    }
}
