namespace JetBrains.ReSharper.Koans.Navigation
{
    // 向后导航 (VS功能)
    // View - Navigate Backward
    // Ctrl+-
    //
    public class NavigateBack
    {
        public void StartingPoint()
        {
            var navigateTo = new NavigateTo();

            // 1. 跳转到NavigateTo.Destination的定义
            navigateTo.Destination();
        }
    }
}
