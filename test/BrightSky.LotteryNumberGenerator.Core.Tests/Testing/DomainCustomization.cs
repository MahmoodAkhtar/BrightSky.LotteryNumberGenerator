using AutoFixture;
using AutoFixture.AutoNSubstitute;

namespace BrightSky.LotteryNumberGenerator.Core.Tests.Testing
{
    internal class DomainCustomization : CompositeCustomization
    {
        public DomainCustomization() : base(
            new AutoNSubstituteCustomization(),
            new TypesCustomization())
        {
        }
    }
}