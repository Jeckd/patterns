using patterns.Infractructure;
using patterns.BL;
namespace patterns.Application
{
    public class GenericCalculator
    {
        public GenericCalculator(IDataInput<float> dataInput, IDataOutput<float> dataOutput, IErrorOutput errorOutput)
        {
            Input = dataInput;
            Output = dataOutput;
            Error = errorOutput;
        }

        private readonly IDataInput<float> Input;
        private readonly IDataOutput<float> Output;
        private readonly IErrorOutput Error;

        public void Run()
        {
            var a = Input.ReadA();
            var b = Input.ReadB();
            var op = Input.ReadOperation();

            var result = Calculator.Calc(a, b, op);
            if(string.IsNullOrEmpty(result.Message))
                Output.Write(result);
            else
                Error.WriteError(result.Message);
        }
    }
}