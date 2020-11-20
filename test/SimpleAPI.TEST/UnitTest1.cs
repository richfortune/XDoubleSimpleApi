using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.TEST
{
    public class UnitTest1
    {

       WeatherForecastController Weathercontroller = new WeatherForecastController();

        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = Weathercontroller.Getting();
            Assert.Equal("christian agresta", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
