using System;

namespace BrightSky.LotteryNumberGenerator.Core.Types
{
    public class Green : Colour
    {
        public Green() : base(
            new HexColour("#008000"),
            new RgbColour(new RgbValue(0), new RgbValue(128), new RgbValue(0)),
            new ConsoleColour(ConsoleColor.Green))
        {
        }
    }
}