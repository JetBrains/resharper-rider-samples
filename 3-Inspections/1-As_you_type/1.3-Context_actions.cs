namespace JetBrains.ReSharper.Koans.Inspections
{
    // Context actions
    //
    // Similar to quick fixes, but tied to a code block, not a highlight
    //
    // Alt+Enter

    public class ContextActions
    {
        // 1. Place caret on public below
        //    Note the hovering "hammer" icon. This indicates a context action is available
        //    Alt+Enter and select "To Private" to make the method private
        public void MakePublicMethodPrivate()
        {
        }

        // 2. Apply context action
        //    Place text caret on "arg"
        //    Note the hammer action - a context action is available (no squiggly!)
        //    Hit Alt+Enter, select "To String.Format invocation"
        public string ConcatenatingString(string arg)
        {
            return "Hello" + arg + "World";
        }

        // 3. Context actions can be configured in the ReSharper -> Options Dialog
        //    Configured per language. Select Code Editing -> C# -> Context Actions,
        //    or VB.Net, JavaScript, XML, Build Scripts, etc
    }
}