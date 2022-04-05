
namespace Kata.Diversion.Tests;
public class Diversiontests
{
    [Fact]
    public void SayHelloWorld_ShouldReturnHelloWorld()
    {
        // Arrange
        var sut = new Diversion();
        // Act
        var actual = sut.SayDiversion();
        // Assert
        actual.Should().Be("Hello World!");
    }
}

