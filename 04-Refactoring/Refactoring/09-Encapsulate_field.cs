namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Encapsulate Field
    //
    // Convert a field to a property
    //
    // <shortcut id="Encapsulate Field...">Ctrl+R, E</shortcut>

    public class EncapsulateField
    {
        // 1. Encapsulate Field
        //    Place text caret on field definition
        //    Invoke Encapsulate Field
        //    ReSharper prompts for options - auto property, read/write, visibility, etc.
        public string Name;
    }
}