namespace patterns.Infractructure
{
    public interface IConvertable<T>
    {
         T Convert(string s);
    }
}