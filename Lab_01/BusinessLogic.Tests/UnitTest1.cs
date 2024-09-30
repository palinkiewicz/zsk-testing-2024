using BusinessLogic;

namespace BusinessLogic.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Calculator_Add_AddsTwoNumbers()
        {
            Calculator calc = new();

            double a = 1.0;
            double b = 2.0;
            double expectedResult = a + b;

            double result = calc.Add(a, b);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Calculator_Substract_SubstractsTwoNumbers()
        {
            Calculator calc = new();

            double a = 1.0;
            double b = 2.0;
            double expectedResult = a - b;

            double result = calc.Substract(a, b);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(5.0, 2.0, 3.0)]
        public void Calculator_Substract_SubstractsTwoNumbers_Parameters(double a, double b, double expectedResult)
        {
            Calculator calc = new();

            double result = calc.Substract(a, b);

            Assert.Equal(expectedResult, result);
        }
    }
}