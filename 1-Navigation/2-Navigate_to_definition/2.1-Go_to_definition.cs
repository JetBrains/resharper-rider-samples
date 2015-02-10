using System;
using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Go To Definition
    //
    // Navigates to the definition of a symbol
    //
    // Ctrl+Click
    // Ctrl+B (VS)
    // Ctrl+B (IntelliJ)

    public class GoToDefinition
    {
        public void Method(string name, int age)
        {
            // 1. Ctrl+Click on "Person"
            // 2. Use the keyboard shortcut
            var person = new Person("Hadi", 53);

            // 3. Go To Definition for "name" or "age" parameters
            var otherPerson = new Person(name, age);

            // 4. Go To Definition on the word "var" to navigate to inferred type
            var thirdPerson = otherPerson;

            // 5. Navigate to definition of a type from a library
            //    Go To Definition on "Console"
            Console.WriteLine(thirdPerson.Name);

            // 6. View a namespace in the Assembly Explorer
            //    Go To Definition on "System"
            System.Console.WriteLine();

            // 7. Go to Definition of a namespace
            //    Ctrl+Click or use the keyboard shortcut on "Navigation"
            var type = typeof(JetBrains.ReSharper.Koans.Navigation.GoToDefinition);
        }
    }
}