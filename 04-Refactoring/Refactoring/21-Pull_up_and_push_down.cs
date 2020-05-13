using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Pull Members Up
    //
    // Pulls members up the inheritance chain from the current type to the base type.
    // Moves members from a derived type to a base type
    //
    // No keyboard shortcut. Invoke via Refactor This menu
    // <shortcut id="Refactor This...">Ctrl+Shift+R</shortcut>

    // Push Members Down
    //
    // Pushes members down the inheritance chain from the current type to inheriting types.
    // Moves members from a base type to a derived type
    //
    // No keyboard shortcut. Invoke via Refactor This menu
    // <shortcut id="Refactor This...">Ctrl+Shift+R</shortcut>

    namespace PullUp
    {
        public class Base
        {
        }

        public class Derived : Base
        {
        }

        // 1. Pull members up to base type
        //    Invoke Refactor This → Pull Members Up on Derived
        //    Choose the base type to move to (Derived or Base)
        //    Choose the members to move
        public class MostDerived : Derived
        {
            public string PropertyOnDerived { get; set; }
        }
    }

    namespace PushDown
    {
        // 2. Push members down from Base to inheriting types
        //    Invoke Refactor This → Push Members Down on Base
        //    Choose which inheriting types to push to
        //    Choose which members to push down
        public class Base
        {
            public string PropertyOnBase { get; set; }

            // a. Push members down on property that is in use
            //    Invoke Refactor This → Push Members Down on Base
            //    Choose which inheriting types to push to
            //    Choose UsedPropertyOnBase
            //    ReSharper warns that UsedPropertyOnBase cannot be moved
            public string UsedPropertyOnBase { get; set; }
        }

        public class Derived : Base
        {
        }

        public class Derived2 : Base
        {
        }

        public class Consumer
        {
            public void Method()
            {
                var @base = new Base();
                Console.WriteLine(@base.UsedPropertyOnBase);
            }
        }
    }
}