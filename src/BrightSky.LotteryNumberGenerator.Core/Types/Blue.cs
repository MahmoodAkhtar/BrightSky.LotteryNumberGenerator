using System;

namespace BrightSky.LotteryNumberGenerator.Core.Types
{
    public class Blue : Colour
    {
        public Blue() : base(
            new HexColour("#0000FF"),
            new RgbColour(new RgbValue(0), new RgbValue(0), new RgbValue(255)),
            new ConsoleColour(ConsoleColor.Blue))
        {
        }
    }
}