using NUnit.Framework;

namespace JetBrains.ReSharper.Koans.Editing
{
    // Show Parameter Info
    //
    // Shows expected parameter types and names for method calls and overloads
    //
    // Ctrl+K, P (VS)
    // Ctrl+P (IntelliJ)
    // Cancel to close
    //
    // Configure behaviour in ReSharper → Options → Environment → IntelliSense → Parameter Info
    public class ParameterInfo
    {
        public void Foo()
        {
            // 1. Show Parameter Info
            //    Place text caret inside method parameters
            //    Invoke Parameter Info
            SayHello("Steve");

            // 2. Highlights current parameter
            //    Place text caret inside method parameters
            //    Invoke Parameter Info
            //    Move caret through parameters, see current parameter highlighted in bold
            Add(1, 2, 3, 4);

            // 3. Overloaded members
            //    Place text caret inside method parameters
            //    Invoke Parameter Info
            //    Scroll through overloaded methods with cursor keys or repeated use of "Show Parameter Info"
            //    (depends on configuration)
            Assert.AreEqual(12, 12);

            // 4. Compact view of overloaded members
            //    Edit configuration (ReSharper → Options → Environment → IntelliSense → Parameter Info)
            //    Uncheck "Display all signatures at once"
            //    Place text caret inside method parameters
            //    Invoke Parameter Info
            //    Cycle through overloaded methods with cursor keys or repeated use of "Show Parameter Info"
            //    (depends on configuration)
            Assert.AreEqual(12, 12);
        }

        #region Implementation details

        public string SayHello(string name)
        {
            return "Hello " + name;
        }

        public int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        #endregion
    }
}