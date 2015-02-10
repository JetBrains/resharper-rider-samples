using System.Collections.Generic;

namespace JetBrains.ReSharper.Koans.Inspections
{
    // Find code issues
    //
    // ReSharper → Inspect → Code Issues in Solution/Current Project

    public class FindMatchingIssues
    {
        public void MultipleIssues()
        {
            // 1. Alt+Enter on the first List<string> highlight
            //    Expand the "Inspection 'Use preferred var style'" submenu
            //    Select "Find all issues of this type in scope"
            //    Specify the scope in the dialog - project, solution or custom
            //    All matching issues are displayed in a new results window
            List<string> names = new List<string>();
            List<string> address = new List<string>();
            List<int> ages = new List<int>();
        }
    }
}