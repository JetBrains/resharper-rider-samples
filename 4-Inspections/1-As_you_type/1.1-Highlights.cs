using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace JetBrains.ReSharper.Koans.Inspections
{
    public class Highlights
    {
        public string ErrorHighlight()
        {
            // 1. Highlights code that is incorrect, and will most likely fail to compile
            //    Replace the "null" with 3000 below
            //    ReSharper shows an error highlight
            //    Hover mouse over to see tooltip: "Cannot convert expression type 'int' to return type 'string'"
            return null;
        }

        public void WarningHighlight()
        {
            const int condition = 42;

            // 2. Highlights code that is potentially incorrect and should be changed
            //    Shown as a blue squiggly underline
            //    Hover mouse over to see tooltip: "Expression is always true"
            if (condition == 42)
                Console.WriteLine("True");
        }

        public void SuggestionHighlight()
        {
            // 3. Highlights code and suggests making a change
            //    Shows as a green squiggly underline
            //    Hover mouse over to see tooltip: "Use method Any()"
            var files = Directory.GetFiles(@"C:\temp", "*.txt");
            if (files.Count() > 0)
                Console.WriteLine("Got some!");
        }

        public void HintHighlight()
        {
            PrivateMethodCanBeMadeStatic();
        }

        // 4. Highlights code with a suggestion for a change, but the suggestion is optional
        //    Shows as 3 green dots under the start of the highlighted region
        //    Hover mouse over to see tooltip: "Method 'PrivateMethodCanBeMadeStatic' can be made static"
        private void PrivateMethodCanBeMadeStatic()
        {
        }

        public void DeadCode()
        {
            // 5. Highlights code that is redundant or unreachable
            //    Shows as greyed out
            //    Hover mouse over to see tooltip: "Method invocation is skipped..."
            ConditionalMethod();

            return;

            // "Code is unreachable"
            Console.WriteLine("Hello");
        }

        [Conditional("UndefinedSymbol")]
        private void ConditionalMethod()
        {
        }
    }
}