using System;

namespace BrightSky.LotteryNumberGenerator.Core.Types
{
    public class Yellow : Colour
    {
        public Yellow() : base(
            new HexColour("#FFFF00"),
            new RgbColour(new RgbValue(255), new RgbValue(255), new RgbValue(0)),
            new ConsoleColour(ConsoleColor.Yellow))
        {
        }
    }
}