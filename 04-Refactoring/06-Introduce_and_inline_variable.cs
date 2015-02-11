using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Introduce Variable
    //
    // Create a variable from selection
    //
    // Ctrl+R, V (VS)
    // Ctrl+Alt+V (IntelliJ)

    // Inline variable
    //
    // Replaces variable usage with the contents of the variable
    //
    // Ctrl+R, I (VS)
    // Ctrl+Alt+N (IntelliJ)

    public class IntroduceAndInlineVariable
    {
        public void Calculate(int a, int b)
        {
            // 1. Introduce variable
            //    Select "a+b" (Use expand selection Ctrl+Alt+Right (VS) Ctrl+W (IntelliJ))
            //    Invoke Introduce Variable
            //    Specify type, or 'var', and name
            Console.WriteLine(a + b);
        }

        public void Calculate2(int a, int b)
        {
            // 2. Introduce variable from multiple usages
            //    Select one of the "a+b" (Use expand selection Ctrl+Alt+Right (VS) Ctrl+W (IntelliJ))
            //    Invoke Introduce Variable
            //    ReSharper highlights all usages, prompts for one usage or all
            //    Select all, they all get replaced
            Console.WriteLine(a + b);
            Console.WriteLine(a + b);
            Console.WriteLine(a + b);
            Console.WriteLine(a + b);
        }

        public void Calculate3(int a, int b)
        {
            // 3. Inline variable
            //    Select "value" (Use expand selection Ctrl+Alt+Right (VS) Ctrl+W (IntelliJ))
            //    Invoke Inline Variable
            //    Variable is removed, and usage is replaced with "a+b"
            var value = a + b;
            Console.WriteLine(value);
        }
    }
}