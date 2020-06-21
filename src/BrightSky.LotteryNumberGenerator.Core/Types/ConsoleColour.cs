using System;

namespace BrightSky.LotteryNumberGenerator.Core.Types
{
    public class ConsoleColour
    {
        public ConsoleColor Value { get; }

        public ConsoleColour(ConsoleColor value)
        {
            if (!Enum.IsDefined(typeof(ConsoleColor), value))
                throw new ArgumentOutOfRangeException(nameof(value), $"{value} must exist as a valid {nameof(ConsoleColor)}.");

            Value = value;
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            return obj is ConsoleColour other
                && Value == other.Value;
        }

        public override int GetHashCode()
            => Value.GetHashCode();

        public static bool operator ==(ConsoleColour a, ConsoleColour b)
        {
            if (a is null && b is null)
                return true;
            if (a is null || b is null)
                return false;
            return a.Equals(b);
        }

        public static bool operator !=(ConsoleColour a, ConsoleColour b)
            => !(a == b);

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}