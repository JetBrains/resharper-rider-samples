using NUnit.Framework;

namespace JetBrains.ReSharper.Koans.UnitTesting
{
    // 1. Find usages on Calc
    //    Note that the usages in the test methods are marked with test icons
    //    Remove the test usages from the results from the Filter Usages dropdown → Show Unit Test Usages
    public class Calc
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }

    public class Analyser
    {
        private readonly Calc calc = new Calc();

        public bool IsValid(int x, int y, int threshold)
        {
            return calc.Add(x, y) > threshold;
        }
    }

    [TestFixture]
    public class CalcTests
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            var calc = new Calc();
            Assert.AreEqual(42, 20, 22);
        }

        [Test]
        public void ShouldSubtractTwoNumbers()
        {
            var calc = new Calc();
            Assert.AreEqual(42, 62, 20);
        }
    }
}