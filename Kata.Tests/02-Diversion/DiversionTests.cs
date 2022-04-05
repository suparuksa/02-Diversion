
namespace Kata.Diversion.Tests;
public class Diversiontests
{
    [Theory]
    [InlineData("000", 1)]
    [InlineData("001", 1)]
    public void CountNotTwoAdjacentOne_ShouldBeeOne(string input, int expect)
    {
        // Arrange
        var sut = new Diversion();
        // Act
        var actual = sut.CountNotTwoAdjacentOne(input);
        // Assert
        actual.Should().Be(expect);
    }
}

