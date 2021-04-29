using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Convert Method to Property
    //
    // No shortcut. Invoke via Refactor This menu
    // <shortcut id="Refactor This...">Ctrl+Shift+R</shortcut>

    // Convert Property to Method(s)
    //
    // Converts a property to a getter and/or setter method(s)
    //
    // No shortcut. Invoke via Refactor This menu
    // <shortcut id="Refactor This...">Ctrl+Shift+R</shortcut>

    public class ConvertMethodToProperty
    {
        // 1. Convert method to property
        //    Method must have no parameters
        //    Place text caret on method definition
        //    Invoke Convert Method To Property
        //    ReSharper suggests name
        //    Confirm to convert
        private string GetName()
        {
            return "Matt";
        }

        public void OutputName()
        {
            Console.WriteLine(GetName());
        }
    }

    public class ConvertPropertyToMethod
    {
        private string backingField;

        // 2. Convert auto property to methods
        //    Place text caret on property definition
        //    Invoke Convert property to methods
        //    Optionally generate getter and/or setter
        //    Confirm - ReSharper will automatically generate backing field
        public string AutoProperty { get; set; }

        // 3. Convert property to methods
        //    Place text caret on property definition
        //    Invoke Convert property to methods
        //    Optionally generate getter and/or setter
        public string PropertyWithBackingField
        {
            get { return backingField; }
            set { backingField = value; }
        }

        // 4. Convert getter only property to method
        //    Place text caret on property definition
        //    Invoke Convert property to methods
        //    Will only generate getter
        public string GetterOnlyProperty { get { return backingField; } }

        public void Output()
        {
            // 5. Confirm usages are still correct
            Console.WriteLine(AutoProperty);
            Console.WriteLine(PropertyWithBackingField);
            Console.WriteLine(GetterOnlyProperty);
        }
    }
}