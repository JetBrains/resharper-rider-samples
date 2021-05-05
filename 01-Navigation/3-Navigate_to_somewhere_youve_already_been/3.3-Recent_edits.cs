using System;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Recently Changed Files
    //
    // Shows a popup menu of recent edits. Shows code blocks, not files
    //
    // <shortcut id="View Recent Edits">Ctrl+Shift+, (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Recent Locations" >Ctrl+Shift+E (Rider Default IntelliJ Keymap)</shortcut>
    //

    public class RecentEdits
    {
        private string firstName;
        private string lastName;

        public RecentEdits(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        private string GetName()
        {
            // 1. Implement GetName by returning firstName
            //    Uncomment the following and comment Exception line
            // return firstName;
            throw new NotImplementedException();
        }

        public void Dump()
        {
            // 2. Implement by uncommenting
            // Console.WriteLine("Name: {0}", GetName());

            // 3. Return to GetName using Recent Edits and change to be firstName + lastName
            // <shortcut id="View Recent Edits">Ctrl+Shift+, (ReSharper VisualStudio Keymap)</shortcut>
            // <shortcut id="Recent Locations" >Ctrl+Shift+E (Rider Default IntelliJ Keymap)</shortcut>

            // 4. Return back here and uncomment the following
            //     NOTE: There is no great significance to this implementation.
            //           It is content to let you experience the feel
            //           of the navigation controls.
            // Console.WriteLine("Done");
        }
    }
}
