namespace JetBrains.ReSharper.Koans.Navigation
{
    // Navigate Back
    //
    // Returns the caret to the last navigation point
    //
    // <shortcut id="Back">Ctrl+- (minus)</shortcut>
    //
    public class NavigateBack
    {
        public void StartingPoint()
        {
            var navigateTo = new NavigateTo();

            // 1. Navigate to NavigateTo.Destination by <shortcut id="Go to Declaration or Usages">F12 or CTRL + Click</shortcut>
            navigateTo.Destination();
        }
    }
}