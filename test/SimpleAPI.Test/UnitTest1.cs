using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void GetReturnsName()
    {
        var returnedValue = controller.Get(1);

        Assert.Equal("Azamat", returnedValue.Value);

    }

    [Fact]
    public void Test1()
    {

    }
}