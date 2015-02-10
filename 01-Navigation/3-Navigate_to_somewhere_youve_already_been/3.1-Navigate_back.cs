namespace JetBrains.ReSharper.Koans.Navigation
{
    // Navigate Back
    //
    // Returns the caret to the last navigation point
    //
    // Ctrl+- (minus)
    //
    public class NavigateBack
    {
        public void StartingPoint()
        {
            var navigateTo = new NavigateTo();

            // 1. Navigate to NavigateTo.Destination by Ctrl+Click or Go To Definition
            navigateTo.Destination();
        }
    }


    public class NavigateTo
    {
        public void Destination()
        {
            // Now navigate back, using Visual Studio's Ctrl+- (minus)
        }
    }
}