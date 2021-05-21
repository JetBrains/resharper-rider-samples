using System;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Navigate To menu - Menu on Method
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

    // 1. When the caret is on a method
    public class NavigateToMenuOnMethod
    {
        // a) Member overloads highlights overloads of the method
        //    Escape clears the highlight
        //
        // (Reference) How to move between candidates
        //
        // NOTE: Rider shortcuts are undefined by default (no configuration) and must be configured to work.
        // Settings | Keymap | Main Menu | Edit | Find Usages
        //  - Next Highlighted Usage
        //  - Previous Highlighted Usage
        //
        //   <shortcut id="Go to Next/Previous">Ctrl+Alt+PageUp/Ctrl+Alt+PageDown (ReSharper VisualStudio Keymap)</shortcut>
        //   <shortcut id="Find Next/Previous"> F3 / Shift+F3                     (Rider Default IntelliJ Keymap)</shortcut>
        //
        //   (ReSharper) https://www.jetbrains.com/help/resharper/Navigation_and_Search__Navigate_from_Here__Overriding_Members.html
        //   (Rider)     https://www.jetbrains.com/help/rider/Navigation_and_Search__Navigate_from_Here__Overriding_Members.html
        //
        public bool OverloadedMethod()
        {
            return true;
        }

        // b) Function exit(s) highlights return statements
        //    Escape clears the highlight
        //
        // (Reference) How to move between candidates
        //
        // NOTE: Rider shortcuts are undefined by default (no configuration) and must be configured to work.
        // Settings | Keymap | Main Menu | Edit | Find Usages
        //  - Next Highlighted Usage
        //  - Previous Highlighted Usage
        //
        //   <shortcut id="Go to Next/Previous">Ctrl+Alt+PageUp/Ctrl+Alt+PageDown (ReSharper VisualStudio Keymap)</shortcut>
        //   <shortcut id="Find Next/Previous"> F3 / Shift+F3                     (Rider Default IntelliJ Keymap)</shortcut>
        //
        //   (ReSharper) https://www.jetbrains.com/help/resharper/Navigation_and_Search__Navigate_from_Here__Overriding_Members.html
        //   (Rider)     https://www.jetbrains.com/help/rider/Navigation_and_Search__Navigate_from_Here__Overriding_Members.html
        //
        public bool OverloadedMethod(string arg1)
        {
            if (string.IsNullOrEmpty(arg1))
                return false;
            Console.WriteLine("do!");
            if (arg1 == "throw")
                throw new InvalidOperationException();
            return true;
        }

        public bool OverloadedMethod(string arg1, string arg2)
        {
            return false;
        }
    }
}
