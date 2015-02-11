using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    // Clipboard Ring
    //
    // Tracks the last 20 copies to the clipboard
    //
    // ReSharper → Edit → Paste (No shortcut defined in VS)
    // Ctrl+Shift+V (IntelliJ)

    public class ClipboardRing
    {
        public void Method()
        {
            // 1. Copy each line below in turn
            // 2. Invoke Clipboard Ring
            //    Each copied line is shown in most recent order
            // 3. Hit the number to paste
            //    Next time the dialog is opened, the order is updated
            Console.WriteLine("One");
            Console.WriteLine("Two");
            Console.WriteLine("Three");
            Console.WriteLine("Four");
        }
    }
}