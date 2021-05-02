[![official project](http://jb.gg/badges/official-plastic.svg)](https://confluence.jetbrains.com/display/ALL/JetBrains+on+GitHub)

[Localized versions](./localized) are available for some languages:
- [Japanese (日本語)](./localized/ja)

# ReSharper/Rider Workshop

In these materials, you'll learn about many of the features and productivity enhancements available in [ReSharper](https://jetbrains.com/resharper) and [Rider](https://jetbrains.com/rider).

It provides step by step exercises for navigation, editing, inspections, refactoring and more. While it doesn't cover EVERY feature in ReSharper and Rider (we like to have some surprises), it does give many, many useful tips and tricks to both beginners and long time users.

Each exercise also introduces the keyboard shortcuts that can be used to work with ReSharper and Rider more efficiently. Should you want to see all the shortcuts in one place, you can download a keyboard shortcut cheat sheet from our website.

* [JetBrains ReSharper documentation web site](https://www.jetbrains.com/resharper/documentation/)
  * [Visual Studio keyboard scheme](https://www.jetbrains.com/resharper/docs/ReSharper90DefaultKeymap_VS_scheme.pdf)
  * [IntelliJ scheme](https://www.jetbrains.com/resharper/docs/ReSharper90DefaultKeymap_IDEA_scheme.pdf)
* [JetBrains Rider documentation website](https://www.jetbrains.com/rider/documentation/) ([overview of Rider keymaps](https://www.jetbrains.com/help/rider/Reference_Keyboard_Shortcuts_Index.html))
  * [Visual Studio keyboard scheme](https://www.jetbrains.com/help/rider/Reference_Keymap_VS.html)
  * [Rider scheme](https://www.jetbrains.com/help/rider/Reference_Keymap_Rider.html)

The workshop is self-paced, meaning you can work your way through the exercises on your own, at your own speed. You can skip sections you're already familiar with (although you might miss some useful tips!), and can work on the exercises in any order.

## Getting started

Simply get a copy of the repo (clone or download straight) and open the `resharper-rider-samples.sln` in Visual Studio or Rider. It is recommended to build the solution at least once before starting, as this will restore various NuGet packages used by some of the exercises (many exercises do not require compiling, such as navigation and editing, but others require compiling code, or referencing third party assemblies, such as unit testing and ASP.NET MVC support)

The exercises are structured into numbered solution folders. Each folder contains one or more projects, and the exercises themselves are usually described in comments inside the source to these projects. Simply open the files and work through the exercises at your own pace.

The exercises are:

* `00-EssentialShortcuts` - introduces the handful of keyboard shortcuts you need to know in order to get started with ReSharper. These shortcuts invoke the "entry points" to the majority of ReSharper and Rider functionality.
* `01-Navigation` - demonstrates the various ways of navigating around your codebase, looking at Go To, Find Usages, navigating class hierarchies and more.
* `02-Editing` - exercises for editing your code, including code completion, completing statements, rearranging code, etc.
* `03-Inspections` - an introduction to the many code inspections that ReSharper and Rider provide, seeing how they can find potential issues with your code, and how to fix them, and manage them. Also looks at the very powerful value tracking analysis feature.
* `04-Refactoring` - exercises to see how ReSharper and Rider supportsrefactoring your code base, from simple renames to introducing and inlining variables, to extracting classes, moving members up and down type hierarchies and more.
* `05-LanguagesAndFrameworks` - a large part of ReSharper and Rider functionality applies to all languages that ReSharper supports. However, ReSharper and Rider also provides specific support for certain frameworks and languages, such as asp.net MVC, XAML or regular expressions.
* `06-UnitTesting` - exercises to show how ReSharper and Rider support unit testing
* `07-LiveTemplates` - looks at the powerful text snippet expansion, with interactive macros and editable hotspots. Also looks at creating files and surrounding selected text based on templates.
* `08-StructuralSearchAndReplace` - learn how to use ReSharper and Rider's very powerful search and replace functionality that is based on code patterns rather than text.
* `09-Tools` - useful tools, such as code cleanup, stack trace explorer and the To Do explorer.

# Learn essential shortcuts

In this workshop, you can learn the essential functions provided by ReSharper and Rider that you need to master.
These essential functions can be easily and directly accessed with shortcuts.

There are many shortcut keys, but if you have trouble, you can search for them.
We recommend that you print out the cheat sheet described below and mark it with a marker, as it will show you how to find them when you have trouble.

## Shortcuts And Actions

Through out this guided experience, you will see "shortcut" tags. These tags include the official name of each action and can be found
using the the `Find Action...` feature of your IDE. Reference your preferences to find out what that shortcut is, but here are a few known
shortcut combinations: 

- ReSharper Keymap on Windows: `Ctrl + Shift + A`
- Visual Studio Keymap on Windows: `Ctrl + Shift + A`
- Visual Studio Keymap on macOS: `Command (⌘) + Shift (⇧) + A`

There are cheat sheets for shortcut keys:

- Help \| Keymap Reference

It is recommended that you go to above, select the cheat sheet for your chosen Keymap, print it out, and keep it deskside.

Also the Keymap reference guide is also available online :

- Rider: https://www.jetbrains.com/help/rider/Reference_Keymap_Rider.html
- ReSharper: https://www.jetbrains.com/help/resharper/Reference__Keyboard_Shortcuts.html

## Open Source

The workshop is Open Source, licensed under the Apache 2 license. If you would like to contribute to the workshop materials, please feel free to fork the repo and send us a pull request. Or if you have a comment, question, or suggestion for improvements, please [raise an issue](https://github.com/JetBrains/resharper-workshop/issues).
