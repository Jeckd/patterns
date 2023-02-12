using patterns.Infractructure;

namespace patterns.Application
{
    public class FloatConverter : IConvertable<float>
    {
        public float Convert(string s)
        {
            return float.Parse(s);
        }
    }
}