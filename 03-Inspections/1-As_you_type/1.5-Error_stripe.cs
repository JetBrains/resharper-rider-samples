using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace JetBrains.ReSharper.Koans.Inspections
{
    // Highlights are reflected in the Error Stripe on the right of the editor
    //
    // 1. Mouse over each mark in the Error Stripe
    //    See tooltip
    //    Click the mark to navigate
    // 2. Note the icon at the top right. Shows if there are any warnings, suggestions or errors outstanding
    //    "Code to green" - aim for a green tick

    public class ErrorStripe
    {
        public string ErrorHighlight()
        {
            // 1. Replace null with 3000 to make an error highlight
            return null;
        }

        public void WarningHighlight()
        {
            const int condition = 42;
            if (condition == 42)
                Console.WriteLine("True");
        }

        public void SuggestionHighlight()
        {
            var files = Directory.GetFiles(@"C:\temp", "*.txt");
            if (files.Count() > 0)
                Console.WriteLine("Got some!");
        }

        public void HintHighlight()
        {
            PrivateMethodCanBeMadeStatic();
        }

        // 2. Hints are not shown in the Error Stripe
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