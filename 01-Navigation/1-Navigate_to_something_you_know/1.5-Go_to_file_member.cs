namespace JetBrains.ReSharper.Koans.Navigation
{
    // 转到文件成员
    // ReSharper - Navigate - Go to File Member...
    // 转到定义在当前文件的任意成员
    //
    // Alt+\ (VS)
    // Ctrl+F12 (IntelliJ)
    //
    // 1. 可以通过输入名字、首字母缩写、部分文字匹配、通配符的方法进行查找类
    //    输入 "GoToFileMemberExample"
    //    输入 "GTFME"
    //    输入 "FileMember"
    //    输入 "GoTo*Example"
    //
    // 2. 通过名字查找类成员
    //    输入 "foo" 转到 GoToFileMemberExample.Foo
    //
    // 3. 转到构造函数
    //    输入 "new" 或者 "ctor"
    //
    // 4. 根据可见性来过滤成员
    //    输入 "public" 或者 "private"


    // ----------

    public class GoToFileMemberExample
    {
        private readonly int bar;

        public GoToFileMemberExample(string foo, int bar)
        {
            this.bar = bar;
            Foo = foo;
        }

        public string Foo { get; private set; }
    }
}
