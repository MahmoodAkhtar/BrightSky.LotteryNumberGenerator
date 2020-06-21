using System;

namespace BrightSky.LotteryNumberGenerator.Core.Types
{
    public class Pink : Colour
    {
        public Pink() : base(
            new HexColour("#FFC0CB"),
            new RgbColour(new RgbValue(255), new RgbValue(182), new RgbValue(193)),
            // There is no ConsoleColor.Pink therefore using Magenta as best alternative.
            new ConsoleColour(ConsoleColor.Magenta))
        {
        }
    }
}