// Navigate To menu - Basics
//
// Displays a contextual menu of options you can use to navigate to from
// your current location
//
// Very useful way of navigating without having to learn ALL of the shortcuts!
//
// https://www.jetbrains.com/help/resharper/Navigation_and_Search__Navigate_from_Here.html
// https://www.jetbrains.com/help/rider/Navigation_and_Search__Navigate_from_Here.html
//
// <shortcut id="Navigate to">Alt+`        (ReSharper VisualStudio Keymap)</shortcut>
// <shortcut id="Navigate to">Ctrl+Shift+G (Rider Default IntelliJ Keymap)</shortcut>
//
// Put the caret on the target and let it run.
// ReSharper and Rider are smart enough to identify the object
// on which the caret is placed and provide the movement capabilities
// that the implementor wants from the object, context, and background.
// (In other words, the menu will change depending on where the caret is placed.)
//
// Supplemental
//
// For the Rider Default IntelliJ Keymap, remember it as Go!
// (the "G"o in Ctrl+Shift+"G").
//
// After pressing this key on the target, you will see some actions to move from there.
// You can navigate to definition, find usages, and more.
//
// Try this keystroke any time while developing:
// you will naturally learn more about navigating with ReSharper and Rider
//


// 1. Works on all symbols, including using statements
//    Run on the namespace and check that the following menu is listed.
//      Declaration
//      Implementation
//      Find Usage of Symbol
//      Usage of Symbol
//
//  Note
//  Make sure that you open the ".sln" in the root directory of "resharper-rider-samples/".
//  If you open the directory of the localized version
//  ( e.g. resharper-rider-samples/localized/ja ),
//  the project side of the localized version will be loaded
//  and the reference relationship will not be displayed correctly in the list.
//
using System;
using System.Collections.Generic;
using System.ComponentModel;

// 2. Works on namespaces
namespace JetBrains.ReSharper.Koans.Navigation
{
}
