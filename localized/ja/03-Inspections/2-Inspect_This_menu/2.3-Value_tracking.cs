using System;

namespace JetBrains.ReSharper.Koans.Inspections
{
    // Inspect This - Value Tracking
    //
    // Follow a value between calls
    //
    // <shortcut id="Inspect this...">Ctrl+Shift+Alt+A</shortcut> (VS/IntelliJ)
    public class ValueTracking
    {
        // 1. Find where the "value" parameter is eventually used
        //    Place the caret on the value parameter
        //    Invoke Inspect This. Select Value Destination
        //    The results are shown in a new window
        //    The initial results show the usages in MethodOne
        //    Expanding the tree shows the usages in called methods
        //    Drill down the call stack, through lambda calls and properties
        //    Find where the value is eventually used
        public void MethodOne(int value)
        {
            if (value%2 == 0)
            {
                MethodTwo(() => value);
            }
            else
            {
                MethodThree(new HelpfulClass(value));
            }
        }

        public class HelpfulClass
        {
            public int Value { get; private set; }

            public HelpfulClass(int value)
            {
                Value = value;
            }
        }

        public void MethodTwo(Func<int> newValue)
        {
            MethodThree(new HelpfulClass(newValue()));
        }

        private void MethodThree(HelpfulClass changedValue)
        {
            MethodFour(changedValue.Value);
        }

        private void MethodFour(int anotherValue)
        {
            MethodFive(anotherValue);
        }

        private void MethodFive(int finalValue)
        {
            // 2. Find where finalValue came from
            //    Place the caret on finalValue below
            //    Invoke Inspect This and select Value Origin
            //    The results are shown in a new window
            //    Expanding the tree will walk up the call stack to find the origin of the value
            //
            // 3. Display the preview pane in the results window
            Console.WriteLine(finalValue);
        }
    }
}