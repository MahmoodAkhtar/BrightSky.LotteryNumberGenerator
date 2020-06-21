using System;

namespace BrightSky.LotteryNumberGenerator.Core.Types
{
    public abstract class Colour
    {
        public string HexColour { get; }
        public string RgbColour { get; }
        public ConsoleColor ConsoleColor { get; }

        protected Colour(HexColour hexColour, RgbColour rgbColour, ConsoleColour consoleColour)
        {
            if (hexColour is null)
                throw new ArgumentNullException(nameof(hexColour));
            if (rgbColour is null)
                throw new ArgumentNullException(nameof(rgbColour));
            if (consoleColour is null)
                throw new ArgumentNullException(nameof(consoleColour));

            HexColour = hexColour.Value;
            RgbColour = rgbColour.ToString();
            ConsoleColor = consoleColour.Value;
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            return obj is Colour other
                && HexColour == other.HexColour
                && RgbColour == other.RgbColour
                && ConsoleColor == other.ConsoleColor;
        }

        public override int GetHashCode()
            => HashCode.Combine(
                HexColour.GetHashCode(),
                RgbColour.GetHashCode(),
                ConsoleColor.GetHashCode());

        public static bool operator ==(Colour a, Colour b)
        {
            if (a is null && b is null)
                return true;
            if (a is null || b is null)
                return false;
            return a.Equals(b);
        }

        public static bool operator !=(Colour a, Colour b)
            => !(a == b);

        public override string ToString()
            => $"{HexColour}, {RgbColour}, {ConsoleColor}";

        public static Gray Gray => new Gray();
        public static Blue Blue => new Blue();
        public static Pink Pink => new Pink();
        public static Green Green => new Green();
        public static Yellow Yellow => new Yellow();
        public static Black Black => new Black();
    }
}