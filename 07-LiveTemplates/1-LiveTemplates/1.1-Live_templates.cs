using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace JetBrains.ReSharper.Koans.LiveTemplates
{
    // Live Templates
    //
    // Expandable code snippets

    public class LiveTemplates
    {
        // 1. Expanding a Live Template
        //    Start typing the name of the macro, hit tab or select from the code completion list
        public void ExpandingLiveTemplates()
        {
            // Type "out" (no quotes) and hit tab to expand Console.Out.WriteLine("");
        }

        // 2. The $END$ macro
        //    The $END$ macro marks the point where the text caret is placed when the template is inserted
        //    Go to ReSharper -> Templates Explorer -> Live Templates -> C# and select the "psvm" template 
        //    This template expands to implement the Main method of an app. The $END$ macro is placed inside
        //      the method body
        //    Type psvm after this comment, hit tab or select the item from the code completion list
        //    The Main method is implemented, and the caret ends up inside the method body
        // Type "psvm" here:


        // 3. Editable hotspots
        //    Live Templates can contain "hotspots" that can provide interacivity when expanding the template
        //    Hotspots can be tied to macros to provide suggestions for the content of hotspots
        //    Expand the "foreach" template in the method below
        //    Note that there are 3 hotspots - the collection to iterate, the type of the current object and
        //      the name of the variable for the current object
        //    Note that ReSharper suggests local objects that can be enumerated, i.e. names and jobs
        //    Hit tab to move between hotspots (shift+tab to move back)
        //    Note that Resharper suggests type information, and where possible names for the variable
        public void UseLiveTemplatesToIterateCollection(IEnumerable<string> jobs)
        {
            var names = new List<string>();

            // Type foreach here:

        }

        // 4. Macros
        //    ReSharper has other macros that can be used, e.g. static list of values, current date/time,
        //      casting to the required type, suggesting names or types and many more
        //    This example expands to a new guid
        //    Put the cursor inside the brackets of new Guid(), add quotes and start typing "nguid"
        //      e.g. new Guid("nguid");
        //    Hit tab or select the item from the code completion list
        //    ReSharper creates a new guid and offers formatting optionss
        private Guid guid = new Guid();
        private Guid guid2 = new Guid("nguid"); // Place cursor between d and " and hit tab to expand

        // 5. Shorten references
        //    Go to ReSharper -> Templates Explorer -> Live Templates -> C# and select the "asrt" template 
        //    Note that the template expands to "System.Diagnostics.Debug.Assert($END$)"
        //    Type "asrt" in the method below, hit tab, or select the item from the code completion list
        //    Note that the inserted code is "Debug.Assert()" and that System.Diagnostics is added to the
        //      usings list at the top of the file
        public void RequiresDebugAssert()
        {
            // Type "asrt" here:


        }

        // 6. Scoping
        //    Live Templates can be scoped so they only operate in certain parts of your code
        //    a) Try to expand the nguid template here (inside a comment):                  <-- here
        //    b) Try to expand the "thr" template below (outside of a method):


        // ^ here
    }

    // 7. Create a Live Template
    //    Go to ReSharper -> Templates Explorer -> Live Templates -> C#
    //    Click the New Template toolbar button
    //    Enter a shortcut, e.g. tf
    //    Enter a description, e.g. "Create NUnit TestFixture"
    //    Enter the text:
    // [NUnit.Framework.TestFixtureAttribute]public class $CLASSNAME$ {$END$}
    //    (all on one line, don't worry about formatting)
    //    Check "Reformat" and "Shorten qualified references"
    //    Set the availability to "In C# 2.0+ where type member declaration is allowed"
    //    Save the template and test below:


    // ^ here
}
