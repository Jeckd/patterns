using patterns.BL;
namespace patterns.Infractructure
{
    public interface IDataOutput<T>
    {
         void Write(Result<T> result);
    }
}