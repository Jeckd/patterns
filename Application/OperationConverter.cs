using patterns.BL;
using patterns.Infractructure;

namespace patterns.Application
{
    public class OperationConverter : IConvertable<OperationsEnum>
    {
        public OperationsEnum Convert(string s)
        {
            if(s == "+") return OperationsEnum.ADD;
            else if (s == "-") return OperationsEnum.ODD;
            else if (s == "*") return OperationsEnum.MUL;
            else if (s == "/") return OperationsEnum.DIV;
            
            return OperationsEnum.UNKNOWN;
        }
    }
}