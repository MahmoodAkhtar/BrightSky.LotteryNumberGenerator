using AutoFixture;

namespace BrightSky.LotteryNumberGenerator.Core.Tests.Testing
{
    internal class TypesCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(new RgbValueSpecimenBuilder());
        }
    }
}