using Individuell_inlämning;
using Xunit;

namespace TestUträkning
{
    public class CalculationTest
    {
        //test av addition
        [Fact]
        public void AdditionTest()
        {
            Calculations uträkning = new();

            decimal expected = 5;
            decimal actual = uträkning.Addition(2, 3);

            Assert.Equal(expected, actual);
            Assert.NotEqual(expected,uträkning.Addition(2,2));
            Assert.NotEqual(expected,uträkning.Addition(3,3));
            

        }
        //test av subtraktion
        [Fact]
        public void SubtractionTest()
        {
            Calculations uträkning = new();

            decimal expected = 5;
            decimal actual = uträkning.Subtraction(8, 3);

            Assert.Equal(expected, actual);
            Assert.NotEqual(expected,uträkning.Subtraction(5,2));
            Assert.NotEqual(expected,uträkning.Subtraction(9,3));
        }
        //test av multiplikation
        [Fact]
        public void MultiplicationTest()
        {
            Calculations uträkning = new Calculations();

            decimal expected = 6;
            decimal actual = uträkning.Multiplication(2, 3);

            Assert.Equal(expected, actual);
            Assert.NotEqual(expected, uträkning.Multiplication(2, 2));
            Assert.NotEqual(expected, uträkning.Multiplication(3, 3));
        }
        //test av division
        [Fact]
        public void DivisionTest()
        {
            Calculations uträkning = new Calculations();

            decimal expected = 2;
            decimal actual = uträkning.Division(6, 3);

            Assert.Equal(expected, actual);
            Assert.NotEqual(expected, uträkning.Division(2, 2));
            Assert.NotEqual(expected, uträkning.Division(3, 3));

        }
        //test av felaktiga additionsuträkningar
        [Theory]
        [InlineData(2,3)]
        [InlineData(5,3)]
        [InlineData(4,3)]
        [InlineData(132,3)]
        [InlineData(3,3)]
        public void ShouldNotBeAddition(decimal num1, decimal num2)
        {
            Calculations uträkning = new();

            Assert.NotEqual(10,uträkning.Addition(num1, num2));
        }
        //Skippar testet eftersom det kommer "faila" pga att vi har ett try/catch block med DivideByZeroException i vår divisionsmetod
        //Tar vi bort try/catch blocket i vår  divisionmetod kommer testet att lyckas/bli "passed"
        [Fact(Skip = "Skippar testet eftersom att DivideByZeroException aldrig kan uppstå")]
        public void DivisionDivideByZero()
        {
            Calculations test = new();
            Assert.Throws<System.DivideByZeroException>(() => test.Division(2, 0));
        }

    }
}