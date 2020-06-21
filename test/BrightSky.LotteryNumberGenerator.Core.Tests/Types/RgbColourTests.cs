using FluentAssertions;
using Xunit;

namespace BrightSky.LotteryNumberGenerator.Core.Tests.Types
{
    using Core.Types;
    using Testing;

    public class RgbColourTests
    {
        [Theory, AutoDomainData]
        public void Constructor_Given_Args_Sets_Properties(RgbValue red, RgbValue green, RgbValue blue)
        {
            // Arrange & Act
            var actual = new RgbColour(red, green, blue);

            // Assert
            actual.Red.Should().Be(red);
            actual.Green.Should().Be(green);
            actual.Blue.Should().Be(blue);
        }
    }
}