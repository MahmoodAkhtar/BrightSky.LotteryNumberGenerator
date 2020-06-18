using System;
using System.Collections.Generic;

namespace BrightSky.LotteryNumberGenerator.Cli
{
    using Core;

    internal class Program
    {
        private const string _question = "How many lottery numbers do you want?: ";
        private const string _hint = "(Hint: 6 or 7)";
        private const string _error = "Oops something went wrong! Please try again...";

        private static void Main(string[] args)
        {
            Console.WriteLine("Lottery Number Generator");
            Console.WriteLine("========================");
            Console.WriteLine(_question);
            Console.WriteLine(_hint);
            string input = Console.ReadLine();
            int number;
            var valid = int.TryParse(input, out number);

            while (!valid)
            {
                Console.WriteLine(_error);
                Console.WriteLine(_question);
                Console.WriteLine(_hint);
                input = Console.ReadLine();
                valid = int.TryParse(input, out number);
            }

            var generator = new Generator();
            DisplayNumbers(generator.GenerateNumbers(1, 49, number));
            Console.ReadLine();
        }

        private static void DisplayNumbers(List<int> numbers)
        {
            Console.Write("Your 'Lottery Numbers' are: ");

            foreach (var number in numbers)
            {
                var colour = Generator.GetBackgroundColour(number);
                switch (colour)
                {
                    case Colour.Gray:
                        Console.BackgroundColor = ConsoleColor.Gray;
                        break;

                    case Colour.Blue:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;

                    case Colour.Pink:
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        break;

                    case Colour.Green:
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;

                    case Colour.Yellow:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write($" {number} ");
            }

            Console.ResetColor();
        }
    }
}