namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Extract Class From Parameters
    //
    // Creates a class based on the parameters to a method, and creates it at call sites
    //
    // No keyboard shortcut. Invoke via Refactor This menu
    // Ctrl+Shift+R

    public class ExtractClassFromParameters
    {
        // 1. Extract class from parameters
        //    Place text caret on method definition
        //    Invoke Refactor This → Extract Class From Parameters
        //    ReSharper prompts for options - name, class/struct, nested/top level
        //      and which parameters should be extracted
        public ExtractClassFromParameters(string forename, string surname, int age)
        {
        }

        public static ExtractClassFromParameters Create(string forename, string surname, int age)
        {
            // 2. Confirm call site has been updated to create parameter class
            return new ExtractClassFromParameters(forename, surname, age);
        }
    }
}