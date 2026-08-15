namespace Epistemic.Domain.Tests.Unit;

public class UnitTest1
{
    private Class1 _handler;
    
    [Fact]
    public void Test1()
    {
        // Arrange
        var x = 2;
        var y = 3;

        // Act
        var z = x + y;

        // Assert
        Assert.Equal(5, z);
    }
}