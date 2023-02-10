/*
    - Data input
    - Ariphmitics operations
    - Data output
    - Error processing
*/
using patterns.Application;
using patterns.BL;
using patterns.Infractructure.CalcConsole;

namespace patterns
{
    public class MyCalculator
    {
        public static void Run()
        {
            Console.WriteLine("This is Calculator");

            var genericCalc = new GenericCalculator(
                new ConsoleIO(),
                new ConsoleIO(),
                new ConsoleIO()
             );

             genericCalc.Run();

        }
    }
}