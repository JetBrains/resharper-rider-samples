namespace JetBrains.ReSharper.Koans.Navigation
{
    // 查找所有使用
    // ReSharper - Find - Find Usages
    // 查找所有使用并且显示在查找结果窗口(Find Results window)
    //
    // Shift+F12 (VS)
    // Alt+F7 (IntelliJ)

    public class FindUsages
    {
        // 1. 选中 ButtonText 执行 Find Usages
        //    可以看到 ReSharper 会找出读取和写入的使用
        //    还会找到在XAML中的使用, 还包括一个没有指定类型但可以动态推断出来的使用
        // 2. 在查找结果窗口(Find Results window), 你可以依次尝试一下工具栏上的按钮, 还有右键菜单
        public string ButtonText { get; set; }

        // Ensures ButtonText is in the correct format
        public void CleanupText()
        {
            ButtonText = ButtonText.Trim();
            ButtonText = ButtonText.ToLowerInvariant();
        }
    }
}
