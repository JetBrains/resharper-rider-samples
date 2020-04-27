using System;
using NUnit.Framework;

namespace JetBrains.ReSharper.Koans.Tools.Common
{
    // Stack Trace Explorer
    //
    // Displays a hyperlinked stack trace from the contents of the clipboard
    //
    // Ctrl+E, T (VS)
    // Shift+Ctrl+E (IntelliJ)

    [TestFixture]
    public class StackTraceExplorer
    {
        // 1. Run this test. It will fail and copy the exception to the clipboard
        // 2. Invoke the Stack Trace Explorer, click on the links for the files, methods and namespaces to navigate
        [STAThread]
        [Test]
        public void CauseExceptionAndCopyToClipboard()
        {
            try
            {
                CallMethod1();
            }
            catch (Exception e)
            {
                TextCopy.Clipboard.SetText("An error occurred while running the test" + Environment.NewLine + Environment.NewLine + e);
                Console.WriteLine("Exception copied to clipboard");
                throw;
            }
        }

        private static void CallMethod1()
        {
            CallMethod2();
        }

        private static void CallMethod2()
        {
            CallMethod3();
        }

        private static void CallMethod3()
        {
            new OtherObject().CallMethod1();
        }
    }

    internal class OtherObject
    {
        public void CallMethod1()
        {
            CallMethod2();
        }

        private void CallMethod2()
        {
            CallMethod3();
        }

        private void CallMethod3()
        {
            throw new NotImplementedException();
        }
    }
}