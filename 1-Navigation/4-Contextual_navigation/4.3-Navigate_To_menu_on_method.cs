using System;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Navigate To menu
    //
    // Displays a contextual menu of options you can use to navigate to from
    // your current location
    //
    // Very useful way of navigating without having to learn ALL of the shortcuts!
    //
    // Alt+` (VS)
    // Ctrl+Shift+G (IntelliJ)


    // 5. When the caret is on a method
    public class NavigateToMenuOnMethod
    {
        // a) Member overloads highlights overloads of the method
        //    Escape clears the highlight
        //    Ctrl+Alt+PgUp/Ctrl+Alt+PgDown (VS) to navigate between
        //    Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ) to navigate between
        public bool OverloadedMethod()
        {
            return true;
        }

        // b) Function exit(s) highlights return statements
        //    Escape clears the highlight
        //    Ctrl+Alt+PgUp/Ctrl+Alt+PgDown (VS) to navigate between
        //    Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ) to navigate between
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