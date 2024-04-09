namespace Assign1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorRunner runner = new CalculatorRunner(new Calculator());
            runner.Run();
        }
    }
}
