// Navigate To menu
//
// Displays a contextual menu of options you can use to navigate to from
// your current location
//
// Very useful way of navigating without having to learn ALL of the shortcuts!
//
// <shortcut id="Navigate To...">Alt+`</shortcut>
//
// TODO: Not sure this is relevant anymore

// 1. Place text caret here →
//    a) Navigate to Windows Explorer. Opens explorer with current file selected
//    b) Navigate to Command Prompt. Opens command prompt in current directory
//    c) Locate in Solution Explorer. Opens solution explorer with current file selected

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