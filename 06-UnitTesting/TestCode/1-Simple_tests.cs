using System;
using NUnit.Framework;

namespace JetBrains.ReSharper.Koans.UnitTesting
{
    // Run unit tests
    //
    // All keyboard shortcuts are listed in the ReSharper → Unit Tests menu
    //
    // Run unit tests in the current cursor context:
    //   Ctrl+U, R (VS)
    //   Ctrl+T, R (IntelliJ)
    // Run the current unit test session:
    //   Ctrl+U, Y (VS)
    //   Ctrl+T, T (IntelliJ)
    // Repeat previous run:
    //   Ctrl+U, U (VS)
    // Debug tests:
    //   Ctrl+U, D (VS)


    // 1. Run all tests by clicking the gutter icon
    // 2. Run all tests by alt+enter and Run All
    // 3. Run all tests with different keyboard shortcuts
    //    Run all in solution, run current session
    // 4. Put the caret outside the class, inside the class and inside methods
    //    Run the tests at the current context
    [TestFixture]
    public class SimpleTests
    {
        [Test]
        public void PassingTest()
        {
            Assert.AreEqual(42, 42);
        }

        [Test]
        public void FailingTest()
        {
            // 5. Double click the failing test in the Unit Test Session window
            //    or use the stack trace to navigate here and fix the test
            // 6. Run just this test, with Alt+Enter on method name, or with keyboard shortcuts
            Assert.AreEqual(12, 23);
        }

        // 7. Ignored tests don't get run, but are still shown in the Unit Test Session window
        [Test, Ignore("Ignored for no particular reason.")]
        public void IgnoredTest()
        {
            throw new NotImplementedException();
        }

        // 8. Run all or some parameterised tests
        //    Change the values, watch tests fail and fix them
        [TestCase(3, 1, 2)]
        [TestCase(10, 5, 5)]
        [TestCase(42, 21, 21)]
        public void ParameterisedTest(int result, int x, int y)
        {
            Assert.AreEqual(result, Add(x, y));
        }

        // 9. Run all or some parameterised tests
        //    Change the values, watch tests fail
        [TestCase(1, 2, ExpectedResult = 3)]
        [TestCase(5, 5, ExpectedResult = 10)]
        [TestCase(21, 21, ExpectedResult = 42)]
        public int ParameterisedTestWithImplicitAssert(int x, int y)
        {
            return Add(x, y);
        }

        private int Add(int x, int y)
        {
            return x + y;
        }

        // 10. Parameterised tests, using a named test case source
        //     a) Go to Definition (Ctrl+Click) of DivideCases
        //     b) Invoke Code Completion (Ctrl+Space) with the caret inside DivideCases
        //     c) Use the rename refactoring to change the name of the data source and update the string literal
        //     d) Edit the name, see ReSharper flag the unknown data source as an error
        [Test, TestCaseSource("DivideCases")]
        public void ParameterisedTestsWithDataSource(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }

        // 11. Find Usages on DivideCases, the caret should go to the TestCaseSource attribute
        private static readonly object[] DivideCases =
        {
            new object[] {12, 3, 4},
            new object[] {12, 2, 6},
            new object[] {12, 4, 3}
        };

        // 12. Debugging tests
        //     Set a breakpoint and debug the test (Alt+Enter, keyboard shortcuts)
        [Test]
        public void DebuggingTest()
        {
            const int expected = 42;
            var actual = GetActual();
            Assert.AreEqual(expected, actual);
        }

        private int GetActual()
        {
            return 41;
        }
    }
}