using Individuell_inlämning;
using Xunit;

namespace TestUträkning
{
    public class TemperaturTesning
    {
        //test av omvandling från celsius till fahrenheit
        [Fact]
        public void CelsiusToFarenTest()
        {
            Temperature celsius = new();

            decimal expected = 73.4m;
            decimal actual = celsius.Celsius(23);

            Assert.Equal(expected, actual);
            Assert.NotEqual(celsius.Celsius(22), expected);
            Assert.NotEqual(celsius.Celsius(24), expected);
        }
        //test av omvandling från fahreinheit till celsius
        [Fact]
        public void FarenToCelsisusTest()
        {
            Temperature faren = new();

            decimal expected = 23;
            decimal actual = faren.FarenToCelsius(73.4m);

            Assert.Equal(expected, actual);
            Assert.NotEqual(22,faren.FarenToCelsius(73.4m));
            Assert.NotEqual(24, faren.FarenToCelsius(73.4m));
        }
    }
}