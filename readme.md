[![official project](http://jb.gg/badges/official-plastic.svg)](https://confluence.jetbrains.com/display/ALL/JetBrains+on+GitHub)

# ReSharper/Rider Workshop

In these materials, you'll learn about many of the features and productivity enhancements available in [ReSharper](https://jetbrains.com/resharper). It provides step by step exercises for navigation, editing, inspections, refactoring and more. While it doesn't cover EVERY feature in ReSharper (we like to have some surprises), it does give many, many useful tips and tricks to both beginners and long time users.

Each exercise also introduces the keyboard shortcuts that can be used to work with ReSharper more efficiently. Should you want to see all the shortcuts in one place, you can download a keyboard shortcut cheat sheet from the [JetBrains documentation web site](https://www.jetbrains.com/resharper/documentation/), either for the [Visual Studio keyboard scheme](https://www.jetbrains.com/resharper/docs/ReSharper90DefaultKeymap_VS_scheme.pdf), or the [IntelliJ scheme](https://www.jetbrains.com/resharper/docs/ReSharper90DefaultKeymap_IDEA_scheme.pdf).

The workshop is self-paced, meaning you can work your way through the exercises on your own, at your own speed. You can skip sections you're already familiar with (although you might miss some useful tips!), and can work on the exercises in any order.

## Getting started

Simply get a copy of the repo (clone or download straight) and open the `resharper-rider-samples.sln` in Visual Studio. It is recommended to build the solution at least once before starting, as this will restore various NuGet packages used by some of the exercises (many exercises do not require compiling, such as navigation and editing, but others require compiling code, or referencing third party assemblies, such as unit testing and asp.net MVC support)

The exercises are structured into numbered solution folders. Each folder contains one or more projects, and the exercises themselves are usually described in comments inside the source to these projects. Simply open the files and work through the exercises at your own pace.

The exercises are:

* `00-EssentialShortcuts` - introduces the handful of keyboard shortcuts you need to know in order to get started with ReSharper. These shortcuts invoke the "entry points" to the majority of ReSharper's functionality.
* `01-Navigation` - demonstrates the various ways of navigating around your codebase, looking at Go To, Find Usages, navigating class hierarchies and more.
* `02-Editing` - exercises for editing your code, including code completion, completing statements, rearranging code, etc.
* `03-Inspections` - an introduction to the many code inspections that ReSharper provides, seeing how they can find potential issues with your code, and how to fix them, and manage them. Also looks at the very powerful value tracking analysis feature.
* `04-Refactoring` - exercises to see how ReSharper supports refactoring your code base, from simple renames to introducing and inlining variables, to extracting classes, moving members up and down type hierarchies and more.
* `05-LanguagesAndFrameworks` - a large part of ReSharper's functionality applies to all languages that ReSharper supports. However, ReSharper also provides specific support for certain frameworks and languages, such as asp.net MVC, XAML or regular expressions.
* `06-UnitTesting` - exercises to show how ReSharper supports unit testing
* `07-LiveTemplates` - looks at the powerful text snippet expansion, with interactive macros and editable hotspots. Also looks at creating files and surrounding selected text based on templates.
* `08-StructuralSearchAndReplace` - learn how to use ReSharper's very powerful search and replace functionality that is based on code patterns rather than text.
* `09-Tools` - useful tools, such as code cleanup, stack trace explorer and the To Do explorer.

## Open Source

The workshop is Open Source, licensed under the Apache 2 license. If you would like to contribute to the workshop materials, please feel free to fork the repo and send us a pull request. Or if you have a comment, question, or suggestion for improvements, please [raise an issue](https://github.com/JetBrains/resharper-workshop/issues).
