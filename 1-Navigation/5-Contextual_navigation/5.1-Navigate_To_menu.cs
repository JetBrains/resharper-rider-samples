using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Navigate To menu
    //
    // Displays a contextual menu of options you can use to navigate to from
    // your current location
    //
    // Very useful way of navigating without having to learn ALL of the shortcuts!
    //
    // Alt+` (VS)
    // Ctrl+Shift+G (IntelliJ)
    //

    // 1. When the caret is on a type definition (DerivedClass)
    //    (Find Usages, related files covered later)
    //    a) Go to Base Symbols + Derived Symbols
    //    b) Extension methods
    //    c) Object Browser, Windows Explorer, Command Prompt
    //    d) Locate in Solution Explorer
    //    d) Referenced Code finds all code referenced by the type, e.g. BaseClass
    public class DerivedClass : BaseClass
    {
    }

    // 2. When the caret is on a base class (BaseClass)
    //    a) As above
    //    b) Declaration navigates to the declaration of BaseClass
    //    c) Implementation navigates to the implementations of BaseClass - deriving symbols
    //    d) Overriding members highlights all members that override from BaseClass
    //       Escape clears the highlight
    //       Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ) to navigate between
    public class DerivedClass2 : BaseClass
    {
        public override void VirtualMethod()
        {
        }

        public override string VirtualProperty
        {
            get { return "cheese"; }
        }
    }

    // 3. When the caret is on an implemented interface (ISimpleInterface)
    //    a) as above
    //    b) Implementing Members highlights all members of the interface
    //       Escape clears the highlight
    //       Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ) to navigate between
    public class SimpleClass : ISimpleInterface
    {
        public void SayHello()
        {
            Console.WriteLine("hello");
        }

        public void SayGoodbye()
        {
            Console.WriteLine("goodbye");
        }
    }

    // 4. When the caret is on an implementing interface defined in another assembly
    //    a) Doing Go To Derived Symbols on IComponent will only show SimpleComponent
    //    b) Navigate to Declaration of IComponent and then doing Go To Derived Symbols
    //       widens the scope, and includes all referenced assemblies, showing many more
    //       derived types
    public class SimpleComponent : IComponent
    {
        #region Implementation details

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ISite Site { get; set; }
        public event EventHandler Disposed;

        #endregion
    }

    // 5. When the caret is on a method
    public class NavigateToForMethod
    {
        // a) Member overloads highlights overloads of the method
        //    Escape clears the highlight
        //    Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ) to navigate between
        public bool Do()
        {
            return true;
        }

        // b) Function exit(s) highlights return statements
        //    Escape clears the highlight
        //    Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ) to navigate between
        public bool Do(string arg1)
        {
            if (string.IsNullOrEmpty(arg1))
                return false;
            Console.WriteLine("do!");
            return true;
        }

        public bool Do(string arg1, string arg2)
        {
            return false;
        }
    }

    // 6. When caret is on a control flow keyword
    public class NavigateToControlFlowKeyword
    {
        public void ControlFlowWithForStatement()
        {
            for (int i = 0; i < Children.Count; i++)
            {
                var child = Children[i];

                // a) Place the caret on "continue". Navigate To -> Control Flow Target
                //    takes the caret to the i++ in the for declaration
                if (ShouldSkipChild(child))
                    continue;

                // b) Place the caret on "break". Navigate To -> Control Flow Target
                //    takes the caret to the next statement after the loop
                if (ShouldStop(child))
                    break;

                // c) Place the caret on "return". Navigate To -> Control Flow Target
                //    takes the caret to the closing brace of the function
                if (ShouldQuit(child))
                    return;
            }

            Console.WriteLine("Finished loop");
        }

        public void ControlFlowWithSwitchStatement(Size size)
        {
            switch (size)
            {
                case Size.Large:
                    // d) Place the caret on "break". Navigate To -> Control Flow Target
                    //    takes the caret to the first statement after the switch
                    break;
                case Size.Medium:
                    // e) Place the caret on "return". Navigate To -> Control Flow Target
                    //    takes the caret to the closing brace of the function
                    return;
                case Size.Small:
                    // e) Place the caret on "throw". Navigate To -> Control Flow Target
                    //    takes the caret to the closing brace of the function
                    throw new ArgumentOutOfRangeException("size");
            }

            Console.WriteLine("Finished switch");
        }

        #region Implementation details

        private IList<string> Children { get { return new List<string>(); } }

        private bool ShouldSkipChild(string child)
        {
            return child == "Barry";
        }

        private bool ShouldStop(string child)
        {
            return child == "Rocky";
        }

        private bool ShouldQuit(string child)
        {
            return child == "Damien";
        }

        public enum Size
        {
            Large,
            Medium,
            Small
        }

        #endregion
    }

    // 7. When caret is on a symbol
    public class WhenCaretIsOnSymbol
    {
        public void NavigateToSymbolType()
        {
            // a) Place caret on "stuff". Navigate To -> Type of Symbol
            //    takes caret to declaration of BaseClass
            var stuff = new BaseClass();
        }
    }

    #region Implementation details

    public interface ISimpleInterface
    {
        void SayHello();
        void SayGoodbye();
    }

    // Navigate back (Ctrl+-)
    public class BaseClass
    {
        public virtual void VirtualMethod()
        {
        }

        public virtual string VirtualProperty
        {
            get { return "hello"; }
        }
    }

    public static class BaseClassExtensions
    {
        // Navigate back (Ctrl+-)
        public static void ExtensionMethodForBaseClass(this BaseClass self)
        {
            // ...
        }
    }

    // Navigate back (Ctrl+-)
    public class ReallyDerivedClass : DerivedClass
    {
    }

    #endregion
}