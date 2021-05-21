// Navigate To menu - tools
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

// 1. Displays the location of the open file in Solution Explorer
//
//    See "4.8-Navigate_To_menu_file_nearby.md" for the basic mechanism.
//
// <shortcut id="Locate in Solution Explorer">Shift+Alt+L (ReSharper VisualStudio Keymap)</shortcut>
// <shortcut id="Select Opened File">         Alt+F1, 1   (Rider Default IntelliJ Keymap)</shortcut>
//

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
