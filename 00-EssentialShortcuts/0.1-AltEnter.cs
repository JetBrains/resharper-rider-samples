namespace EssentialShortcuts
{
    // Alt+Enter
    //
    // Used to apply quick fixes to inspections ("squigglies"), or apply
    // context specific actions, depending on location of text caret
    //
    // Also allows searching and applying all ReSharper commands direct
    // from the menu.
    //
    // Icon is displayed in gutter margin on left of editor, e.g. yellow
    // lightbulb to fix warning, red light bulb to fix error, hammer to
    // apply a context action, etc.

    // 1. Apply QuickFix for an inspection
    //    The class doesn't match ReSharper's naming style
    //    Place text caret on "squiggly". Note the lightbulb in the margin on the left
    //    Click the light bulb, or hit "Alt+Enter"
    //    Select "Rename to 'BadlyNamedClass'" to fix
    //
    // (More on inspections in section 3)
    public class badlyNamedClass
    {
    }

    public class ContextAction
    {
        public static string FormatString(string arg)
        {
            // 2. Apply context action
            //    Place text caret on "arg"
            //    Note the hammer action - a context action is available (no squiggly!)
            //    Hit Alt+Enter, select "To String.Format invocation"
            return "Hello" + arg + "World";
        }
    }

    // 3. Go to action
    //    Place text caret on class name below
    //    Alt+Enter, note magnifying glass
    //    Click magnifying glass, start typing "rename"
    //    Or, just start typing "rename" from menu
    //    Filters ReSharper commands and applies
    public class GoToAction
    {
    }
}
