using System;

namespace BrightSky.LotteryNumberGenerator.Core.Types
{
    public static class LotteryNumberExtensions
    {
        public static bool IsInRange(this LotteryNumber number, LotteryNumber min, LotteryNumber max)
            => number >= min && number <= max;

        public static Colour ToColour(this LotteryNumber number)
        {
            if (number.IsInRange(1, 9))
                return Colour.Gray;
            if (number.IsInRange(10, 19))
                return Colour.Blue;
            if (number.IsInRange(20, 29))
                return Colour.Pink;
            if (number.IsInRange(30, 39))
                return Colour.Green;
            if (number.IsInRange(40, 49))
                return Colour.Yellow;

            // This exception should never be reached, however it is
            // required to prevent the compiler from complaining and
            // incase the LotteryNumber class is modified to cause
            // execution to reach this far at runtime.
            throw new InvalidOperationException($"Unable to transalate the {nameof(LotteryNumber)} {number} into a {nameof(Colour)}.");
        }

        public static string ToRgbColour(this LotteryNumber number)
            => number.ToColour().RgbColour;

        public static string ToHexColour(this LotteryNumber number)
            => number.ToColour().HexColour;

        public static ConsoleColor ToConsoleColor(this LotteryNumber number)
            => number.ToColour().ConsoleColor;
    }
}