using System;
using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // 转到定义
    //
    // 导航到符号的定义
    //
    // Ctrl+Click
    // F12

    public class GoToDefinition
    {
        public void Method(string name, int age)
        {
            // 1. 按住Ctrl, 单击"Person"
            // 2. 或者使用快捷键
            var person = new Person("Hadi", 53);

            // 3. 对参数也可以使用, 对"name", "age"试一下
            var otherPerson = new Person(name, age);

            // 4. 对推断类型"var"也可以使用
            var thirdPerson = otherPerson;

            // 5. 对库中的类型也可以使用, 对"Console"试一下
            Console.WriteLine(thirdPerson.Name);

            // 6. 对库中的命名空间也可以使用, 对"System"试一下, 转到Assembly Explorer
            System.Console.WriteLine();

            // 7. 对"Navigation"试一下, 转到包含该命名空间的文件
            var type = typeof(JetBrains.ReSharper.Koans.Navigation.GoToDefinition);
        }
    }
}
