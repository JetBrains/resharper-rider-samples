namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Move Refactoring
    //
    // Move a type to another file, folder or namespace
    //
    // <shortcut id="Move...">Ctrl+R, O (VS)</shortcut>
    //

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

    // 2. Move to another folder in the project
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

    // 3. Move to another folder in another project
    //    Place text caret on type definition
    //    Invoke Move refactoring
    //    Select Move to another folder
    //    ReSharper suggests classes to move and folder location
    //    Start typing new location - ReSharper provides suggestions of existing folders and projects
    //    Add "-MoveTarget" to end of current location
    //      (Target folder should be: "04 Refactoring\Refactoring-MoveTarget")
    //    Accept move, check type is moved to the new project
    //    ReSharper detects there is no reference between this project and Refactoring-MoveTarget
    //    Can Cancel the refactoring and add the reference
    //    Or continue, and fix up the reference by Alt+Enter on the broken usage below
    public class MoveToAnotherFolderInOtherProject
    {
        public void Method()
        {
        }
    }

    // 4. Move to another namespace
    //    Place text caret on type definition
    //    Invoke Move Refactoring
    //    Select Move to another namespace
    //    ReSharper suggests current namespace - add ".MoveTarget" to end of namespace
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
            new MoveToAnotherFolderInOtherProject().Method();
            new MoveToAnotherNamespace().Method();
        }
    }
}

namespace JetBrains.ReSharper.Koans.Refactoring.MoveTarget
{
}