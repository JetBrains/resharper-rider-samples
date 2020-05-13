namespace JetBrains.ReSharper.Koans.Navigation
{
    // Find Usages
    //
    // Finds usages and displays in the Find Results window
    //
    // <shortcut id="Find Usages">Shift+F12</shortcut>
    //

    public class FindUsages
    {
        // 1. Put the caret on ButtonText and Find Usages
        //    Note that ReSharper has found read and write usages
        //    It has also found usages of the type in a XAML control
        //    And has inferred a dynamic usage in the XAML control where no type is specified
        // 2. In the Find Results window, check out the right click and toolbar options
        //    Note the group by options, filtering by usage and merging usages on the same line
        //    Turn on code preview
        public string ButtonText { get; set; }

        // Ensures ButtonText is in the correct format
        public void CleanupText()
        {
            ButtonText = ButtonText.Trim();
            ButtonText = ButtonText.ToLowerInvariant();
        }
    }
}