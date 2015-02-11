namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Move Refactoring
    //
    // Move a type to another file, folder or namespace
    //
    // Ctrl+R, O (VS)
    // F6 (IntelliJ)

    // 1. Move to another file
    //    Place text caret on type definition
    //    Invoke Move refactoring
    //    Select Move to another file
    //    ReSharper suggests file name
    //    Accepting moves file, existing code still works
    public class MoveToAnotherFile
    {
        public void Method()
        {
        }
    }

    // 2. Move to another folder
    //    Place text caret on type definition
    //    Invoke Move refactoring
    //    Select Move to another folder
    //    ReSharper suggests classes to move and folder location
    //    Start typing new location - ReSharper provides suggestions of existing folders and projects
    //    Add "\MoveTarget" to end of current location
    //    ReSharper shows a validation error as the folder does not exist
    //    Click "Create this folder"
    //    Accept move, check type is moved to new location
    public class MoveToAnotherFolderInProject
    {
        public void Method()
        {
        }
    }

    // 4. Move to another namespace
    //    Place text caret on type definition
    //    Invoke Move Refactoring
    //    Select Move to another namespace
    //    ReSharper suggests current namespace - add ".Target" to end of namespace
    //      (namespace should be JetBrains.ReSharper.Koans.Refactoring.Target)
    //    ReSharper moves the type to that namespace, but keeps type in current file
    //    Type should be at bottom of file
    public class MoveToAnotherNamespace
    {
        public void Method()
        {
        }
    }

    public class UsesOtherClasses
    {
        public void CallsMethods()
        {
            // 5. Ensure all types are still referenced correctly
            new MoveToAnotherFile().Method();
            new MoveToAnotherFolderInProject().Method();
            new MoveToAnotherNamespace().Method();
        }
    }
}

namespace JetBrains.ReSharper.Koans.Refactoring.Target
{
}