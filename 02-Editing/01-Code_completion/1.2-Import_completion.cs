namespace JetBrains.ReSharper.Koans.Editing
{
    // Import Completion
    //
    // Completes symbols not visible in current scope, by adding using statements
    //
    // Automatic Completion also does Import Completion. Using Import Completion alone
    // reduces the candidates in the list
    //
    // <shortcut id="Second Basic Completion">Shift+Alt+Space</shortcut> (VS)
    //

    namespace Services
    {
        public class Provider
        {
        }
    }

    public class ImportCompletion
    {
        public void UsesTypeFromNamespaceNotImported()
        {
            // 1. Start typing: var provider = new Provider
            //    Automatic Completion suggests Provider (in JetBrains.ReSharper.Koans.Editing.Services)
            //    Selecting it will add a using statement automatically
            // 2. Remove using statement
            //    Ensure the text says: "var provider = new Provider" and Provider is undefined
            //    Invoke Basic Completion (Ctrl+Space)
            //    Basic Completion suggests Provider (in JetBrains.ReSharper.Koans.Editing.Services)
            //    Selecting it will add a using statement automatically
            // 3. Remove using statement
            //    Ensure the text says: "var provider = new Provider" and Provider is undefined
            //    Invoke Import Completion
            //    Import Completion suggests Provider (in JetBrains.ReSharper.Koans.Editing.Services)
            //    Import Completion ALSO has fewer candidates in the list
            //var provider = new Provider
        }
    }
}