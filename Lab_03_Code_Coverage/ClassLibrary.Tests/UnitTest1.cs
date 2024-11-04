using ClassLibrary;

namespace ClassLibrary.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(-2, -1)]
        [InlineData(0, 0)]
        [InlineData(1, 10)]
        [InlineData(2, 200)]
        public void Test1(int x, int expectedResult)
        {
            SomeClass someClass = new();

            int result = someClass.SomeMethod(x);

            Assert.Equal(expectedResult, result);
        }
    }
}