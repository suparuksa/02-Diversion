
namespace Kata.Diversion.Tests;
public class Diversiontests
{
    [Theory]
    [InlineData("000", 1)]
    public void CountNotTwoAdjacent_ShouldbeOne(string input, int expect)
    {
        // Arrange
        var sut = new Diversion();
        // Act
        var actual = sut.CountNotTwoAdjacent(input);
        // Assert
        actual.Should().Be(expect);
    }
}

