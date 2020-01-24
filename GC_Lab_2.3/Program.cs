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
                validateAsEmail(userInput);
                validateAsPhoneNumber(userInput);
                validateAsDate(userInput);
                validateAsHTML(userInput);


            } while (checkForLoopCondition());
        }

        static void validateAsHTML(string s)
        {
            const string name = "html";
            var pattern = @"<[A-Za-z]\w*>.*<\/[A-Za-z]\w*>";

            validateStringtoNamedRegex(s, name, pattern);
        }

        static void validateAsDate(string s)
        {
            const string name = "date";
            var pattern = @"((0?\d)|(1[012]))[\/\.\- ](\d|[012]\d|3[01])[\/\.\- ]\d{4}";

            validateStringtoNamedRegex(s, name, pattern);
        }

        static void validateAsName(string s)
        {
            const string name = "name";
            var pattern = @"([A-Z][A-Za-z'\-]*\s+){1,5}[A-Za-z'\-]*";

            validateStringtoNamedRegex(s, name, pattern);
        }

        static void validateAsPhoneNumber(string s)
        {
            const string name = "phone number";
            var pattern = @"(\d{3}.?.?){2}\d{4}";

            validateStringtoNamedRegex(s, name, pattern);
        }

        static void validateAsEmail(string s)
        {
            const string name = "email";
            var pattern = @"[A-Za-z][\w\d\+\.]*@[A-Za-z][\w\d\.]+[A-Za-z]{2,4}";

            validateStringtoNamedRegex(s, name, pattern);
        }

        static void validateStringtoNamedRegex(string s, string name, string rx)
        {
            if (Regex.IsMatch(s, rx))
            {
                writeGreen($"This matches our {name} pattern!");
            }
            else
            {
                writeRed($"This does not match our {name} pattern.");
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
            Console.WriteLine();
            while (true)
            {
                Console.Write("Do you want to test another string? (y/n): ");
                var keyPressed = Console.ReadKey();
                Console.WriteLine();

                if (keyPressed.KeyChar.ToString().ToLower() == "y")
                {
                    Console.WriteLine("Sounds good! Lets Go!\n");
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
