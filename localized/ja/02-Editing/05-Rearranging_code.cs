using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    // Rearrange Code
    //
    // Move code up/down/left/right/in/out
    //
    // <shortcut id="Move Element Left">Left  - Ctrl+Shift+Alt+Left</shortcut>  
    // <shortcut id="Move Element Right">Right - Ctrl+Shift+Alt+Right</shortcut> 
    // <shortcut id="Move Statement Up">Up    - Ctrl+Shift+Alt+Up</shortcut>    
    // <shortcut id="Move Statement Down">Down  - Ctrl+Shift+Alt+Down</shortcut>  

    public class RearrangingCode
    {
        public void RearrangeLines()
        {
            // 1. Place caret on one of the line below
            // use
            // <shortcut id="Move Statement Up">Up - Ctrl+Shift+Alt+Up</shortcut>    
            // <shortcut id="Move Statement Down">Down - Ctrl+Shift+Alt+Down</shortcut>
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
            // <shortcut id="Move Element Left">Left - Ctrl+Shift+Alt+Left</shortcut>  
            // <shortcut id="Move Element Right">Right - Ctrl+Shift+Alt+Right</shortcut>
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
            // rearrange parameter order
            // <shortcut id="Move Element Left">Left  - Ctrl+Shift+Alt+Left</shortcut>  
            // <shortcut id="Move Element Right">Right - Ctrl+Shift+Alt+Right</shortcut> 
            MethodWithParameters(hello, world, foo, bar);
        }

        public void RearrangeInAndOut()
        {
            if (true)
            {
                // 4. Place caret on WriteLine
                //    Rearrange within the if statement
                //    Move out of if statement
                //    Move above and below if statement
                //    Move into the if statement
                Console.WriteLine("Hello");
                Console.WriteLine("World");
            }
        }

        // 5. Rearrange the comment
        // <shortcut id="Move Statement Up">Up - Ctrl+Shift+Alt+Up</shortcut>    
        // <shortcut id="Move Statement Down">Down - Ctrl+Shift+Alt+Down</shortcut>
        public void RearrangeComment()
        {
            // Move me
            Console.WriteLine("Hello");
            Console.WriteLine("World");
        }

        public void ExtendBlockWithGreedyBraces()
        {
            // 5. Place caret on outside of closing brace
            // <shortcut id="Move Statement Up">Up - Ctrl+Shift+Alt+Up</shortcut>    
            // <shortcut id="Move Statement Down">Down - Ctrl+Shift+Alt+Down</shortcut>
            //
            // Move block to include next statement
            // move up block to exclude current last statement
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