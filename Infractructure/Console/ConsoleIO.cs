using patterns.BL;
using patterns.Infractructure;
using System;
namespace patterns.Infractructure.CalcConsole
{
    public class ConsoleIO : IDataInput<float>, IDataOutput<float>, IErrorOutput
    {
        public float ReadA()
        {
            Console.Write("A = ");
            return float.Parse(Console.ReadLine());
        }

        public float ReadB()
        {
            Console.Write("B = ");
            return float.Parse(Console.ReadLine());
        }

        public OperationsEnum ReadOperation()
        {
            Console.Write("Enter operation");
            var op = Console.ReadLine();
            OperationsEnum operation = OperationsEnum.UNKNOWN;
            if (op == "+") operation = OperationsEnum.ADD;
            else if (op == "-") operation = OperationsEnum.ODD;
            else if (op == "*") operation = OperationsEnum.MUL;
            else if (op == "/") operation = OperationsEnum.DIV;
            return operation;
        }

        public void Write(Result<float> result)
        {
            Console.WriteLine($"Result is {result.Value}");
        }

        public void WriteError(string errorMessage)
        {
            Console.WriteLine($"****Error**** {errorMessage}");
        }
    }
}