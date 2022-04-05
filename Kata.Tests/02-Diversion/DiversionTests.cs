
namespace Kata.Diversion.Tests;
public class Diversiontests
{
    [Theory]
    [InlineData("000", 0)]
    public void SayHelloWorld_ShouldReturnHelloWorld(string input, int expect)
    {
        // Arrange
        var sut = new Diversion();
        // Act
        var actual = sut.CountNotTwoAdjacent(input);
        // Assert
        actual.Should().Be(expect);
    }
}

