using System;
using System.Collections.Generic;
using System.Linq;

namespace BrightSky.LotteryNumberGenerator.Core
{
    using Contracts;
    using Types;

    public class LotteryNumberGenerator : ILotteryNumberGenerator
    {
        public IEnumerable<LotteryNumber>
            Generate(MinLotteryNumber min, MaxLotteryNumber max, LotteryLength length)
        {
            if (min is null)
                throw new ArgumentNullException(nameof(min));
            if (max is null)
                throw new ArgumentNullException(nameof(max));
            if (length is null)
                throw new ArgumentNullException(nameof(length));

            var random = new Random();
            var numbers = Enumerable.Range(min, max)
                .OrderBy(x => random.Next())
                .Take(length)
                .ToList();

            numbers.Sort();

            return numbers.Select(x => new LotteryNumber(x));
        }
    }
}