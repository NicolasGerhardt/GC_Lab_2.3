using System;
using System.Text.RegularExpressions;

namespace GC_Lab_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to the wonderful world of Regular Expressions!");
            Console.WriteLine("You will pass a string to us, and we will tell you what patterns it matches");

            do
            {
                Console.WriteLine("Boop!");
            } while (checkForExitCondition());
        }

        static void validateAsName(string s)
        {
            var pattern = "^[A-Z]{0,1}[a-z]{1-30}$";

            var matches = Regex.Match(s, pattern);

            if (matches.Length > 0)
            {
                Console.WriteLine("This Matches a name");
            }
        }

        static bool checkForExitCondition()
        {
            while (true)
            {
                Console.Write("\nDo you want to go around again? (y/n): ");
                var keyPressed = Console.ReadKey();
                Console.WriteLine();

                if (keyPressed.KeyChar.ToString().ToLower() == "y")
                {
                    Console.WriteLine("\nSounds good! Lets Go!\n");
                    return true;
                }
                else if (keyPressed.KeyChar.ToString().ToLower() == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("not a valid responce");
                }
            }
        }
    }
}
