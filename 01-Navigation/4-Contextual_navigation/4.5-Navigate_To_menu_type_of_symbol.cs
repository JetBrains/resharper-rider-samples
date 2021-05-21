using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Navigate To menu - Type of Symbol
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

    public class WhenCaretIsOnSymbol
    {
        public void NavigateToSymbolType()
        {
            // 1. When caret is on a symbol
            //    Place caret on "stuff". Navigate to → Type of Symbol
            //    takes caret to declaration of BaseClass
            var stuff = new BaseClass();
        }
    }
}
