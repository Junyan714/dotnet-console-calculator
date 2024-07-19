namespace Calculator.Tests;

public class CalculatorTests
{
    // Unit tests for Add operation
    [Fact]
    public void TestAdd_1()
    {
        Assert.Equal(6L, Add.Eval(1L, 5L));
    }
    [Fact]
    public void TestAdd_2()
    {
        Assert.Equal(0L, Add.Eval(-3L, 3L));
    }
    [Fact]
    public void TestAdd_3()
    {
        Assert.Equal(-8L, Add.Eval(-5L, -3L));
    }

    // Unit tests for Subtract operation
    [Fact]
    public void TestSubtract_1()
    {
        Assert.Equal(3L, Subtract.Eval(9L, 6L));
    }
    [Fact]
    public void TestSubtract_2()
    {
        Assert.Equal(-6L, Subtract.Eval(3L, 9L));
    }
    [Fact]
    public void TestSubtract_3()
    {
        Assert.Equal(0L, Subtract.Eval(5L, 5L));
    }

    // Unit tests for Multiply operation
    [Fact]
    public void TestMult_1()
    {
        Assert.Equal(6L, Multiply.Eval(2L, 3L));
    }
    [Fact]
    public void TestMult_2()
    {
        Assert.Equal(0L, Multiply.Eval(0L, 3L));
    }
    [Fact]
    public void TestMult_3()
    {
        Assert.Equal(-9L, Multiply.Eval(-3L, 3L));
    }

    // Unit tests for Division operation
    [Fact]
    public void TestDivision_1()
    {
        Assert.Equal(3L, Division.Eval(9L, 3L));
    }
    [Fact]
    public void TestDivision_2()
    {
        Assert.Equal(2L, Division.Eval(8L, 4L));
    }
    [Fact]
    public void TestDivision_3()
    {
        Assert.Throws<DivideByZeroException>(() => Division.Eval(9L, 0L));
    }

    // Unit tests for Idempotence operation
    [Fact]
    public void TestIdempotence_1()
    {
        Assert.Equal(64L, Idempotence.Eval(2L, 6L));
    }
    [Fact]
    public void TestIdempotence_2()
    {
        Assert.Equal(1L, Idempotence.Eval(1L, 5L));
    }
    [Fact]
    public void TestIdempotence_3()
    {
        Assert.Equal(121L, Idempotence.Eval(11L, 2L));
    }

    // Unit tests for Factorial operation
    [Fact]
    public void TestFactorial_1()
    {
        Assert.Equal(720L, Factorial.Eval(6L));
    }
    [Fact]
    public void TestFactorial_2()
    {
        Assert.Equal(1L, Factorial.Eval(0L));
    }
    [Fact]
    public void TestFactorial_3()
    {
        Assert.Equal(120L, Factorial.Eval(5L));
    }

    // Unit tests for Logarithmic operation
    [Fact]
    public void TestLogarithmic_1()
    {
        Assert.Equal(2L, Logarithmic.Eval(100L, 10L));
    }
    [Fact]
    public void TestLogarithmic_2()
    {
        Assert.Equal(3L, Logarithmic.Eval(1000L, 10L));
    }
    [Fact]
    public void TestLogarithmic_3()
    {
        Assert.Equal(1L, Logarithmic.Eval(10L, 10L));
    }

    // Unit tests for Sine operation
    [Fact]
    public void TestSine_1()
    {
        Assert.Equal(0L, Sine.Eval(0L));
    }
    [Fact]
    public void TestSine_2()
    {
        Assert.Equal(1L, Sine.Eval(90L));
    }
    [Fact]
    public void TestSine_3()
    {
        Assert.Equal(0L, Sine.Eval(180L));
    }

    // Unit tests for Cosine operation
    [Fact]
    public void TestCosine_1()
    {
        Assert.Equal(1L, Cosine.Eval(0L));
    }
    [Fact]
    public void TestCosine_2()
    {
        Assert.Equal(0L, Cosine.Eval(90L));
    }
    [Fact]
    public void TestCosine_3()
    {
        Assert.Equal(-1L, Cosine.Eval(180L));
    }

    // Unit tests for Tangent operation
    [Fact]
    public void TestTangent_1()
    {
        Assert.Equal(0L, Tangent.Eval(0L));
    }
    [Fact]
    public void TestTangent_2()
    {
        Assert.Equal(1L, Tangent.Eval(45L));
    }
    [Fact]
    public void TestTangent_3()
    {
        Assert.Equal(-1L, Tangent.Eval(135L));
    }

    // Unit tests for Cotangent operation
    [Fact]
    public void TestCotangent_1()
    {
        Assert.Equal(1L, Cotangent.Eval(45L));
    }
    [Fact]
    public void TestCotangent_2()
    {
        Assert.Equal(-1L, Cotangent.Eval(135L));
    }
    [Fact]
    public void TestCotangent_3()
    {
        Assert.Equal(0L, Cotangent.Eval(90L));
    }

    // Unit tests for RectangleArea operation
    [Fact]
    public void TestRectangleArea_1()
    {
        Assert.Equal(54L, RectangleArea.Eval(9L, 6L));
    }
    [Fact]
    public void TestRectangleArea_2()
    {
        Assert.Equal(0L, RectangleArea.Eval(0L, 6L));
    }
    [Fact]
    public void TestRectangleArea_3()
    {
        Assert.Equal(30L, RectangleArea.Eval(5L, 6L));
    }

