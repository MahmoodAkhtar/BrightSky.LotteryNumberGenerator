using System;

namespace BrightSky.LotteryNumberGenerator.Core.Types
{
    public class Gray : Colour
    {
        public Gray() : base(
            new HexColour("#808080"),
            new RgbColour(new RgbValue(128), new RgbValue(128), new RgbValue(128)),
            new ConsoleColour(ConsoleColor.Gray))
        {
        }
    }
}