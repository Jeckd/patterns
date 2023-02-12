using patterns.BL;
using patterns.Infractructure;

namespace patterns.Application
{
    public class OperationValidator : IValidable<OperationsEnum>
    {
        public bool Validate(string s)
        {
            if(s=="+") return true;
            else if (s=="-") return true;
            else if(s=="*") return true;
            else if(s=="/") return true;

            return false;
        }
    }
}