using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace JetBrains.ReSharper.Koans.Inspections
{
    // Quick Fixes
    //
    // Provides an automated fix for a highlight
    //
    // <shortcut id="Show context actions">Alt+Enter</shortcut>

    public class QuickFixes
    {
        public string ErrorHighlight()
        {
            // 1. Fix error highlight by changing return type of method, or returning a string
            //    Replace the "null" with 3000 below
            //    ReSharper shows an error highlight
            //    Place caret on highlighted region and press <shortcut id="Show context actions">Alt+Enter</shortcut>
            //    Select "Change type of method 'ErrorHighlight' to 'int'"
            //    Or "Call ToString()"
            return null;    // Replace with 3000
        }

        public void WarningHighlight()
        {
            const int condition = 42;

            // 2. Fix warning highlight by quick fix
            //    Place caret on highlighted region and press <shortcut id="Show context actions">Alt+Enter</shortcut>
            //    Select to replace if statement with the contents of the branch
            //    Or replace with the constant "true"
            if (condition == 42)
                Console.WriteLine("True");
        }

        public void SuggestionHighlight()
        {
            // 3. Make suggested replacement by quick fix
            //    Place caret on highlighted region and press <shortcut id="Show context actions">Alt+Enter</shortcut>
            //    Select "Use method Any()" to replace the call to Count()
            var files = Directory.GetFiles(@"C:\temp", "*.txt");
            if (files.Count() > 0)
                Console.WriteLine("Got some!");
        }

        public void HintHighlight()
        {
            PrivateMethodCanBeMadeStatic();
        }

        // 4. Make hint replacement by quick fix
        //    Place caret on highlighted region and press <shortcut id="Show context actions">Alt+Enter</shortcut>
        //    Select Make method 'PrivateMethodCanBeMadeStatic' static to change the method
        private void PrivateMethodCanBeMadeStatic()
        {
        }

        public void DeadCode()
        {
            return;


            // 5. Remove unreachable code by quick fix
            //    Place caret on highlighted region and press <shortcut id="Show context actions">Alt+Enter</shortcut>
            //    Select Remove unreachable code, or Uncomment unreachable code
            Console.WriteLine("Hello");
        }
    }
}