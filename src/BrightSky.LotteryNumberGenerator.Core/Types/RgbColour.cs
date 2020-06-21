using System;

namespace BrightSky.LotteryNumberGenerator.Core.Types
{
    public class RgbColour
    {
        public RgbValue Red;
        public RgbValue Green;
        public RgbValue Blue;

        public RgbColour(RgbValue red, RgbValue green, RgbValue blue)
        {
            Red = red ?? throw new ArgumentNullException(nameof(red));
            Green = green ?? throw new ArgumentNullException(nameof(green));
            Blue = blue ?? throw new ArgumentNullException(nameof(blue));
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            return obj is RgbColour other
                && Red == other.Red
                && Green == other.Green
                && Blue == other.Blue;
        }

        public override int GetHashCode()
            => HashCode.Combine(Red, Green, Blue);

        public static bool operator ==(RgbColour a, RgbColour b)
        {
            if (a is null && b is null)
                return true;
            if (a is null || b is null)
                return false;
            return a.Equals(b);
        }

        public static bool operator !=(RgbColour a, RgbColour b)
            => !(a == b);

        public override string ToString()
        {
            return $"rgb({Red}, {Green}, {Blue})";
        }
    }
}