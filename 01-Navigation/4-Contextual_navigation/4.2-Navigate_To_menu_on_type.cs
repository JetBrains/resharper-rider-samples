using System;
using System.ComponentModel;
using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Navigate To menu - Menu on Type
    //
    // This is a convenient way to navigate from the current location.
    // See "4.1-Navigate_To_menu.cs" for the basic mechanism.
    //
    // How to use Navigate to
    // <shortcut id="Navigate to">Alt+`        (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Navigate to">Ctrl+Shift+G (Rider Default IntelliJ Keymap)</shortcut>
    //
    // Put the caret on the target and use the keyboard shortcut.
    //

    // 1. When the caret is on a type definition (DerivedClass)
    //    The following candidates will be displayed.
    //      - Declaration           : Navigate to Declaration
    //      - Implementation        : Navigate to Implementation
    //      - Base Symbols          : Navigate to Base Class
    //      - Find Usages of Symbol : (*1)
    //      - Related Files...      : (*1)
    //      - Usages of Symbol      : (*1)
    //      - Derived Symbols       : Navigate to Derived Class
    //      - Extension methods     : Navigate to Extension methods
    //      - Consuming APIs        : Navigate to method(s) taking this type as a parameter
    //      - Exposing APIs         : Navigate to method(s) returning this type
    //      - Referenced Code       : Find all the code where the type is referenced ( e.g. BaseClass )
    //      - Locate in Solution Explorer   : (Only ReSharper) Navigate to current file in Solution Explorer
    //
    //    (*1) Find Usages of Symbol, Usages of Symbol, and Related files
    //         will be explained in detail later in this workshop.
    //
    public class DerivedClass   // <- Text caret on DerivedClass
        : BaseClass
    {
    }


    // 2. When the caret is on a base class (BaseClass)
    //    The candidates will be displayed again.
    //
    //    In the case of this class,
    //    since it has overridden method definitions,
    //    ReSharper and Rider will correctly recognize it
    //    and display it as a candidate.
    //      - Overriding members    : Highlight all overridden methods
    //                                Escape clears the highlight
    //
    // (Reference) How to move between candidates
    //
    // NOTE: Rider shortcuts are undefined by default (no configuration) and must be configured to work.
    // Settings | Keymap | Main Menu | Edit | Find Usages
    //  - Next Highlighted Usage
    //  - Previous Highlighted Usage
    //
    //   <shortcut id="Go to Next/Previous">Ctrl+Alt+PageUp/Ctrl+Alt+PageDown (ReSharper VisualStudio Keymap)</shortcut>
    //   <shortcut id="Find Next/Previous"> F3 / Shift+F3                     (Rider Default IntelliJ Keymap)</shortcut>
    //
    //   (ReSharper) https://www.jetbrains.com/help/resharper/Navigation_and_Search__Navigate_from_Here__Overriding_Members.html
    //   (Rider)     https://www.jetbrains.com/help/rider/Navigation_and_Search__Navigate_from_Here__Overriding_Members.html
    //
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
    //    The candidates will be displayed again.
    //
    //    ReSharper and Rider will correctly recognize
    //    that it is an Interface and display it as a candidate.
    //      - Implementing members  : Highlight all Interface methods
    //                                Escape clears the highlight
    //
    // (Reference) How to move between candidates
    //
    // NOTE: Rider shortcuts are undefined by default (no configuration) and must be configured to work.
    // Settings | Keymap | Main Menu | Edit | Find Usages
    //  - Next Highlighted Usage
    //  - Previous Highlighted Usage
    //
    //   <shortcut id="Go to Next/Previous">Ctrl+Alt+PageUp/Ctrl+Alt+PageDown (ReSharper VisualStudio Keymap)</shortcut>
    //   <shortcut id="Find Next/Previous"> F3 / Shift+F3                     (Rider Default IntelliJ Keymap)</shortcut>
    //
    //   (ReSharper) https://www.jetbrains.com/help/resharper/Navigation_and_Search__Navigate_from_Here__Overriding_Members.html
    //   (Rider)     https://www.jetbrains.com/help/rider/Navigation_and_Search__Navigate_from_Here__Overriding_Members.html
    //
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
    //    The candidates will be displayed again.
    //
    //    The key points here are as follows:
    //    a) Doing Go To Derived Symbols on IComponent will only show SimpleComponent
    //    b) Navigate to Declaration of IComponent and then doing Go To Derived Symbols
    //       widens the scope, and includes all referenced assemblies, showing many more
    //       derived types
    //
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
