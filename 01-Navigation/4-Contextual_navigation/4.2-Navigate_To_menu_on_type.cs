using System;
using System.ComponentModel;
using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // 1. 对一个类型的定义使用Navigate To命令 (比如下面的DerivedClass)
    //    a) 按B，转到基符号（Base Symbols）
    //    b) 按S，转到衍生符号（Derived Symbols）
    //    c) 按X，转到扩展函数（Extension methods）
    //    d) 按O，转到对象浏览器（Object Browser）
    //    e) 按L，在解决方案浏览器中定位（Locate in Solution Explorer）
    //    f) 按C，转到引用代码（Referenced Code） 会找出所有引用到这个类型的代码，比如说BaseClass
    //    Find Usages of Symbol, Related Files, Usages of Symbol会在后面提到
    public class DerivedClass   // <- 选中这个
        : BaseClass
    {
    }


    // 2. 对一个基类执行Navigate To (比如说下面的BaseClass)
    //    a) 和上面一样的操作
    //    b) 按D，转到定义（Declaration）
    //    c) 按I，转到实现（Implementation），会列出BaseClass和他的衍生类
    //    d) 按M，高亮所有的重载成员（Overriding members）
    //       按Escape取消高亮
    //       Ctrl+Alt+PgUp/Ctrl+Alt+PgDown (VS) 可以前后跳转
    //       Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ) 
    public class DerivedClass2
        : BaseClass // <- 选中这个
    {
        public override void VirtualMethod()
        {
        }

        public override string VirtualProperty
        {
            get { return "cheese"; }
        }
    }


    // 3. 选中一个有实现的接口，比如说下面的 ISimpleInterface
    //    a) 试一下上面所有的操作
    //    b) 按M，高亮这个接口所有实现的成员（Implementing Members），和上面的Overriding Members对应
    //       按Escape取消高亮
    //       Ctrl+Alt+PgUp/Ctrl+Alt+PgDown (VS) 可以前后跳转
    //       Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ) 
    public class SimpleClass
        : ISimpleInterface  // <- 选中这个
    {
        public void SayHello()
        {
            Console.WriteLine("hello");
        }

        public void SayGoodbye()
        {
            Console.WriteLine("goodbye");
        }
    }


    // 4. 选中一个定义在其他集合中的接口
    //    a) 执行Go To Derived Symbols， 显示SimpleComponent在内的3个选项
    //    b) 执行Navigate to Declaration，如果是第一次会弹框询问默认处理方式， 建议设为Object Explorer
    //       在Object Explorer中，继续对IComponent使用Go To Derived Symbols
    //       这个时候你能看到大量的衍生类
    //    注：你可以在ReSharper - Options... - Tools - External Source中修改设置
    public class SimpleComponent
        : System.ComponentModel.IComponent  // <- 选中这个
    {
        #region Implementation details

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ISite Site { get; set; }
        public event EventHandler Disposed;

        #endregion
    }
}