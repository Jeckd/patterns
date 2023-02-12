namespace patterns.Infractructure
{
    public interface IErrorOutput
    {
         void WriteError(string errorMessage);
    }
}