using AutoFixture.Kernel;
using System;

namespace BrightSky.LotteryNumberGenerator.Core.Tests.Testing
{
    using Core.Types;

    internal class RgbValueSpecimenBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            var type = request as Type;
            if (type == null)
                return new NoSpecimen();
            if (type != typeof(RgbValue))
                return new NoSpecimen();

            return new RgbValue(new Random().Next(0, 255));
        }
    }
}