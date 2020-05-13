namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Change Signature
    //
    // Update a method signature, adding, removing or reordering parameters
    //
    // <shortcut id="Change Signature...">Ctrl+R, S (VS)</shortcut>
    //

    public class ChangeSignature
    {
        // 1. Change method signature
        //    Place text caret on Method and invoke Change Signature
        //    In dialog, change name, return type and parameters
        //    Can add, remove, reorder parameters, change type and modifier (ref, out)
        //    Add an int parameter called "iq". Click next
        //    ReSharper prompts how to handle the new parameter in calling code
        //    Can leave code non-compilable, use a default value (0), use a specific value
        //      or resolve with call tree
        // 1a. Select resolve with call tree
        //     Refactoring tool window opens showing CallMethod usage and three options
        //       user edit, create field "iq", create parameter "iq" in CallMethod
        //     Selecting any of these options updates the calling code
        //     Can uncheck and select other option
        //     Close tool window when done
        public void Method(string name, int age)
        {
        }

        public void CallMethod()
        {
            Method("Deborah", 32);
        }
    }

    public class ApplyChangeSignatureRefactoring
    {
        // 2. Apply Change Signature refactoring, after change
        //    MANUALLY add a parameter, ReSharper highlights signature with dotted line
        //    Alt+Enter and select Apply Change Signature Refactoring
        //    ReSharper displays dialog with visualisation of the change
        public void AddParameterMethod(string name, int age)
        {
        }

        // 3. Apply Change Signature refactoring, after change
        //    MANUALLY reorder the parameters
        //    (<shortcut id="Move Element Left">Ctrl+Shift+Alt+Left</shortcut> or <shortcut id="Move Element Right">Ctrl+Shift+Alt+Right</shortcut>)
        //    ReSharper highlights signature with dotted line
        //    <shortcut id="Show context actions">Alt+Enter</shortcut> and select Apply Change Signature Refactoring
        //    ReSharper displays dialog with visualisation of the change
        public void ReorderMethod(string name, int age)
        {
        }

        public void CallMethods()
        {
            AddParameterMethod("Deborah", 32);
            ReorderMethod("Deborah", 32);
        }
    }
}