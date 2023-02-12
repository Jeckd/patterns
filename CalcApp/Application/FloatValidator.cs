using patterns.Infractructure;

namespace patterns.Application
{
    public class FloatValidator : IValidable<float>
    {
        public bool Validate(string s)
        {
            float a;
            return float.TryParse(s, out a);
        }
    }
}