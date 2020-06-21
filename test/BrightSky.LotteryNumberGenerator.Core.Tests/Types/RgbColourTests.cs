using FluentAssertions;
using System;
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

        [Theory, AutoDomainData]
        public void Constructor_Given_Null_Red_Arg_Throws_ArgumentNullExpection(RgbValue red, RgbValue green, RgbValue blue)
        {
            // Arrange
            red = null;

            Action act = () => new RgbColour(red, green, blue);

            // Act & Assert
            act.Should().Throw<ArgumentNullException>();
        }

        [Theory, AutoDomainData]
        public void Constructor_Given_Null_Green_Arg_Throws_ArgumentNullExpection(RgbValue red, RgbValue green, RgbValue blue)
        {
            // Arrange
            green = null;

            Action act = () => new RgbColour(red, green, blue);

            // Act & Assert
            act.Should().Throw<ArgumentNullException>();
        }

        [Theory, AutoDomainData]
        public void Constructor_Given_Null_Blue_Arg_Throws_ArgumentNullExpection(RgbValue red, RgbValue green, RgbValue blue)
        {
            // Arrange
            blue = null;

            Action act = () => new RgbColour(red, green, blue);

            // Act & Assert
            act.Should().Throw<ArgumentNullException>();
        }

        [Theory, AutoDomainData]
        public void Two_Objects_Given_Same_Constructor_Args_Should_Be_Equal(RgbValue red, RgbValue green, RgbValue blue)
        {
            // Arrange & Act
            var a = new RgbColour(red, green, blue);
            var b = new RgbColour(red, green, blue);

            // Assert
            a.Should().Be(b);
        }

        [Theory, AutoDomainData]
        public void ToString_Should_Be_Correct_Format(RgbColour colour)
        {
            // Arrange
            var expected = $"rgb({colour.Red}, {colour.Green}, {colour.Blue})";

            // Act & Assert
            colour.ToString().Should().Be(expected);
        }
    }
}