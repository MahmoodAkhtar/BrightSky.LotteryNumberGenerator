using AutoFixture;
using AutoFixture.Xunit2;

namespace BrightSky.LotteryNumberGenerator.Core.Tests.Testing
{
    public class AutoDomainDataAttribute : AutoDataAttribute
    {
        public AutoDomainDataAttribute()
            : base(() => new Fixture().Customize(new DomainCustomization()))
        {
        }
    }
}