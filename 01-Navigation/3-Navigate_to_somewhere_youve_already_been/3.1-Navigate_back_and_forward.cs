namespace JetBrains.ReSharper.Koans.Navigation
{
    // Navigate Back and Forward
    //
    // Returns the caret to the last navigation point
    //
    // Back
    // <shortcut id="Navigate back">Ctrl+- (minus) (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Navigate back">Ctrl+Alt+Left  (Rider Default IntelliJ Keymap)</shortcut>
    //
    // Forward
    // <shortcut id="Navigate forward">Ctrl+Shift+- (minus) (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Navigate forward">Ctrl+Alt+Right       (Rider Default IntelliJ Keymap)</shortcut>
    //
    public class NavigateBack
    {
        public void StartingPoint()
        {
            var navigateTo = new NavigateTo();

            // 1. Navigate to "Destination" by "Go to Declaration"
            //    Do a "Back" operation on the destination.
            //
            // Do you remember the move to declaration operation?
            // If you don't remember, here they are :
            // <shortcut id="Go to Declaration or Usages">F12    or CTRL + Click (ReSharper VisualStudio Keymap)</shortcut>
            // <shortcut id="Go to Declaration or Usages">Ctrl+B or CTRL + Click (Rider Default IntelliJ Keymap)</shortcut>
            //
            // 2. When you come back to this location,
            //    do a "Forward" operation.
            //    You should be able to see again the declaration of "Destination"
            //    that we referred to earlier.
            //
            navigateTo.Destination();
        }
    }
}
