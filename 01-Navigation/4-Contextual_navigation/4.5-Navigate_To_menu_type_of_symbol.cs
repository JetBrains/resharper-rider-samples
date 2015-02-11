using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

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


    public class WhenCaretIsOnSymbol
    {
        public void NavigateToSymbolType()
        {
            // 1. When caret is on a symbol
            //    Place caret on "stuff". Navigate To → Type of Symbol
            //    takes caret to declaration of BaseClass
            var stuff = new BaseClass();
        }
    }
}