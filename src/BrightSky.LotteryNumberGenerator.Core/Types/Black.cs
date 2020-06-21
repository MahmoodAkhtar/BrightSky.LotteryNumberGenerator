using System;

namespace BrightSky.LotteryNumberGenerator.Core.Types
{
    public class Black : Colour
    {
        public Black() : base(
            new HexColour("#000000"),
            new RgbColour(new RgbValue(0), new RgbValue(0), new RgbValue(0)),
            new ConsoleColour(ConsoleColor.Black))
        {
        }
    }
}