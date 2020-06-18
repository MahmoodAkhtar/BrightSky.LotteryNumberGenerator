using FluentAssertions;
using System.Linq;
using Xunit;

namespace BrightSky.LotteryNumberGenerator.Core.Tests
{
    public class GeneratorTests
    {
        [Fact]
        public void GenerateNumbers_Should_Choose_6_Numbers()
        {
            // Arrange
            var generator = new Generator();

            // Act
            var actual = generator.GenerateNumbers(1, 49, 6);

            // Assert
            actual.Should().HaveCount(6);
        }

        [Fact]
        public void GenerateNumbers_Should_Choose_6_Numbers_In_The_Range_1_To_49_Inclusive()
        {
            // Arrange
            var generator = new Generator();

            // Act
            var actual = generator.GenerateNumbers(1, 49, 6);

            // Assert
            actual.Should().BeSubsetOf(Enumerable.Range(1, 49));
        }

        [Fact]
        public void GenerateNumbers_Should_Choose_6_Numbers_Which_Are_Unique()
        {
            // Arrange
            var generator = new Generator();

            // Act
            var actual = generator.GenerateNumbers(1, 49, 6);

            // Assert
            actual.Should().OnlyHaveUniqueItems();
        }

        [Fact]
        public void GenerateNumbers_Should_Present_6_Numbers_In_Order()
        {
            // Arrange
            var generator = new Generator();

            // Act
            var actual = generator.GenerateNumbers(1, 49, 6);

            // Assert
            actual.Should().BeInAscendingOrder(x => x);
        }

        [Fact]
        public void GenerateNumbers_Should_Choose_7_Numbers()
        {
            // Arrange
            var generator = new Generator();

            // Act
            var actual = generator.GenerateNumbers(1, 49, 7);

            // Assert
            actual.Should().HaveCount(7);
        }

        [Fact]
        public void GenerateNumbers_Should_Choose_7_Numbers_In_The_Range_1_To_49_Inclusive()
        {
            // Arrange
            var generator = new Generator();

            // Act
            var actual = generator.GenerateNumbers(1, 49, 7);

            // Assert
            actual.Should().BeSubsetOf(Enumerable.Range(1, 49));
        }

        [Fact]
        public void GenerateNumbers_Should_Choose_7_Numbers_Which_Are_Unique()
        {
            // Arrange
            var generator = new Generator();

            // Act
            var actual = generator.GenerateNumbers(1, 49, 7);

            // Assert
            actual.Should().OnlyHaveUniqueItems();
        }

        [Fact]
        public void GenerateNumbers_Should_Present_7_Numbers_In_Order()
        {
            // Arrange
            var generator = new Generator();

            // Act
            var actual = generator.GenerateNumbers(1, 49, 7);

            // Assert
            actual.Should().BeInAscendingOrder(x => x);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        public void GetBackgroundColour_Should_Be_Gray_For_1_To_9(int number)
        {
            // Arrange & Act
            var actual = Generator.GetBackgroundColour(number);

            // Assert
            actual.Should().Be(Colour.Gray);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(14)]
        [InlineData(15)]
        [InlineData(16)]
        [InlineData(17)]
        [InlineData(18)]
        [InlineData(19)]
        public void GetBackgroundColour_Should_Be_Blue_For_10_To_19(int number)
        {
            // Arrange & Act
            var actual = Generator.GetBackgroundColour(number);

            // Assert
            actual.Should().Be(Colour.Blue);
        }

        [Theory]
        [InlineData(20)]
        [InlineData(21)]
        [InlineData(22)]
        [InlineData(23)]
        [InlineData(24)]
        [InlineData(25)]
        [InlineData(26)]
        [InlineData(27)]
        [InlineData(28)]
        [InlineData(29)]
        public void GetBackgroundColour_Should_Be_Pink_For_20_To_29(int number)
        {
            // Arrange & Act
            var actual = Generator.GetBackgroundColour(number);

            // Assert
            actual.Should().Be(Colour.Pink);
        }

        [Theory]
        [InlineData(30)]
        [InlineData(31)]
        [InlineData(32)]
        [InlineData(33)]
        [InlineData(34)]
        [InlineData(35)]
        [InlineData(36)]
        [InlineData(37)]
        [InlineData(38)]
        [InlineData(39)]
        public void GetBackgroundColour_Should_Be_Green_For_30_To_39(int number)
        {
            // Arrange & Act
            var actual = Generator.GetBackgroundColour(number);

            // Assert
            actual.Should().Be(Colour.Green);
        }

        [Theory]
        [InlineData(40)]
        [InlineData(41)]
        [InlineData(42)]
        [InlineData(43)]
        [InlineData(44)]
        [InlineData(45)]
        [InlineData(46)]
        [InlineData(47)]
        [InlineData(48)]
        [InlineData(49)]
        public void GetBackgroundColour_Should_Be_Yellow_For_40_To_49(int number)
        {
            // Arrange & Act
            var actual = Generator.GetBackgroundColour(number);

            // Assert
            actual.Should().Be(Colour.Yellow);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(50)]
        public void GetBackgroundColour_Should_Be_Unknown_For_Number_Outside_The_Range_1_To_49(int number)
        {
            // Arrange & Act
            var actual = Generator.GetBackgroundColour(number);

            // Assert
            actual.Should().Be(Colour.Unknown);
        }
    }
}