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
                Console.Write("Give us a string of characters to test: ");
                var userInput = Console.ReadLine();
                Console.WriteLine($"\nExcellent we will test \"{userInput}\" against our tests!\n");

                validateAsName(userInput);

            } while (checkForLoopCondition());
        }

        static void validateAsName(string s)
        {
            var pattern = "^[A-Z]?[a-z]+ ?[A-Z]?[a-z]*$";

            var match = Regex.Match(s, pattern);

            if (match.Length > 0)
            {
                writeGreen("This matches our name pattern!");
                Console.WriteLine(match);
            }
            else
            {
                writeRed("This does not match our name pattern.");
            }
            Console.WriteLine();
        }

        static void writeRed(string s)
        {
            writeColorOnce(s, ConsoleColor.Red);
        }

        static void writeGreen(string s)
        {
            writeColorOnce(s, ConsoleColor.Green);
        }

        static void writeColorOnce(string s, ConsoleColor c)
        {
            var colorToReturnTo = Console.ForegroundColor;
            Console.ForegroundColor = c;
            Console.WriteLine(s);
            Console.ForegroundColor = colorToReturnTo;
        }

        static bool checkForLoopCondition()
        {
            while (true)
            {
                Console.Write("\nDo you want to test another string? (y/n): ");
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
