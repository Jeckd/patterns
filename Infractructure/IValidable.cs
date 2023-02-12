namespace patterns.Infractructure
{
    public interface IValidable<T>
    {
         bool Validate(string s); 
    }
}