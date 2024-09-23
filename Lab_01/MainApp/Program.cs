using BusinessLogic;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Add(2.0, 2.5));
            Console.WriteLine(calculator.Substract(2.0, 2.5));
        }
    }
}
