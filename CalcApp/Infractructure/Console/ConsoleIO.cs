using patterns.BL;
using patterns.Infractructure;
using System;
namespace patterns.Infractructure.CalcConsole
{
    public class ConsoleIO : IDataInput<float, OperationsEnum>, IDataOutput<float>, IErrorOutput
    {
        public ConsoleIO(
                IValidable<float> floatValidator,
                IValidable<OperationsEnum> operationsValidator,
                IConvertable<float> floatConverter,
                IConvertable<OperationsEnum> operationConverter)
        {
            this.floatValidator = floatValidator;
            this.floatConverter = floatConverter;
            this.operationsValidator = operationsValidator;
            this.operationsConverter = operationConverter;
        }

        private IValidable<float> floatValidator;
        private IValidable<OperationsEnum> operationsValidator;
        private IConvertable<float> floatConverter;
        private IConvertable<OperationsEnum> operationsConverter;

        private T Read<T>(string varName, IValidable<T> validator, IConvertable<T> converter)
        {
            Console.Write($"{varName} = ");
            var s = Console.ReadLine();

            while(!validator.Validate(s))
            {
                Console.WriteLine("Invalid value entered");
                Console.Write($"{varName} = ");
                s = Console.ReadLine();
            }
            return converter.Convert(s);
        }

        public float ReadA() => Read("A", this.floatValidator, this.floatConverter);

        public float ReadB() => Read("B", this.floatValidator, this.floatConverter);
        
        public OperationsEnum ReadOperation() => Read("Operation: ", this.operationsValidator, this.operationsConverter);
        
        public void Write(Result<float> result)
        {
            if(string.IsNullOrEmpty(result.Message))
            {
                Console.WriteLine($"Result is {result.Value}");
                return;
            }

            WriteError(result.Message);
        }

        public void WriteError(string errorMessage)
        {
            Console.WriteLine($"****Error**** {errorMessage}");
        }
    }
}