using patterns.BL;
namespace CalcApp_Test;

public class Calculator_Tests
{
    [SetUp]
    public void Setup()
    {
        //No need setup
    }

    [Test]
    public void Add_Operation_returns_correct_result()
    {
        var result = Calculator.Calc(5, 5, OperationsEnum.ADD);
        Assert.AreEqual(10, result.Value);
    }

    [Test]
    public void Odd_Operation_returns_correct_result()
    {
        var result = Calculator.Calc(5, 5, OperationsEnum.ODD);
        Assert.AreEqual(0, result.Value);
    }
    
    [Test]
    public void Mul_Operation_returns_correct_result()
    {
        var result = Calculator.Calc(5, 5, OperationsEnum.MUL);
        Assert.AreEqual(25, result.Value);
    }

    [Test]
    public void Div_Operation_returns_correct_result()
    {
        var result = Calculator.Calc(5, 5, OperationsEnum.DIV);
        Assert.AreEqual(1, result.Value);
    }

    [Test]
    public void Div_Operation_returns_error_when_division_on_0()
    {
        var result = Calculator.Calc(5, 0, OperationsEnum.DIV);
        Assert.IsNotEmpty(result.Message);
    }

}