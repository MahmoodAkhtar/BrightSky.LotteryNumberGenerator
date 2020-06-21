using System;

namespace BrightSky.LotteryNumberGenerator.Core.Types
{
    public class LotteryRun
    {
        public bool IncludeBonusBall { get; }

        public LotteryRun(bool includeBonusBall = false)
        {
            IncludeBonusBall = includeBonusBall;
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            return obj is LotteryRun other
                && IncludeBonusBall == other.IncludeBonusBall;
        }

        public override int GetHashCode()
            => HashCode.Combine(
                IncludeBonusBall.GetHashCode());

        public static bool operator ==(LotteryRun a, LotteryRun b)
        {
            if (a is null && b is null)
                return true;
            if (a is null || b is null)
                return false;
            return a.Equals(b);
        }

        public static bool operator !=(LotteryRun a, LotteryRun b)
            => !(a == b);

        public override string ToString()
            => $"{IncludeBonusBall}";
    }
}