namespace JetBrains.ReSharper.Koans.Navigation
{
    // 快速查找使用
    // 显示包含当前文件中使用的弹出菜单
    // Quick Find Usages
    // Alt+Shift+F12 (VS)
    // Ctrl+Alt+F7 (IntelliJ)

    public class QuickFindUsages
    {
        private const double MinValue = -3.5;
        private const double MaxValue = 3.5;

        public double Adjust(double original, double delta)
        {
            // 1. 选中newValue然后执行Quick Find Usages
            var newValue = original + delta;

            if (newValue < MinValue)
                newValue = MinValue;

            if (newValue > MaxValue)
                newValue = MaxValue;

            return newValue;
        }
    }
}
