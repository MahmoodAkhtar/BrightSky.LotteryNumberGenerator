using BrightSky.LotteryNumberGenerator.Core.Types;
using System.Collections.Generic;

namespace BrightSky.LotteryNumberGenerator.Core.Contracts
{
    public interface ILotteryNumberGenerator
    {
        IEnumerable<LotteryNumber> Generate(MinLotteryNumber min, MaxLotteryNumber max, LotteryLength length);
    }
}