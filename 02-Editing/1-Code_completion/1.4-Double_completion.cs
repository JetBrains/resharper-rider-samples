namespace JetBrains.ReSharper.Koans.Editing
{
    // Double Completion
    //
    // Invoking Basic, Import or Smart Completion multiple times
    // Provides more candidates by looking at members of the previous list of candidates

    public class DoubleCompletion
    {
        public void DoubleSmartCompletion()
        {
            // 1. Uncomment the following line
            //    Invoke Smart Completion at the end of the line
            //    Invoke Smart Completion again (it should say 2xSmart at the bottom of the window)
            //    Note that ReSharper is now offering candidates from the return values of the first
            //      Smart Completion invocation (i.e. instance methods on string)
            //string s3 = this.
        }

        public void DoubleImportCompletion()
        {
            // 2. Start typing Button
            //    Automatic Completion doesn't find anything
            //    Invoke Import Completion twice (it should say 2xImport at the bottom of the window)
            //    Import Completion should find Button in an assembly referenced by a project in the solution
            //    It can now add a reference to System.Windows.Forms.dll and import System.Windows.Forms.Button

            // Button
        }

        public void DoubleAutomaticCompletion()
        {
            // 3. Since Automatic Completion combines Smart and Import (and Basic) completion,
            //    double Automatic Completion will also work the same
            //    Start typing GridView
            //    Invoke Automatic Completion twice (it should say 2xBasic at the bottom of the window)
            //    Automatic Completion will find GridView in PresentationFramework
            //    It can now add a reference to PresentationFramework.dll and import System.Windows.Controls.GridView

            //GridView
        }

        public void ChainedDoubleCompletion()
        {
            // 4. Chain Automatic Completion with Smart Completion to get at the relevant members or the original list
            //    Uncomment the following line
            //    Invoke Basic Completion at the end of the line
            //    All members are listed, including the Age property, which is an int, not a string
            //    Invoke Smart Completion (it should say Basic, Smart at the bottom of the window)
            //    Smart Completion has now found relevant members of the candidates of the first list
            //    e.g. Age.ToString - Basic Completion found Age, Smart Completion got all the members returning string on Age

            //string s3 = this.
        }

        #region Implementation details

        public int Age { get; set; }
        public string Name { get; set; }
        public string GetGreeting()
        {
            return "hello";
        }

        #endregion

    }
}