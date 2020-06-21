using System;
using System.Collections.Generic;
using System.Linq;

namespace BrightSky.LotteryNumberGenerator.Core.Types
{
    public class LotteryResult
    {
        public IEnumerable<LotteryNumber> Numbers { get; }
        public LotteryNumber BonusBall { get; }
        public bool HasBonusBall => BonusBall != null;

        public LotteryResult(IEnumerable<LotteryNumber> numbers, LotteryNumber bonusBall)
        {
            if (numbers is null || !numbers.Any())
                throw new ArgumentException(nameof(numbers), $"{nameof(numbers)} cannot be null or empty.");

            Numbers = numbers;
            BonusBall = bonusBall;
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            return obj is LotteryResult other
                && Numbers == other.Numbers
                && BonusBall == other.BonusBall
                && HasBonusBall == other.HasBonusBall;
        }

        public override int GetHashCode()
            => HashCode.Combine(
                Numbers.GetHashCode(),
                BonusBall.GetHashCode(),
                HasBonusBall.GetHashCode());

        public static bool operator ==(LotteryResult a, LotteryResult b)
        {
            if (a is null && b is null)
                return true;
            if (a is null || b is null)
                return false;
            return a.Equals(b);
        }

        public static bool operator !=(LotteryResult a, LotteryResult b)
            => !(a == b);

        public override string ToString()
            => $"{string.Join(" ", Numbers)} {HasBonusBall} {BonusBall}";
    }
}