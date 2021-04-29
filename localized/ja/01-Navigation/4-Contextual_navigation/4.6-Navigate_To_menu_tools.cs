// Navigate To menu
//
// Displays a contextual menu of options you can use to navigate to from
// your current location
//
// Very useful way of navigating without having to learn ALL of the shortcuts!
//
// <shortcut id="Navigate To...">Alt+`</shortcut>
//

// Press <shortcut id="Locate in Solution/Assembly Explorer">Shift+Alt+L</shortcut>
// to locate this file in Solution Explorer.
// Opens solution explorer with current file selected

using System;
using JetBrains.ReSharper.Koans.Navigation;

public class Foo
{
    public Form1 Form2 { get; private set; }

    public void Thing()
    {
        Console.WriteLine("Fast!");

        Form2 = new Form1();
    }
}