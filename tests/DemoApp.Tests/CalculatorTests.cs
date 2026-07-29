namespace DemoApp.Tests;

public class UnitTest1
{
    [Fact]
    public void TestAdd()
    {
        var calculator = new Calculator();
        var result = calculator.Add(2, 3);
        Assert.Equal(5, result);
    }
 
    [Fact]
    public void TestSubtract()
    {
        var calculator = new Calculator();
        var result = calculator.Subtract(5, 3);
        Assert.Equal(2, result);
    }
 
    [Fact]
    public void TestMultiply()
    {
        var calculator = new Calculator();
        var result = calculator.Multiply(2, 3);
        Assert.Equal(6, result);
    }
 
    [Fact]
    public void TestDivide()
    {
        var calculator = new Calculator();
        var result = calculator.Divide(6, 3);
        Assert.Equal(2, result);
    }

    [Fact]
    public void TestDivideByZero()
    {
        var calculator = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(6, 0));
    }
 
}
