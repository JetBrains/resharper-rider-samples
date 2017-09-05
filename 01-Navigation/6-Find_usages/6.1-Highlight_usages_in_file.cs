namespace JetBrains.ReSharper.Koans.Navigation
{
    // 高亮本文件中的使用
    // ReSharper - Find - Highlight Usages in File
    //
    // Shift+Alt+F11 (VS)
    // Ctrl+Alt+F7 (IntelliJ)

    public class HighlightUsagesInFile
    {
        private const double MinValue = -3.5;
        private const double MaxValue = 3.5;

        public double Adjust(double original, double delta)
        {
            // 1. 选中 newValue 然后执行 Highlight Usages in File
            //    你可以看到他们有不同的颜色, 写入是红色, 而读取是蓝色
            //    同时你也可以看到右侧的相同颜色条纹, 这些条纹都是可以点击的
            //    按Escape取消高亮
            //    Ctrl+Alt+PgUp/Ctrl+Alt+PgDown (VS) 可以前后切换
            //    Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ)
            var newValue = original + delta;

            if (newValue < MinValue)
                newValue = MinValue;

            if (newValue > MaxValue)
                newValue = MaxValue;

            return newValue;
        }
    }
}
