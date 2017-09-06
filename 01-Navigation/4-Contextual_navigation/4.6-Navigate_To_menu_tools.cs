
// 1. 把光标放在这里，执行Navigate To命令 →
//    a) 按L，定位到解决方案浏览器（Locate in Solution Explorer）. 会打开解决方案浏览器，并选中当前文件。

using System;
using JetBrains.ReSharper.Koans.Navigation;

public class Foo
{
    public Form1 Form2 { get; private set; }

    public void Thing()
    {
        Console.WriteLine("Fast!");

        Form2 = new Form1();
    }
}