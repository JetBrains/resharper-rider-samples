namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Convert Constructor To Factory Method
    //
    // Creates a static factory method, to call constructor. Makes constructor private.
    //
    // Has no keyboard shortcut. Invoke via Refactor This menu
    // Ctrl+Shift+R

    public class ConvertConstructorToFactoryMethod
    {
        // 1. Convert constructor to factory method
        //    Place text caret on constructor definition
        //    Invoke Refactor This → Replace Constructor With Factory Method
        //    Choose name for factory method, and fully qualified type to create method in
        //      (Type must already exist)
        public ConvertConstructorToFactoryMethod(string forename, string surname, int age)
        {
        }
    }

    public class ConstructorConsumer
    {
        public void Method()
        {
            // 2. Confirm constructor has been replaced with factory method call
            var @class = new ConvertConstructorToFactoryMethod("Debbie", "Harry", 23);
        }
    }
}