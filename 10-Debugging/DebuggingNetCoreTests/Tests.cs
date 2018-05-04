using Xunit;

namespace DebuggingNetCoreTests
{
    // Simple debugging of tests
    // 
    // Add a breakpoint in a test (Click in gutter)
    // Click the gutter icon or use Alt+Enter on the class or method name
    // and select Debug or Debug All
    //
    // The test session is added as a temporary Run Configuration
    // Use the Run Configuration drop down in the top right of the window
    // to select the new test Run Configuration
    //
    // Run (Shift+F10 or Ctrl+R) will run all of the tests in the test session
    // Debug (F5 or Ctrl+D) will debug the test session
    public class CalculatorTests
    {
        [Fact]
        public void TestAdd()
        {
            var result = Calculator.Add(21, 21);
            Assert.Equal(42, result);
        }

        [Fact]
        public void TestSubtract()
        {
            var result = Calculator.Subtract(23, 2);
            Assert.Equal(21, result);
        }

        [Fact]
        public void TestDivide()
        {
            var result = Calculator.Divide(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestMultiply()
        {
            var result = Calculator.Multiply(21, 2);
            Assert.Equal(42, result);
        }
    }

    public static class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
