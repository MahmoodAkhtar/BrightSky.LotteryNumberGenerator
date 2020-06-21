using System;

namespace BrightSky.LotteryNumberGenerator.Core.Types
{
    public class LotteryDefinition
    {
        public MinLotteryNumber Min { get; }
        public MaxLotteryNumber Max { get; }
        public LotteryLength Length { get; }

        public LotteryDefinition(MinLotteryNumber min, MaxLotteryNumber max, LotteryLength length)
        {
            Min = min ?? throw new ArgumentNullException(nameof(min));
            Max = max ?? throw new ArgumentNullException(nameof(max));
            Length = length ?? throw new ArgumentNullException(nameof(length));
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            return obj is LotteryDefinition other
                && Min == other.Min
                && Max == other.Max
                && Length == other.Length;
        }

        public override int GetHashCode()
            => HashCode.Combine(
                Min.GetHashCode(),
                Max.GetHashCode(),
                Length.GetHashCode());

        public static bool operator ==(LotteryDefinition a, LotteryDefinition b)
        {
            if (a is null && b is null)
                return true;
            if (a is null || b is null)
                return false;
            return a.Equals(b);
        }

        public static bool operator !=(LotteryDefinition a, LotteryDefinition b)
            => !(a == b);

        public override string ToString()
            => $"{Min} {Max}";
    }
}