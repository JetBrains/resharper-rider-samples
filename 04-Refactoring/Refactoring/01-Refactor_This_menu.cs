using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Refactor This menu
    //
    // Display a contextual menu of refactorings available at the current location
    //
    // Ctrl+Shift+R

    // 1. Refactor This on type definition, method, property, field, parameter, variable, etc.
    //    Note different options on each code element
    //    Various refactorings shown in more detail in rest of section
    public class Class1 // <- Refactor This on class name
    {
        // Refactor This on field
        public readonly int field;

        // Refactor This on property
        public string Property { get; set; }

        // Refactor This on method, parameters
        public void Method(string parameter1, int parameter2)
        {
            // Refactor This on variable
            var variable = parameter1;
            Console.WriteLine(variable);
        }
    }
}