    // Operation tests with Evaluator
    [Fact]
    public void TestAddOperation_1()
    {
        Assert.Equal(8, Evaluator.Eval("+", 6, 2));
    }
    [Fact]
    public void TestAddOperation_2()
    {
        Assert.Equal(-1, Evaluator.Eval("+", -3, 2));
    }
    [Fact]
    public void TestAddOperation_3()
    {
        Assert.Equal(0, Evaluator.Eval("+", 0, 0));
    }

    [Fact]
    public void TestSubtractOperation_1()
    {
        Assert.Equal(4, Evaluator.Eval("-", 6, 2));
    }
    [Fact]
    public void TestSubtractOperation_2()
    {
        Assert.Equal(-1, Evaluator.Eval("-", 1, 2));
    }
    [Fact]
    public void TestSubtractOperation_3()
    {
        Assert.Equal(0, Evaluator.Eval("-", 2, 2));
    }

    [Fact]
    public void TestMultiplicationOperation_1()
    {
        Assert.Equal(12, Evaluator.Eval("*", 6, 2));
    }
    [Fact]
    public void TestMultiplicationOperation_2()
    {
        Assert.Equal(0, Evaluator.Eval("*", 0, 2));
    }
    [Fact]
    public void TestMultiplicationOperation_3()
    {
        Assert.Equal(-6, Evaluator.Eval("*", -3, 2));
    }

    [Fact]
    public void TestDivisionOperation_1()
    {
        Assert.Equal(3, Evaluator.Eval("/", 6, 2));
    }
    [Fact]
    public void TestDivisionOperation_2()
    {
        Assert.Equal(2, Evaluator.Eval("/", 4, 2));
    }
    [Fact]
    public void TestDivisionOperation_3()
    {
        Assert.Throws<DivideByZeroException>(() => Evaluator.Eval("/", 6, 0));
    }

    [Fact]
    public void TestIdempotenceOperation_1()
    {
        Assert.Equal(6, Evaluator.Eval("^", 6, 1));
    }
    [Fact]
    public void TestIdempotenceOperation_2()
    {
        Assert.Equal(3, Evaluator.Eval("^", 3, 1));
    }
    [Fact]
    public void TestIdempotenceOperation_3()
    {
        Assert.Equal(7, Evaluator.Eval("^", 7, 1));
    }

    [Fact]
    public void TestFactorialOperation_1()
    {
        Assert.Equal(720, Evaluator.Eval("factorial", 6));
    }
    [Fact]
    public void TestFactorialOperation_2()
    {
        Assert.Equal(1, Evaluator.Eval("factorial", 0));
    }
    [Fact]
    public void TestFactorialOperation_3()
    {
        Assert.Throws<ArgumentException>(() => Evaluator.Eval("factorial", -1));
    }

    [Fact]
    public void TestLogarithmicOperation_1()
    {
        Assert.Equal(2, Evaluator.Eval("log", 100, 10));
    }
    [Fact]
    public void TestLogarithmicOperation_2()
    {
        Assert.Equal(3, Evaluator.Eval("log", 1000, 10));
    }
    [Fact]
    public void TestLogarithmicOperation_3()
    {
        Assert.Throws<ArgumentException>(() => Evaluator.Eval("log", -1, 4));
    }

    [Fact]
    public void TestSineOperation_1()
    {
        Assert.Equal(0, Evaluator.Eval("sin", 0));
    }
    [Fact]
    public void TestSineOperation_2()
    {
        Assert.Equal(0.5, Evaluator.Eval("sin", 30));
    }
    [Fact]
    public void TestSineOperation_3()
    {
        Assert.Equal(1, Evaluator.Eval("sin", 90));
    }

    [Fact]
    public void TestCosineOperation_1()
    {
        Assert.Equal(1, Evaluator.Eval("cos", 0));
    }
    [Fact]
    public void TestCosineOperation_2()
    {
        Assert.Equal(0, Evaluator.Eval("cos", 90));
    }
    [Fact]
    public void TestCosineOperation_3()
    {
        Assert.Equal(-1, Evaluator.Eval("cos", 180));
    }

    [Fact]
    public void TestTangentOperation_1()
    {
        Assert.Equal(0, Evaluator.Eval("tan", 0));
    }
    [Fact]
    public void TestTangentOperation_2()
    {
        Assert.Equal(1, Evaluator.Eval("tan", 45));
    }
    [Fact]
    public void TestTangentOperation_3()
    {
        Assert.Equal(-1, Evaluator.Eval("tan", 135));
    }

    [Fact]
    public void TestCotangentOperation_1()
    {
        Assert.Equal(0, Evaluator.Eval("cot", 90));
    }
    [Fact]
    public void TestCotangentOperation_2()
    {
        Assert.Equal(1, Evaluator.Eval("cot", 45));
    }
    [Fact]
    public void TestCotangentOperation_3()
    {
        Assert.Equal(-1, Evaluator.Eval("cot", 135));
    }

    [Fact]
    public void TestRectangleAreaOperation_1()
    {
        Assert.Equal(54, Evaluator.Eval("rect", 9, 6));
    }
    [Fact]
    public void TestRectangleAreaOperation_2()
    {
        Assert.Equal(0, Evaluator.Eval("rect", 0, 6));
    }
    [Fact]
    public void TestRectangleAreaOperation_3()
    {
        Assert.Equal(30, Evaluator.Eval("rect", 5, 6));
    }


    // Security test (input validation)
    [Fact]
    public void TestInputValidation_1()
    {
        Assert.Throws<ArgumentException>(() => Evaluator.Eval("+", null));
    }

    [Fact]
    public void TestInputValidation_2()
    {
        Assert.Throws<Exception>(() => Evaluator.Eval("unknown", 5, 5));
    }
}
