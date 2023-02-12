/*
    - Data input
    - Ariphmitics operations
    - Data output
    - Error processing
*/
using patterns.Application;
using patterns.BL;
using patterns.Infractructure;
using patterns.Infractructure.CalcConsole;

namespace patterns
{
    public class MyCalculator
    {
        public static void Run()
        {
            Console.WriteLine("This is Calculator");
            var consoleIO = new ConsoleIO
                (
                    new FloatValidator(),
                    new OperationValidator(),
                    new FloatConverter(),
                    new OperationConverter()
                );
            var genericCalc = new GenericCalculator(consoleIO, consoleIO, consoleIO);

             genericCalc.Run();
        }
    }
}