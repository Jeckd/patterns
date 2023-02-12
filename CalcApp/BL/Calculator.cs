namespace patterns.BL
{
    public class Calculator
    {
        private static float Add(float a, float b) => a+b;
        private static float Odd(float a, float b) => a-b;
        private static float Mul(float a, float b) => a*b;

        private static Result<float> Div(float a, float b)
        {
            if(b==0)
            {
                return new Result<float>(0, "Division by zero");
            }
            
            return new Result<float>(a/b);
        }

        public static Result<float> Calc(float a, float b, OperationsEnum op)
        {
            if(op == OperationsEnum.ADD)
                return new Result<float>(Add(a, b));
            else if(op == OperationsEnum.ODD)
                return new Result<float>(Odd(a, b));
            else if(op == OperationsEnum.MUL)
                return new Result<float>(Mul(a, b));
            else if(op == OperationsEnum.DIV)
                return Div(a,b);
            else
                return new Result<float>(0, "Unkonwn operation");
        } 
    }

    public enum OperationsEnum
    {
        ADD,
        ODD,
        MUL,
        DIV,
        UNKNOWN
    }

    public class Result<T>
    {
        public Result(T value,  string message)
        {
            this.Value = value;
            this.Message = message;
        }

        public Result(T value)
        {
            this.Value = value;
            this.Message = string.Empty;
        }

        public T Value {get;}
        public string Message {get;}
    }
}
