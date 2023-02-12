using patterns.BL;
namespace patterns.Infractructure
{
    public interface IDataInput<T, U>
    {
         T ReadA();
         T ReadB();
         U ReadOperation();
    }
}