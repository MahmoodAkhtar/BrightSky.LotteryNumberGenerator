using System;
using System.Collections.Generic;
using System.Linq;

namespace BrightSky.LotteryNumberGenerator.Core
{
    using Contracts;
    using Types;

    public class Lottery : ILottery
    {
        private readonly LotteryDefinition _definition;
        private readonly ILotteryNumberGenerator _generator;

        public Lottery(LotteryDefinition definition, ILotteryNumberGenerator generator)
        {
            _definition = definition ?? throw new ArgumentNullException(nameof(definition));
            _generator = generator ?? throw new ArgumentNullException(nameof(generator));
        }

        public LotteryResult Run(LotteryRun run)
        {
            if (run is null)
                throw new ArgumentNullException(nameof(run));

            var length = new LotteryLength(run.IncludeBonusBall
                ? _definition.Length + 1
                : _definition.Length);

            var (numbers, bonusBall) = (_generator.Generate(_definition.Min, _definition.Max, length), (LotteryNumber)null);

            if (run.IncludeBonusBall)
                (numbers, bonusBall) = SeparateBonusBallFromLotteryNumbers(numbers);

            return new LotteryResult(numbers, bonusBall);
        }

        private (IEnumerable<LotteryNumber>, LotteryNumber)
            SeparateBonusBallFromLotteryNumbers(IEnumerable<LotteryNumber> numbers)
        {
            var separatedNumbers = numbers.ToList();
            var bonusBallIndex = new Random().Next(separatedNumbers.Count);
            var bonusBall = separatedNumbers[bonusBallIndex];

            separatedNumbers.RemoveAt(bonusBallIndex);

            return (separatedNumbers, bonusBall);
        }
    }
}