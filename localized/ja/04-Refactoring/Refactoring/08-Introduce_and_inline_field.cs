﻿using System;
using System.Collections.Generic;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Introduce Field
    //
    // Create a field in the current class from selection
    //
    // <shortcut id="Introduce Field...">Ctrl+R, F (VS)</shortcut>
    //

    // Inline Field
    //
    // Replaces field usage with the contents of the field
    //
    // <shortcut id="Inline...">Ctrl+R, I (VS)</shortcut>
    //

    public class IntroduceAndInlineField
    {
        public void InitialiseFactory()
        {
            // 1. Introduce Field
            //    Place the caret on button and invoke Introduce Field
            //    Choose name and where to initialise field - current location, field initialiser or constructor
            //    Choose visibility (private, public, etc.) and if to make static/readonly
            var form = new Factory();
            var button = new Widget();
            form.Widgets.Add(button);
        }

        public void InitialiseFactory2()
        {
            // 2. Introduce Field for multiple instances
            //    Select "new Button()" (Use expand selection <shortcut id="Extend Selection">Ctrl+Alt+Right</shortcut> and <shortcut id="Shrink Selection">Ctrl+Alt+Left (VS)</shortcut>)
            //    Invoke Introduce Field
            //    ReSharper highlights all usages across ALL methods, prompts for one usage, all across methods or all in this method
            //    Choose name and where to initialise field - current location, field initialiser or constructor
            //    Choose visibility (private, public, etc.) and if to make static/readonly
            var form = new Factory();
            form.Widgets.Add(new Widget());
            form.Widgets.Add(new Widget());
            form.Widgets.Add(new Widget());
        }

        public void IntroduceConstant()
        {
            // 3. Introduce Constant
            //    Select the "Hello world" string literal
            //    Invoke Introduce Field
            //    Select Introduce Constant on dialog (<shortcut id="Inline...">Ctrl+R, I (VS)</shortcut>)
            Console.WriteLine("Hello world");
        }

        private const int MyField = 23;

        public void InlineField()
        {
            // 4. Inline Field
            //    Place caret on MyField
            //    Invoke Inline Field
            Console.WriteLine(MyField);
        }

        private const int MyOtherField = 23;

        public void InlineFieldOnMultipleInstances()
        {
            // 5. Inline Field
            //    Place caret on MyOtherField
            //    Invoke Inline Field
            Console.WriteLine(MyOtherField);
            Console.WriteLine(MyOtherField);
            Console.WriteLine(MyOtherField);
        }
    }

    public class Factory
    {
        public List<Widget> Widgets { get; set; }
            = new List<Widget>();
    }

    public class Widget
    {
    }
}