using System;

namespace BrightSky.LotteryNumberGenerator.Cli2
{
    using Core.Contracts;
    using Core.Types;
    using Types;

    public class App
    {
        private const string _question = "Do you want to include a bonus ball?: (y/n)";
        private const string _error = "Oops something went wrong! Please try again... expecting: 'y' or 'n'";

        private readonly ILottery _generator;

        public App(ILottery generator)
        {
            _generator = generator ?? throw new ArgumentNullException(nameof(generator));
        }

        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine(@"============================================================================");
            Console.WriteLine(@"||                                                                        ||");
            Console.WriteLine(@"||   /$$                   /$$     /$$                                    ||");
            Console.WriteLine(@"||  | $$                  | $$    | $$                                    ||");
            Console.WriteLine(@"||  | $$        /$$$$$$  /$$$$$$ /$$$$$$    /$$$$$$   /$$$$$$  /$$   /$$  ||");
            Console.WriteLine(@"||  | $$       /$$__  $$|_  $$_/|_  $$_/   /$$__  $$ /$$__  $$| $$  | $$  ||");
            Console.WriteLine(@"||  | $$      | $$  \ $$  | $$    | $$    | $$$$$$$$| $$  \__/| $$  | $$  ||");
            Console.WriteLine(@"||  | $$      | $$  | $$  | $$ /$$| $$ /$$| $$_____/| $$      | $$  | $$  ||");
            Console.WriteLine(@"||  | $$$$$$$$|  $$$$$$/  |  $$$$/|  $$$$/|  $$$$$$$| $$      |  $$$$$$$  ||");
            Console.WriteLine(@"||  |________/ \______/    \___/   \___/   \_______/|__/       \____  $$  ||");
            Console.WriteLine(@"||                                                             /$$  | $$  ||");
            Console.WriteLine(@"||   _   _                 _                                  |  $$$$$$/  ||");
            Console.WriteLine(@"||  | \ | |_   _ _ __ ___ | |__   ___ _ __                     \______/   ||");
            Console.WriteLine(@"||  |  \| | | | | '_ ` _ \| '_ \ / _ \ '__|                               ||");
            Console.WriteLine(@"||  | |\  | |_| | | | | | | |_) |  __/ |                                  ||");
            Console.WriteLine(@"||  |_|_\_|\__,_|_| |_| |_|_.__/ \___|_|                                  ||");
            Console.WriteLine(@"||   / ___| ___ _ __   ___ _ __ __ _| |_ ___  _ __                        ||");
            Console.WriteLine(@"||  | |  _ / _ \ '_ \ / _ \ '__/ _` | __/ _ \| '__|                       ||");
            Console.WriteLine(@"||  | |_| |  __/ | | |  __/ | | (_| | || (_) | |                          ||");
            Console.WriteLine(@"||   \____|\___|_| |_|\___|_|  \__,_|\__\___/|_|                          ||");
            Console.WriteLine(@"||                                                                        ||");
            Console.WriteLine(@"============================================================================");
            Console.WriteLine();

            Console.WriteLine(_question);

            string input = Console.ReadLine();
            YesNoArg yesNoArg;
            var valid = YesNoArg.TryParse(input, out yesNoArg);

            while (!valid)
            {
                Console.WriteLine(_error);
                Console.WriteLine(_question);
                input = Console.ReadLine();
                valid = YesNoArg.TryParse(input, out yesNoArg);
            }

            var includeBonusBall = yesNoArg.Value;
            var result = _generator.Run(new LotteryRun(includeBonusBall));

            Display(result);

            Console.ReadLine();
        }

        private void Display(LotteryResult result)
        {
            Console.Write("Your 'Lottery Numbers' are: ");

            var foregroundColor = Colour.Black.ConsoleColor;

            foreach (var number in result.Numbers)
            {
                var backgroundColor = number.ToConsoleColor();

                Console.BackgroundColor = backgroundColor;
                Console.ForegroundColor = foregroundColor;
                Console.Write($" {number} ");
            }

            if (result.HasBonusBall)
            {
                var backgroundColor = result.BonusBall.ToConsoleColor();

                Console.ResetColor();
                Console.Write($" and your 'Bonus Ball' is: ");
                Console.BackgroundColor = backgroundColor;
                Console.ForegroundColor = foregroundColor;
                Console.Write($" {result.BonusBall} ");
            }

            Console.ResetColor();
            Console.WriteLine();
        }
    }
}