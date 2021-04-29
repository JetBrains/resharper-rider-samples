namespace JetBrains.ReSharper.Koans.Editing
{
    // Smart Completion
    //
    // Narrows candidates to those that best suit the current context
    //
    // <shortcut id="Smart Completion">Ctrl+Alt+Space (VS)</shortcut>
    //

    public class SmartCompletion
    {
        // 1. Start typing: string s = 
        //    Automatic Completion offers Smart Completion items first (string items)
        //      (followed by local Basic items, wider Basic and then Import items)
        // 2. Uncomment: string s2 = 
        //    Invoke Smart Completion at the end of the line
        //    Smart Completion only shows string based candidates
        //    (Including methods that return string, such as String.Concat)
        // 3. Uncomment: string s3 = this.
        //    Invoke Smart Completion at the end of the line
        //    Smart Completion only shows string based candidates for the this parameter
        // Note that the Age property isn't used
        public void SmartUseString(string stringParameter)
        {
            //string s2 = 
            //string s3 = this.
        }

        public int Age { get; set; }

        #region Implementation details

        public string Name { get; set; }
        public string GetGreeting()
        {
            return "hello";
        }

        #endregion
    }
}