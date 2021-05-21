using System;
using System.Collections.Generic;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Navigate to menu - Control Flow Target
    //
    // This is a convenient way to navigate from the current location.
    // See "4.1-Navigate_To_menu.cs" for the basic mechanism.
    //
    // How to use Navigate to
    // <shortcut id="Navigate to">Alt+`        (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Navigate to">Ctrl+Shift+G (Rider Default IntelliJ Keymap)</shortcut>
    //
    // Put the caret on the target and use the keyboard shortcut.
    //

    // 1. When caret is on a control flow keyword
    //    ReSharper and Rider can interpret the flow of the code
    //    and tell you where to navigate next.
    public class NavigateToControlFlowKeyword
    {
        public void ControlFlowWithForStatement()
        {
            for (int i = 0; i < Children.Count; i++)
            {
                var child = Children[i];

                // a) Place the caret on "continue". Navigate to → Control Flow Target
                //    takes the caret to the i++ in the for declaration
                if (ShouldSkipChild(child))
                    continue;

                // b) Place the caret on "break". Navigate to → Control Flow Target
                //    takes the caret to the next statement after the loop
                if (ShouldStop(child))
                    break;

                // c) Place the caret on "return". Navigate to → Control Flow Target
                //    takes the caret to the closing brace of the function
                if (ShouldQuit(child))
                    return;
            }

            Console.WriteLine("Finished loop");
        }

        public void ControlFlowWithSwitchStatement(Size size)
        {
            switch (size)
            {
                case Size.Large:
                    // d) Place the caret on "break". Navigate to → Control Flow Target
                    //    takes the caret to the first statement after the switch
                    break;
                case Size.Medium:
                    // e) Place the caret on "return". Navigate to → Control Flow Target
                    //    takes the caret to the closing brace of the function
                    return;
                case Size.Small:
                    // e) Place the caret on "throw". Navigate to → Control Flow Target
                    //    takes the caret to the closing brace of the function
                    throw new ArgumentOutOfRangeException("size");
            }

            Console.WriteLine("Finished switch");
        }

        #region Implementation details

        private IList<string> Children { get { return new List<string>(); } }

        private bool ShouldSkipChild(string child)
        {
            return child == "Barry";
        }

        private bool ShouldStop(string child)
        {
            return child == "Rocky";
        }

        private bool ShouldQuit(string child)
        {
            return child == "Damien";
        }

        public enum Size
        {
            Large,
            Medium,
            Small
        }

        #endregion
    }
}
