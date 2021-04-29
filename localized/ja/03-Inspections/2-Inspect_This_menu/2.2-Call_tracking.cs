using System;

namespace JetBrains.ReSharper.Koans.Inspections
{
    // Inspect This menu - Call tracking
    //
    // View incoming and outgoing calls for methods
    //
    // <shortcut id="Inspect this...">Ctrl+Shift+Alt+A</shortcut> (VS/IntelliJ)

    public class CallTracking
    {
        // 1. Show all calls made by MethodOne
        //    Place caret on MethodOne and Invoke Inspect This
        //    Select Outgoing Calls
        //    Results are displayed in a new Inspection Window
        //    Expanding the tree dives deeper into the call stack
        //    Expand the tree down to MethodFive to see the methods called there
        public void MethodOne()
        {
            MethodTwo();
        }

        public void MethodTwo()
        {
            MethodThree();
            MethodThree();
        }

        public void MethodThree()
        {
            MethodFive();
            MethodSix();
        }

        public void MethodFour()
        {
            MethodFive();
            MethodSix();
        }

        // 2. Show all calls made to MethodFive
        //    Place the caret on MethodFive
        //    Invoke Incoming Calls
        //    Results are displayed in a new Inspection Window
        //    Expanding the tree walks further up the call stack
        //    Expand the tree down to MethodFive to see the methods called there
        //
        // 3. Enable the preview pane in the results window
        public void MethodFive()
        {
            Console.WriteLine();
            Console.Out.WriteLine();
        }

        public void MethodSix()
        {
            Console.WriteLine();
            Console.Out.WriteLine();
        }
    }
}