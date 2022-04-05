
namespace Kata.Diversion.Tests;
public class Diversiontests
{
    [Theory]
    [InlineData("000", 1)]
    [InlineData("001", 1)]
    [InlineData("010", 1)]
    [InlineData("100", 1)]
    [InlineData("101", 1)]
    //
    [InlineData("011", 0)]
    [InlineData("110", 0)]
    [InlineData("111", 0)]
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

