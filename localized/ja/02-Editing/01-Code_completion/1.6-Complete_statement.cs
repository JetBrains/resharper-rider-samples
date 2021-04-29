using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    // Complete Statement
    //
    // Finish the current statement and move the caret to the next position ready for editing
    //
    // <shortcut id="Complete Current Statement">Ctrl+Shift+Enter</shortcut> (VS + IntelliJ)

    public class CompleteStatement
    {
        public void CompleteSimpleStatement()
        {
            // 1. Complete simple statement
            //    Uncomment the uncompleted statement below
            //    Place the caret anywhere in the statement
            //    Invoke Complete Statement

            // Console.WriteLine("Hello
        }

        public void CompleteIfStatement()
        {
            // 2. Complete if statement
            //    Uncomment the uncompleted if statement below
            //    Place the caret anywhere in the statement
            //    Invoke Complete Statement

            //if (true
        }

        public void CompleteComplexStatement()
        {
            // 3. Complete complex statement
            //    Uncomment the uncompleted if statement below
            //    Place the caret anywhere in the statement
            //    Invoke Complete Statement

            //Console.WriteLine(Blah("Hello"
        }

        #region Implementation details

        private string Blah(string value)
        {
            return value.ToUpperInvariant();
        }

        #endregion
    }
}