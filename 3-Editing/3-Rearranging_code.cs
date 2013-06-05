using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    // Rearrange Code
    //
    // Move code elements up/down/left/right/in/out
    //
    // Ctrl+Shift+Alt+Left/Right/Up/Down (VS + IntelliJ)

    public class RearrangingCode
    {
        public void RearrangeLines()
        {
            // 1. Place caret on one of the line below
            //    Use Ctrl+Shift+Alt+Up/Down to move the line up or down
            Console.WriteLine("One");
            Console.WriteLine("Two");
            Console.WriteLine("Three");
            Console.WriteLine("Four");
            Console.WriteLine("Five");
        }

        public void RearrangeExpressionOrder()
        {
            var value = 42;
            var newValue = 34;
            newValue++;

            // 2. Place caret on newValue
            //    Use Ctrl+Shift+Alt+Left/Right to rearrange expression order
            value = newValue;

            Console.WriteLine(value);
        }

        public void RearrangeParameterOrder()
        {
            const string hello = "hello";
            const string world = "world";
            const string foo = "foo";
            const string bar = "bar";

            // 3. Place caret on hello
            //    Use Ctrl+Shift+Alt+Left/Right to rearrange parameter order
            MethodWithParameters(hello, world, foo, bar);
        }

        public void RearrangeInAndOut()
        {
            if (true)
            {
                // 4. Place caret on WriteLine
                //    Use Ctrl+Shift+Alt+Up/Down to rearrange within the if statement
                //    Use Ctrl+Shift+Alt+Left to move out of if statement
                //    Use Ctrl+Shift+Alt+Up/Down to move above and below if statement
                //    Use Ctrl+Shift+Alt+Right to move into the if statementS
                Console.WriteLine("Hello");
                Console.WriteLine("World");
            }
        }

        // 5. Use Ctrl+Shift+Alt+Up/Down to rearrange comment
        public void RearrangeComment()
        {
            // Move me
            Console.WriteLine("Hello");
            Console.WriteLine("World");
        }

        public void ExtendBlockWithGreedyBraces()
        {
            // 5. Place caret on outside of closing brace
            //    Use Ctrl+Shift+Alt+Down to move block to include next statement
            //    Use Ctrl+Shift+Alt+Up to move block to exclude current last statement
            if (true)
            {
                Console.WriteLine("Hello");
            }

            Console.WriteLine("World");
        }

        private void MethodWithParameters(string p1, string p2, string p3, string p4)
        {
        }
    }
}