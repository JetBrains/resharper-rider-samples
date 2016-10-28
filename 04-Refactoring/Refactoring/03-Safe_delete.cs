using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Safe delete
    //
    // Only delete code element if it's not being used
    //
    // Ctrl+R, D (VS)
    // Alt+Delete (IntelliJ)

    public class ClassWithUsedAndUnusedField
    {
        // 1. Delete unused field
        //    Place text caret on UnusedField and invoke Safe Delete
        //    Hit OK, field is removed
        public string UnusedField = "hello world";

        // 2. Safe delete used field
        //    Place text caret on UsedField and invoke Safe Delete
        //    Hit OK, ReSharper warns field is used
        //    Click on the word "Usage" to navigate to the usage
        //    Edit/remove the usage, if required
        //    Click Next to remove field even with usages, or Cancel
        public string UsedField = "hello world";

        // 3. Safe delete unused parameter
        //    Place text caret on unusedParameter and invoke Safe Delete
        //    Parameter isn't used inside method, so is deleted
        //    Value passed as parameter when calling Method is also deleted
        // 3a. Safe delete used parameter
        //     Place text caret on usedParameter and invoke Safe Delete
        //     ReSharper warns parameter is used, can navigate to usage
        //     Next will remove anyway, leaving broken code, or Cancel
        public void Method(string usedParameter, string unusedParameter)
        {
            Console.WriteLine(usedParameter);
        }

        public void Method2()
        {
            Method("hi", null);
        }
    }

    // 4. Safe Delete unused class
    //    Place text on UnusedClass and invoke Safe Delete
    //    ReSharper asks to remove empty files
    //    Next will analyse for usages, find none and delete type
    //    If file didn't contain any other definitions, the file would be deleted
    public class UnusedClass
    {
    }

#region Implementation details

    public class User
    {
        public static void Method()
        {
            // Navigate back (Ctrl+-)
            Console.WriteLine(new ClassWithUsedAndUnusedField().UsedField);
        }
    }

#endregion
}