using Quantum.Math.Api.Services;

namespace Quantum.Math.Api.Tests.Unit;

public class MathServiceTests
{
    [Fact]
    public void ItShouldSumWithSuccess()
    {
        var mathService = new MathService();
        Assert.Equal(10.0, mathService.Sum(5.0, 5.0));
    }

    [Fact]
    public void ItShouldDivideWithSuccess()
    {
        var mathService = new MathService();
        Assert.Equal(2.0, mathService.Division(10.0, 5.0));
    }
}