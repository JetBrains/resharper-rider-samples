using System;

namespace JetBrains.ReSharper.Koans.Inspections
{
    // Solution Wide Analysis
    //
    // Analyses whole solution. Can find multiple code issues, and highlights code that isn't used.
    // Takes up additional resources, so disabled by default
    //
    // Enable by right clicking circular indicator in the status bar
    //
    // Navigate between highlights in files:
    //
    // <shortcut id="Next Error">Shift+Alt+PageUp</shortcut> and <shortcut id="Previous Error">Shift+Alt+PageDn</shortcut> (VS)
    //

    public class SolutionWideAnalysis
    {
        // 1. Enable solution wide analysis


        // 2. Once complete, notice that this class and method are marked unused
        public void UnusedMethod()
        {
        }

        // 3. Navigate between warnings

        // 4. Uncomment the failing code below
        //    Open the Solution Errors Window (ReSharper → Inspect → Solution Errors Window)
        //    Double click the error in the window to navigate back
        //    Hide errors with right click or toolbar
        //    Show hidden errors with toolbar
        //    Comment code to fix errors again
        //public void FailingCode()
        //{
        //    int i = "hello";

        //    UnusedMethod(undefinedVariable);

        //    return new Exception();
        //}
    }
}