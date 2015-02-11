using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    // Toggle line comment
    //
    // Ctrl+Alt+/ (VS)
    // Ctrl+/ (IntelliJ)

    // Toggle block comment
    //
    // Ctrl+Shift+/ (VS + IntelliJ)

    // 1. Toggle comment on single line
    //    Place caret on line below, select Ctrl+D
    using System.Collections;

    // 2. Toggle comment on multiple lines
    //    Select both lines, invoke Toggle line comment
    //    Toggle line comment to uncomment again
    using System.Collections;
    using System.Data;

    // 3. Toggle block comment
    //    Inserts block comment at text caret location
    //    Toggle removes it again
    using System.Collections;

    // 4. Comment selection with block comment
    //    Select some text, invoke block comment
    //    Only creates block comment, doesn't remove
    using System.Collections;
}