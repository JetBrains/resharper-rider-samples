using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace JetBrains.ReSharper.Koans.Inspections
{
    // 1. Generated code is not analysed for warnings or suggestions
    //    This file is marked as generated due to the *.generated.cs file name
    //    (As used by e.g. Windows Forms designer)
    //    Custom file names can be configured in ReSharper -> Options -> Generated Code

    public class ErrorStripeGenerated
    {
        public string ErrorHighlight()
        {
            // 2. Replace null with 3000 to make an error highlight
            //    Errors are still highlighted
            return null;
        }

        public void WarningHighlight()
        {
            // 3. No warnings
            const int condition = 42;
            if (condition == 42)
                Console.WriteLine("True");
        }

        public void SuggestionHighlight()
        {
            // 4. No suggestions
            var files = Directory.GetFiles(@"C:\temp", "*.txt");
            if (files.Count() > 0)
                Console.WriteLine("Got some!");
        }

        public void HintHighlight()
        {
            PrivateMethodCanBeMadeStatic();
        }

        // 5. No hints
        private void PrivateMethodCanBeMadeStatic()
        {
        }

        public void DeadCode()
        {
            // 6. Redundant code is highlighted in the editor, but not the error stripe
            ConditionalMethod();

            return;

            // 7. Unreachable code is still highlighted
            Console.WriteLine("Hello");
        }

        [Conditional("UndefinedSymbol")]
        private void ConditionalMethod()
        {
        }
    }
}