namespace BusinessLogic
{
    public class Calculator
    {
        /// <summary>
        /// Sums two numbers together
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>The result of a + b</returns>
        public double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Substracts the second number from the first number
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>The result of a - b</returns>
        public double Substract(double a, double b)
        {
            return a - b;
        }
    }
}
