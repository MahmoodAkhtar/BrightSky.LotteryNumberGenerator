using System;

namespace BrightSky.LotteryNumberGenerator.Core.Types
{
    public class RgbValue
    {
        public int Value { get; }

        public RgbValue(int value)
        {
            if (value < 0 || value > 255)
                throw new ArgumentOutOfRangeException(nameof(value), $"{value} must be in the range of 0 - 255 only.");

            Value = value;
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            return obj is RgbValue other
                && Value == other.Value;
        }

        public override int GetHashCode()
            => Value.GetHashCode();

        public static bool operator ==(RgbValue a, RgbValue b)
        {
            if (a is null && b is null)
                return true;
            if (a is null || b is null)
                return false;
            return a.Equals(b);
        }

        public static bool operator !=(RgbValue a, RgbValue b)
            => !(a == b);

        public override string ToString()
            => Value.ToString();
    }
}