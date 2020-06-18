using System;
using System.Collections.Generic;
using System.Linq;

namespace BrightSky.LotteryNumberGenerator.Core
{
    public class Generator
    {
        public List<int> GenerateNumbers(int min, int max, int number)
        {
            var random = new Random();
            var numbers = Enumerable.Range(min, max).OrderBy(x => random.Next()).Take(number).ToList();
            numbers.Sort();
            return numbers;
        }

        public static Colour GetBackgroundColour(int number)
        {
            if (number >= 1 && number <= 9)
                return Colour.Gray;

            if (number >= 10 && number <= 19)
                return Colour.Blue;

            if (number >= 20 && number <= 29)
                return Colour.Pink;

            if (number >= 30 && number <= 39)
                return Colour.Green;

            if (number >= 40 && number <= 49)
                return Colour.Yellow;

            return Colour.Unknown;
        }
    }
}