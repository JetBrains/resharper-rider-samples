using System;
using System.Collections.Generic;
using System.Linq;

namespace JetBrains.ReSharper.Koans.Inspections._1_As_you_type
{
    public class ConfiguringHighlights
    {
        public void WhyIsReSharperSuggestingThis(IEnumerable<string> values)
        {
            // 1. Get advice on why ReSharper is providing a highlight
            //    Alt+Enter on one of the highlights on 'values'
            //    Expand the "Inspection 'Possible multiple enumeration of IEnumerable'" submenu
            //    Select "Why is ReSharper suggesting this?"
            //    A web browser is opened and you are navigated to a page on
            //    JetBrains site with an explanation for this setting

            var count = values.Count();
            foreach (var value in values)
                Console.WriteLine(value);
        }

        public void IgnoreHighlightsWithComments()
        {
            // 2. Disable highlights with comments
            //    Alt+Enter on the List<string> highlight below
            //    Expand the "Inspection 'Use preferred var style'" submenu
            //    Select Disable once with comment, or expand menu for more options
            //    ReSharper adds comments and the warning is suppressed

            List<string> names = new List<string>();

            // 2a. Disable highlights with #pragma
            //     Alt+Enter on the Foo highlight below
            //     Expand the "Compiler warning 'CS0612: Use of obsolete symbol'" option
            //     Select Disable with #pragma, or expand menu for more options
            //     ReSharper adds #pragma statement and the warning is suppressed
            Console.WriteLine(Foo);
        }

        public void ConfigureHighlights()
        {
            // 3. Alt+Enter on the List<string> highlight
            //    Expand the "Inspection 'Use preferred var style'" submenu
            //    Select Configure inspection severity
            //    In the dialog, change the severity to error, warning, suggestion or hint
            //    Note also "Do not show" to disable the highlight completely
            List<string> names = new List<string>();

            // 4. Restore the highlight from the options dialog
            //    Go to ReSharper → Options
            //    Search for 'use preferred var style' in the options search box
            //    Reset the severity to the default using the default button


            // 5. Browse the available inspections in the options dialog
            //    Go to ReSharper → Options → Inspection Severity
            //    Browse by language or category
        }

        public void FixMultipleHighlights()
        {
            // 6. Alt+Enter on the List<string> highlight
            //    Enter on the "Use 'var'" item will fix the first highlight
            //    Expand the sub menu and select "Use 'var' everywhere in file"
            List<string> names = new List<string>();
            List<string> addresses = new List<string>();
            List<string> friends = new List<string>();
        }

        #region implementation details

        [Obsolete("Do not use")]
        public string Foo { get; set; }

        #endregion
    }
}
