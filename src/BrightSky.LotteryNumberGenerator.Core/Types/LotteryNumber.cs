using System;

namespace BrightSky.LotteryNumberGenerator.Core.Types
{
    public class LotteryNumber
    {
        internal const int Min = 1;
        internal const int Max = 49;

        public int Value { get; }

        public LotteryNumber(int value)
        {
            if (value < Min || value > Max)
                throw new ArgumentOutOfRangeException(nameof(value), $"{nameof(value)} must be in the range {Min} - {Max}.");

            Value = value;
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            return obj is LotteryNumber other
                && Value == other.Value;
        }

        public override int GetHashCode()
            => Value.GetHashCode();

        public static bool operator ==(LotteryNumber a, LotteryNumber b)
        {
            if (a is null && b is null)
                return true;
            if (a is null || b is null)
                return false;
            return a.Equals(b);
        }

        public static bool operator !=(LotteryNumber a, LotteryNumber b)
            => !(a == b);

        public static implicit operator int(LotteryNumber number)
            => number.Value;

        public static implicit operator LotteryNumber(int number)
            => new LotteryNumber(number);

        public override string ToString()
            => Value.ToString();
    }
}