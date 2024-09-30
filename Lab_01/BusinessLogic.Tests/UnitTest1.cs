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
            double expectedResult = 3.0;

            double result = calc.Add(a, b);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Calculator_AddInt_Overflows()
        {
            Calculator calc = new();

            int a = int.MaxValue;
            int b = 2;

            Assert.Throws<OverflowException>(() =>
            {
                calc.Add(a, b);
            });
        }

        [Fact]
        public void Calculator_Substract_SubstractsTwoNumbers()
        {
            Calculator calc = new();

            double a = 1.0;
            double b = 2.0;
            double expectedResult = -1.0;

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