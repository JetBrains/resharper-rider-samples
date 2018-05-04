using System;

namespace JetBrains.ReSharper.Koans.Navigation
{


    // 5. 现在试试看对一个方法执行Navigate to
    public class NavigateToMenuOnMethod
    {
        // a) 你可以选中方法名，也可以把光标放在方法体内任意地方
        //    按M，高亮重载成员（Member overloads）
        //    按Escape取消高亮
        //    Ctrl+Alt+PgUp/Ctrl+Alt+PgDown (VS) 可以前后跳转
        //    Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ)
        public bool OverloadedMethod()
        {
            return true;
        }

        // b) 这次必须把光标放在方法名内，而不是双击选中方法，执行Navigate to
        //    按E，高亮所有的返回语句（Function exit(s)）
        //    按Escape取消高亮
        //    Ctrl+Alt+PgUp/Ctrl+Alt+PgDown (VS) 可以前后跳转
        //    Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ)
        public bool OverloadedMethod(string arg1)
        {
            if (string.IsNullOrEmpty(arg1))
                return false;
            Console.WriteLine("do!");
            if (arg1 == "throw")
                throw new InvalidOperationException();
            return true;
        }

        public bool OverloadedMethod(string arg1, string arg2)
        {
            return false;
        }
    }
}