namespace EssentialShortcuts
{
    // 最重要的快捷键： Alt+Enter
    //
    // 快速修正检查到的问题（波浪线），或者根据光标的位置执行上下文相关的操作。
    // 左侧的不同的图标代表不同的功能，比如黄色灯泡代表修正警告， 红色灯泡代表修正错误， 榔头代表执行上下文相关的操作。

    // 1. 对检查到的问题使用QuickFix
    //    下面的类名不符合ReSharper的命名风格
    //    可以看到用波浪线标记出来了
    //    光标放在类名上（或者双击选中类名）， 此时左侧出现了一个黄色的灯泡
    //    点击灯泡或者按下Alt+Enter
    //    在弹出的菜单中选择"Rename to 'BadlyNamedClass'"修正这个问题
    public class badlyNamedClass
    {
    }

    public class ContextAction
    {
        public static string FormatString(string arg)
        {
            // 2. 上下文相关的操作
            //    选中下面这行代码中的arg， 这次左侧显示了榔头图标， 说明可以执行和arg有关的操作
            //    点击榔头或者按下Alt+Enter, 在弹出菜单中选择"Convert concatenation to interpolation"
            //    注: 原来是 "To String.Format invocation", 现在点右侧的箭头也可以弹出
            return "Hello" + arg + "World";
        }
    }

    // 3. 查找命令
    //    选中下面的类名
    //    按下Alt+Enter, 在弹出菜单有一个放大镜图标
    //    点击放大镜，弹出Enter Action Name搜索框 输入 "rename"
    //    可以找到Rename...命令， 执行Rename操作
    //    也可以不点放大镜， 直接在弹出菜单界面输入"rename"， 效果一样
    public class GoToAction
    {
    }
}
