using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    // Surround With
    //
    // Replace selection with text that includes current selection
    //
    // Ctrl+E, U (VS)
    // Ctrl+Alt+J (IntelliJ)
    // Alt+Enter
    //
    // See also Live Templates

    public class SurroundWith
    {
        public void SurroundSingleLineWithTryCatch()
        {
            // 1. Place the caret on the following line
            //    Invoke Surround With
            //    Select try..catch
            //    Edit the hotspot and hit tab to complete
            Console.WriteLine("This might throw");
        }

        public void SurroundMultipleLinesWithTryCatch()
        {
            // 2. Select the following lines
            //    Invoke Surround with
            //    Select try..catch
            //    Edit the hotspot and hit tab to complete
            Console.WriteLine("Hello");
            Console.WriteLine("World");
        }

        public void SurroundWithContextAction()
        {
            // 3. Select the Console.WriteLine statement
            //    Invoke Surrond With by using Alt+Enter
            //    Select { }
            if (true)
                Console.WriteLine("Hello world");
        }
    }
}