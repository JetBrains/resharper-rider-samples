using System;
using JetBrains.ReSharper.Koans.Refactoring.ExampleCode;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Rename
    //
    // Renames an element and all usages of it
    //
    // Ctrl+R, R (VS)
    // F2 (IntelliJ)

    public class RenameType
    {
        public static RenameType Create()
        {
            // 1. Rename a type
            //    Place text caret on any usage of type
            //    Invoke rename refactoring and rename
            return new RenameType();
        }

        // Constructor is also renamed
        public RenameType()
        {
        }
    }

    // 2. Rename method, property, variable, field, parameter
    //    Place text caret on method, property, variable, field or parameter name
    //    Invoke rename refactoring and rename
    public class RenameMember
    {
        private const int Value = 42;

        public string Name { get; set; }

        public void Output(string[] args)
        {
            Console.WriteLine(Name);
            Console.WriteLine(Value);
            Console.WriteLine(args);
        }
    }

    public class RenameAcrossFiles
    {
        public void Method()
        {
            // 2. Rename across files
            //    Place text caret on type name or method name
            //    Invoke rename refactoring
            //    Symbols in other file are updated (navigate to check)
            RenameInAnotherFile.StaticMethod();
        }

        public void Method2()
        {
            RenameInAnotherFile.StaticMethod();
        }
    }

    // 3. Undo local rename
    //    If rename is in single file, normal undo (Ctrl+Z) will rename back
    public class UndoLocalRename
    {
        const string Message = "hello world";

        public static void Method()
        {
            Console.WriteLine(Message);
        }
    }

    // 4. Undo rename across files
    //    By default, ReSharper does not open modified files, so Ctrl+Z does not work
    //    Either make ReSharper open the files, or simply rename back
    public class UndoRenameAcrossFiles
    {
        public void Method()
        {
            // 4a. Place text caret on type name or method name
            //     Invoke rename refactoring
            //     On first page, check "To enable undo, open all files with changes after editing"
            //     Rename symbol
            //     The other file is opened, and marked modified
            //     Ctrl+Z will undo the change across all files
            RenameInYetAnotherFile.StaticMethod();
        }

        public void Method2()
        {
            // 4b. Place text caret on type name or method name
            //     Make sure RenameInAnotherFile.cs is closed
            //     Invoke rename refactoring
            //     On first page, UNCHECK "To enable undo, open all files with changes after editing"
            //     Rename symbol
            //     The other file is not opened, but modified
            //     Ctrl+Z will undo the local change, but produce uncompilable code
            //     Redo the local change (Ctrl+Y)
            //     Perform rename refactoring back to original name
            RenameInAnotherAnotherFile.StaticMethod();
        }
    }

    // 5. Renaming in string literals and comments
    //    Place text caret on type definition (not in comment or string literal)
    //    Invoke rename refactoring and rename
    //    Note second page asking confirmation to rename in string literals and comments
    public class RenameInStringLiteral
    {
        // Type name in comment: RenameInStringLiteral
        public const string Message = "Type name in string literal: RenameInStringLiteral";
    }

    public class InlineRename
    {
        public void Method()
        {
            // 6. Inline renaming
            //    If the scope of the change is local, the rename can be performed inline
            //    Place text caret on message
            //    Invoke rename refactoring
            //    Refactoring is applied inline, with suggestions
            const string message = "Hello world";
            Console.WriteLine(message);
        }
    }

    public class RenameRelatedSymbols
    {
        private readonly RenameParameter renameParameter;

        // 7. Rename related symbols
        //    When renaming a type that is assigned to a variable, field or parameter, ReSharper prompts to rename the assigned to symbol
        //    Place text caret on RenameParameter
        //    Invoke rename refactoring
        //    Type is renamed, ReSharper prompts to rename the parameter and the field
        public RenameRelatedSymbols(RenameParameter renameParameter)
        {
            this.renameParameter = renameParameter;
        }

        public class RenameParameter
        {
        }
    }

    // 7a. Rename related symbols in derived classes
    //     Place text caret on arg
    //     Invoke rename refactoring and rename parameter
    //     ReSharper prompts to rename the same parameter in the derived class
    public interface IThing
    {
        void Method(string arg);
    }

    public class Thing : IThing
    {
        public void Method(string arg)
        {
        }
    }


    // 8. Apply rename refactoring, after change
    //    After changing the name of a symbol manually, ReSharper can apply the rename refactoring
    //    Place text caret on ApplyRenameRefactoring
    //    MANUALLY change the type name (do not invoke refactoring)
    //    Note the dotted line around the type name
    //    Alt+Enter and select "Apply rename refactoring"
    public class ApplyRenameRefactoring
    {
        public static ApplyRenameRefactoring Create()
        {
            return new ApplyRenameRefactoring();
        }

        // 8a. Cancel apply rename refactor prompt with Escape
        //     Place text caret on Name
        //     MANUALLY change the property name (do not invoke refactoring)
        //     Note the dotted line around the propert name
        //     Hit Escape to cancel the dotted line
        public string Name { get; set; }
    }
}