using System;

namespace JetBrains.ReSharper.Koans.LiveTemplates
{
    // Surround with
    //
    // Ctrl+E, U (VS)
    // Ctrl+Alt+J (IntelliJ)
    // Alt+Enter when text is selected
    //
    public class SurroundTemplates
    {
        // 1. Wrap code in a try/catch
        //    Select the method call and the Console.WriteLine
        //    Invoke Surround with, or hit Alt+Enter
        //    Select try/catch
        //    Edit the type of exception you want to catch, e.g. InvalidOperationException
        //    Tab to the name of the exception, and change if you want
        //    Tab again, and the Console.WriteLine is highlighted, ready to be replaced with e.g. throw;
        //
        // 2. View the try/catch surround template
        //    ReSharper → Templates Explorer → Surround Templates → try..catch
        //    Note the $SELECTION$ parameter. This is the currently selected text
        //    Note the $SELSTART$ and $SELEND$ macros. These are used to mark the
        //      start and end of the selection after the template has been invoked,
        //      and all editable macros have been edited
        //    Note the $END$ macro. This is the final position of the text caret
        //      once editing of the expanded template is complete
        public void SurroundWithTryCatch()
        {
            var result = ThisMethodThrowsExceptions();
            Console.WriteLine(result);
        }

        private string ThisMethodThrowsExceptions()
        {
            throw new InvalidOperationException();
        }

        // 2. Create a surround template to surround with quotes
        //    Go to ReSharper → Templates Explorer → Surround Templates
        //    Click the New Template toolbar icon
        //    Change the text to (including quotes): "$SELECTION$"
        //    Enter a description - quote
        //    Save the template (note that it isn't in the quicklist secton yet)
        //    Select the message variable usage in the first Console.WriteLine and invoke
        //      Surround With, select More... and then select "quote"
        //    Go to Templates Explorer → Surround Templates and drag and drop the quote
        //      template into the quicklist section
        //    Select the message variable usage in the second Console.WriteLine and invoke
        //      Surround With and select "quote"
        public void SurroundWithQuotes()
        {
            const string message = "This is the message";

            Console.WriteLine(message);
            Console.WriteLine(message);
        }
    }
}