using patterns.Infractructure;
using patterns.BL;
namespace patterns.Application
{
    public class GenericCalculator
    {
        public GenericCalculator(IDataInput<float, OperationsEnum> dataInput, IDataOutput<float> dataOutput, IErrorOutput errorOutput)
        {
            Input = dataInput;
            Output = dataOutput;
            Error = errorOutput;
        }

        private readonly IDataInput<float, OperationsEnum> Input;
        private readonly IDataOutput<float> Output;
        private readonly IErrorOutput Error;

        public void Run()
        {
            var a = Input.ReadA();
            var b = Input.ReadB();
            var op = Input.ReadOperation();

            Output.Write(Calculator.Calc(a, b, op));
        }
    }
}