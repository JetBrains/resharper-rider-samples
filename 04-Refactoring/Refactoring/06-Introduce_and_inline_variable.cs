using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Introduce Variable
    //
    // Create a variable from selection
    //
    // <shortcut id="Introduce Variable...">Ctrl+R, V (VS)</shortcut>
    //

    // Inline variable
    //
    // Replaces variable usage with the contents of the variable
    //
    // <shortcut id="Inline...">Ctrl+R, I (VS)</shortcut>
    //

    public class IntroduceAndInlineVariable
    {
        public void Calculate(int a, int b)
        {
            // 1. Introduce variable
            //    Select "a+b" (Use expand selection <shortcut id="Extend Selection">Ctrl+Alt+Right</shortcut> and <shortcut id="Shrink Selection">Ctrl+Alt+Left (VS)</shortcut>)
            //    Invoke Introduce Variable
            //    Specify type, or 'var', and name
            Console.WriteLine(a + b);
        }

        public void Calculate2(int a, int b)
        {
            // 2. Introduce variable from multiple usages
            //    Select one of the "a+b" (Use expand selection <shortcut id="Extend Selection">Ctrl+Alt+Right</shortcut> and <shortcut id="Shrink Selection">Ctrl+Alt+Left (VS)</shortcut>)
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
            //    Select "value" (Use expand selection <shortcut id="Extend Selection">Ctrl+Alt+Right</shortcut> and <shortcut id="Shrink Selection">Ctrl+Alt+Left (VS)</shortcut>)
            //    Invoke Inline Variable
            //    Variable is removed, and usage is replaced with "a+b"
            var value = a + b;
            Console.WriteLine(value);
        }
    }
}