using BrightSky.LotteryNumberGenerator.Core.Types;

namespace BrightSky.LotteryNumberGenerator.Core.Contracts
{
    public interface ILottery
    {
        LotteryResult Run(LotteryRun run);
    }
}