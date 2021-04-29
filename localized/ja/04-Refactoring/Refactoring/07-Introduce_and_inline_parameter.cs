using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Introduce Parameter
    //
    // Create a parameter in the current method from selection
    //
    // <shortcut id="Introduce Parameter...">Ctrl+R, P (VS)</shortcut>
    //

    // Inline Parameter
    //
    // Replaces parameter usage with the value from the call site
    //
    // <shortcut id="Inline...">Ctrl+R, I (VS)</shortcut>
    //

    public class IntroduceAndInlineParameter
    {
        public void OutputSum(int a, int b)
        {
            // 1. Introduce parameter
            //    Select "a+b" (Use expand selection <shortcut id="Extend Selection">Ctrl+Alt+Right</shortcut> and <shortcut id="Shrink Selection">Ctrl+Alt+Left (VS)</shortcut>)
            //    Invoke Introduce Parameter
            //    Specify name "sum"
            //    Parameter is added, and original value is calculated at call site
            //    (Parameters a + b can be removed with Safe Delete)
            Console.WriteLine(a + b);
        }

        public void CallOutputSum()
        {
            OutputSum(2, 3);
        }

        public void OutputSum2(int a, int b)
        {
            // 2. Introduce parameter from multiple usages
            //    Select one of the "a+b" (Use expand selection<shortcut id="Extend Selection">Ctrl+Alt+Right</shortcut> and <shortcut id="Shrink Selection">Ctrl+Alt+Left (VS)</shortcut>)
            //    Invoke Introduce Parameter
            //    ReSharper highlights all usages, prompts for one usage or all
            //    Select all, they all get replaced
            Console.WriteLine(a + b);
            Console.WriteLine(a + b);
            Console.WriteLine(a + b);
            Console.WriteLine(a + b);
        }

        public void CallOutputSum2()
        {
            OutputSum2(2, 3);
        }

        // 3. Inline parameter
        //    Select parameter "a" (Use expand selection <shortcut id="Extend Selection">Ctrl+Alt+Right</shortcut> and <shortcut id="Shrink Selection">Ctrl+Alt+Left (VS)</shortcut>)
        //    Invoke Inline Parameter
        //    Select the value to be substituted for the parameter. Value comes from usage
        //    Parameter is removed, all usages in the method are replaced with the passed value, call site is update
        public void OutputSum3(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void CallOutputSum3()
        {
            OutputSum3(2, 3);
        }

        // 4. Inline parameter with multiple usages
        //    Select parameter "a" (Use expand selection <shortcut id="Extend Selection">Ctrl+Alt+Right</shortcut> and <shortcut id="Shrink Selection">Ctrl+Alt+Left (VS)</shortcut>)
        //    Invoke Inline Parameter
        //    Select the value to be substituted for the parameter. Value comes from usage
        //    Parameter is removed, all usages in the method are replaced with the chosen value, call site is update
        public void OutputSum4(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void CallOutputSum4()
        {
            OutputSum4(2, 3);
            OutputSum4(12, 13);
            OutputSum4(200, 300);
        }
    }
}