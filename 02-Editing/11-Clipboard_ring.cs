using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    // 剪贴板环
    // ReSharper - Edit - Paste
    // 可以保存最近的20个剪贴板记录
    //
    // Ctrl+Shift+V (VS)
    // Ctrl+Shift+V (IntelliJ)

    public class ClipboardRing
    {
        public void Method()
        {
            // 1. 把光标放到下面的第一行语句
            // 2. 重复按Shift+Delete四次
            // 3. 按Ctrl+Shift+V， 按照从大到下的顺序依次粘贴
            //    可以输入four来过滤
            Console.WriteLine("One");
            Console.WriteLine("Two");
            Console.WriteLine("Three");
            Console.WriteLine("Four");

        }
    }
}