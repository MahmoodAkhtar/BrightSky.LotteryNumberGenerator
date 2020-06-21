namespace BrightSky.LotteryNumberGenerator.Core.Types
{
    public class LotteryLength : LotteryNumber
    {
        public LotteryLength() : this(6)
        {
        }

        public LotteryLength(int value) : base(value)
        {
        }
    }
}