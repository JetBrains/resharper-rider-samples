using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    public class UndefinedSymbols
    {
        public void CreateFromUsage(int a, int b)
        {
            // 1. Create from usage
            //    Uncomment these lines
            //    Alt+Enter on Calculator and create from usage
            //    Alt+Enter on Add and create from usage - select return type, parameter type usage, implement method

            //var calculator = new Calculator();
            //if (calculator.Add(a, b) > 100)
            //    Console.WriteLine("Winner!");
        }

        public void ChangeAllLocal()
        {
            const int result = 23;

            // 2. Change All Local
            //    Update all usages of an undefined symbol in the current method
            //    Uncomment broken code
            //    Alt+Enter on undefined symbol
            //    Select Chage all local 'value'
            //    ReSharper suggests alternatives that fit - result from local method, and NewValue field
            //    Accepting change only affects this method

            //Console.WriteLine(value);
            //Console.WriteLine(value);
            //Console.WriteLine(value);
        }

        public const int NewValue = 42;

        public void ChangeAll()
        {
            const int localValue = 100;

            // 2. Change All
            //    Update all usages of an undefined symbol across methods
            //    Uncomment broken code below, and in ChangeAll2
            //    Alt+Enter on undefined symbol
            //    Select Chage all 'value'
            //    ReSharper suggests alternatives that fit - NewValue field, but not localValue
            //      (it's not accessible from ChangeAll2)
            //    Accepting change only affects this method and ChangeAll2

            //Console.WriteLine(value);
            //Console.WriteLine(value);
            //Console.WriteLine(value);
        }

        public void ChangeAll2()
        {
            //Console.WriteLine(value);
            //Console.WriteLine(value);
            //Console.WriteLine(value);
        }
    }
}