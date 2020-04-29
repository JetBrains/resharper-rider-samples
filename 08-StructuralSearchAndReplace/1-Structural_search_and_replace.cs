using System;

namespace JetBrains.ReSharper.Koans.StructuralSearchAndReplace
{
    // Structural Search And Replace
    //
    // Find, highlight and replace code patterns via parameterised examples
    //
    public class StructuralSearch
    {
        // 1. Create a pattern to highlight usages of DateTime.Today rather than UTC time
        //
        //    a) Go to ReSharper → Find → Search with Pattern
        //    b) Type DateTime.Today in code search box
        //    c) Click find - ReSharper should show list of all instances of DateTime.Today
        //
        public void FindUsagesOfDateTimeToday()
        {
            var today = DateTime.Today;
            Console.WriteLine(today);
        }

        // 2. Parameterised searches
        //    Repeat the search from step 1 above. Note that the "System.DateTime.Today"
        //    below isn't found. We need to tell ReSharper to search for the type System.DateTime,
        //    not the text DateTime.Today
        //
        //    a) Go to ReSharper → Find → Search with Pattern
        //    b) Change the pattern to $type$.Today
        //    c) Click Add Placeholder → Extract from pattern. ReSharper will create an expression
        //       placeholder called "type"
        //    d) Double click the "type" placeholder to edit it
        //    e) Type System.DateTime in the "Expression type", or use the dropdown to select from
        //       a tree, or use CamelHumps, etc. Click OK. Notice the $type$ in the editor is no
        //       longer underlined
        //    f) Click Find, ReSharper should now find the DateTime.Today above and System.DateTime.Today
        //       below
        public void FindUsagesOfDateTimeTodayUsingTypeInformation()
        {
            // Do not remove the System namespace qualification!
            var today = System.DateTime.Today;
            Console.WriteLine(today);
        }

        // 3. Create a pattern to highlight usages of DateTime.Today as a warning
        //    a) Go to ReSharper → Options → Code Inspection → Custom Patterns
        //    b) Click Add pattern
        //    c) Make sure "Find" is highlighted in top right of Add dialog
        //    d) Type $type$.Today in code search box
        //    e) Add placeholder from pattern, set the "type" expression to System.DateTime
        //    f) Set pattern severity to Show as warning
        //    g) Add a description e.g. "DateTime.Today is presented in local time. Consider using UTC"
        //    h) Click Add, then click Save
        //    i) The usage of DateTime.Today below should be highlighted as a warning
        //       and the description entered should be displayed as a tooltip
        // 4. Alt+Enter on the highlight, and edit the pattern. Try changing the severity
        public void HighlightUsageOfDateTimeTodayAsWarning()
        {
            var today = DateTime.Today;
            Console.WriteLine(today);
        }

        // 5. Create a pattern to highlight usages of DateTime.Now and allow replacing with DateTime.UtcNow
        //    a) Go to ReSharper → Options → Code Inspection → Custom Patterns
        //    b) Click Add pattern
        //    c) Make sure "Replace" is highlighted in top right of Add dialog
        //    d) Type $type$.Now in code search box
        //    e) Add placeholder from pattern, set the "type" expression to System.DateTime
        //    f) Set pattern severity to Show as warning
        //    g) Add a description e.g. "DateTime.Now is local time. You probably want UTC time"
        //    h) Type "$type$.UtcNow" in the replace pattern text box
        //    i) Check "Format after replace" and "Shorten references"
        //    j) Add a description e.g. "Replace with DateTime.UtcNow"
        //    k) Click Add, then click Save
        //    l) The usage of DateTime.Now below should be highlighted as a warning
        //       and the description entered should be displayed as a tooltip
        //    m) Alt+Enter on the highlight and use the suggested fix
        public void HighlightAndReplaceUsageOfDateTimeNow()
        {
            var today = DateTime.UtcNow;
            Console.WriteLine(today);
        }

        // 6. Create a pattern that matches similar constructs
        //    a) Go to ReSharper → Options → Code Inspections → Custom Patterns
        //    b) Click Add Pattern
        //    c) Make sure "Find" is highlighted in top right of Add dialog
        //    d) Type "$id$ > 0" in the search text box
        //    e) Create an identifier placeholder. Leave the name regex blank
        //    f) Set the pattern severity
        //    g) Make sure "Match similar constructs" is ticked
        //    h) Add a description, e.g. "Matching constructs"
        //    i) Click Save and Click Save on the Options dialog
        // The (x > 0) and (0 < x) should both be highlighted (since the two statements
        // are equivalent)
        public void MatchSimilarConstructs()
        {
            int x = 0;
            if (x > 0)
                Console.WriteLine("bingo!");

            if (0 < x)
                Console.WriteLine("bingo!");
        }
    }
}
