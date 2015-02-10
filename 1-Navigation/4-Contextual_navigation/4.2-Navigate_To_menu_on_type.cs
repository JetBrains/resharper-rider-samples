using System;
using System.ComponentModel;
using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

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


    // 1. When the caret is on a type definition (DerivedClass)
    //    (Find Usages, related files covered later)
    //    a) Go to Base Symbols + Derived Symbols
    //    b) Extension methods
    //    c) Object Browser, Windows Explorer, Command Prompt
    //    d) Locate in Solution Explorer
    //    d) Referenced Code finds all code referenced by the type, e.g. BaseClass
    public class DerivedClass   // <- Text caret on DerivedClass
        : BaseClass
    {
    }


    // 2. When the caret is on a base class (BaseClass)
    //    a) As above (find usages, base symbols, etc.)
    //    b) Declaration navigates to the declaration of BaseClass
    //    c) Implementation navigates to the implementations of BaseClass - deriving symbols
    //    d) Overriding members highlights all members that override from BaseClass
    //       Escape clears the highlight
    //       Ctrl+Alt+PgUp/Ctrl+Alt+PgDown (VS) to navigate between
    //       Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ) to navigate between
    public class DerivedClass2
        : BaseClass // <- Text caret on BaseClass
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
    //    a) as above (find usages, base symbols, declarations, implementations, etc.)
    //    b) Implementing Members highlights all members of the interface
    //       Escape clears the highlight
    //       Ctrl+Alt+PgUp/Ctrl+Alt+PgDown (VS) to navigate between
    //       Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ) to navigate between
    public class SimpleClass
        : ISimpleInterface  // <- Text caret on ISimpleInterface
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
    public class SimpleComponent
        : System.ComponentModel.IComponent  // <- Text caret on IComponent
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
}