using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    public class SelectingCode
    {
        // Extend/Shrink selection
        //
        // <shortcut id="Extend Selection">Ctrl+Alt+Right</shortcut> and <shortcut id="Shrink Selection">Ctrl+Alt+Left (VS)</shortcut>
        //
        //
        // Select Containing Declaration
        //
        // <shortcut id="Select Containing Declaration">Ctrl+Shift+[</shortcut>

        public void ExtendAndShrinkSelection()
        {
            // 1. Place the caret inside "importantValue" and expand selection
            //    Expand selection again to select the whole line
            //    Expand selection again to select the body of the method
            //    Expand selection again to select the whole method
            //    Expand selection again to select the whole class
            //    Expand selection again to select the whole namespace
            //    Expand selection again to select the whole file
            // 2. Place the caret inside "importantValue" and expand selection a couple of times
            //    Shrink selection to reduce the selection back to what it was
            var importantValue = 32;
            if (importantValue > 42)
            {
                try
                {
                    // 3. Place the caret on WriteLine and repeatedly Extend and Shrink selection
                    Console.WriteLine("Hello");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        // 4. Go to ReSharper → Options → Environment → Editor → Editor Behavior
        //    Tick CamelHumps on
        //    Place the caret inside the method name and Extend and Shrink selection
        //    (Also, with CamelHumps on, try <shortcut id="Move Caret to Previous Word">Ctrl+Left</shortcut> and <shortcut id="Move Caret to Next Word">Ctrl+Right</shortcut> navigation inside the method name)
        public void ExtendAndShrinkSelectionWithCamelHumps()
        {
            var importantValue = 32;
            if (importantValue > 42)
            {
                try
                {
                    Console.WriteLine("Hello");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        // 5. Place caret anywhere within method and invoke Select Block repeatedly
        public void SelectBlock()
        {
            var importantValue = 32;
            if (importantValue > 42)
            {
                try
                {
                    Console.WriteLine("Hello");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}