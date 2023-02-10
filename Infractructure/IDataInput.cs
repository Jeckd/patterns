using patterns.BL;
namespace patterns.Infractructure
{
    public interface IDataInput<T>
    {
         T ReadA();
         T ReadB();
         OperationsEnum ReadOperation();
    }
}