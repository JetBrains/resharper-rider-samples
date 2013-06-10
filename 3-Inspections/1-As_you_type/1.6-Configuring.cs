using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JetBrains.ReSharper.Koans.Inspections._1_As_you_type
{
    public class ConfiguringHighlights
    {
        public void WhyIsReSharperSuggestingThis()
        {
            // 1. Get advice on why ReSharper is providing a highlight
            //    Alt+Enter on the List<string> highlight
            //    Expand the "Options..." submenu
            //    Select "Why is ReSharper suggesting this?"
            //    A web browser is opened and you are navigated to a page on
            //    JetBrains site with an explanation for this setting
            List<string> names = new List<string>();
        }

        public void IgnoreHighlightsWithComments()
        {
            // 2. Disable highlights with comments
            //    Alt+Enter on the List<string> highlight below
            //    Expand the "Options..." submenu
            //    Select Disable once with comment, or Disable and restore with comments
            //    ReSharper adds comments and the warning is suppressed

            List<string> names = new List<string>();
        }

        public void ConfigureHighlights()
        {
            // 3. Alt+Enter on the List<string> highlight
            //    Expand the "Options..." submenu
            //    Select Configure inspection severity
            //    In the dialog, change the severity to error, warning, suggestion or hint
            //    Note also "Do not show" to disable the highlight completely
            List<string> names = new List<string>();

            // 4. Restore the highlight from the options dialog
            //    Go to ReSharper -> Options -> Inspection Severity
            //    Select the C# tab
            //    Type 'var' in the search box (including single quotes)
            //    Find "Use 'var' keyword when initializer explicitly declares type"
            //    Ensure the severity level is set to "Suggestion"

            // 5. Browse the available inspections in the options dialog
            //    Go to ReSharper -> Options -> Inspection Severity
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
    }
}
