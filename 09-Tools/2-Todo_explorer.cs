using System;

namespace JetBrains.ReSharper.Koans.Tools
{
    // To-do explorer
    //
    // Highlights "to do" comments in code, and displays them in the To do Items window
    //
    // Ctrl+Alt+D (VS)
    // (no keyboard shortcut defined in IntelliJ - use the ReSharper → Tools menu)

    public class ToDoExplorer
    {
        // 1. The comment in this method should be highlighted
        // 2. Display the To-do Items window
        //    This comment should be visible in the project
        //    Try changing the grouping and expand nodes to see the comment
        // 3. Change the filter from (all) to To Do
        // 4. Type "method" in the window, it should filter the items down to this comment
        // 5. Double click the item in the window to navigate here
        public void MethodWithToDoComment()
        {
            // TODO: Blah blah blah
        }

        // 4. The NotImplementedException should be highlighted and visible in the window
        public void MethodThrowsNotImplemented()
        {
            throw new NotImplementedException();
        }

        // 5. Click the spanner icon in the To do items window to open the settings dialog
        // 6. Double click an item to edit or duplicate
        // 7. Duplicate the To do item, and edit the pattern to be:
        //    (?<=\W|^)(?<TAG>PERF)(\W|$)(.*)
        //    The comment in the method below should be highlighted and added to the window
        // 8. When editing a to do item, you can use "Save To" in the settings dialog and
        //    save to a solution level settings file, that can be committed to source control
        public void MethodWithCommentForMe()
        {
            // PERF: Blah blah blah
        }
    }
}