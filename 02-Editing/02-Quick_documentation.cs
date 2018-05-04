using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    // Show Quick Documentation 显示快速文档
    // ReSharper - Edit - Show Quick Documentation...
    // Ctrl+Shift+F1 (VS)
    // Ctrl+Q (IntelliJ)
    // Escape关闭

    public class XmlDocumentation
    {
        public void Method()
        {
            // 1. 选中Documented, 执行Show Quick Documentation
            //    点击Go to链接, 可以转到Documented类的定义
            //    点击See Also下的RelatedClass链接, 会显示RelatedClass的快速文档
            var documented = new Documented();

            // 2. 选中DocumentedMethod, 执行Show Quick Documentation
            //    你可以点击参数类型和返回类型的链接
            documented.DocumentedMethod("hello", true);
        }

        // 3. 生成XML文档
        //    输入三个'/'
        // 4. 新增一个参数
        //    这个参数会用波浪线标记, 按Alt+Enter进行快速修正
        // 5. 删除一个参数
        //    文档内的参数会用波浪线标记, 按Alt+Enter进行快速修正
        // 6. 再增加一个参数
        //    这次手动添加文档, 输入<p, 然后选择param, 再输入参数首字母, 会自动补全参数名
        // 7. 对参数执行Rename, 文档内的参数名也会修改
        // 8. 对参数执行Find Usages
        //    会显示文档中的使用, 可以点击Filter Usages, 取消Documentation reference

        public bool RequiresDocumentation(string name, int value)
        {
            Console.WriteLine(name);
            return true;
        }
    }

    #region Implementation Details

    /// <summary>
    /// 点击右上角的go to链接可以转到类的定义
    /// </summary>
    /// <remarks>
    /// <para>点击下方的RelatedClass链接</para>
    /// <para>可以在QuickDoc界面中显示RelatedClass的文档</para>
    /// </remarks>
    /// <seealso cref="RelatedClass"/>
    public class Documented
    {
        /// <summary>
        /// 我是一个加过文档的方法
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="log">是否显示日志</param>
        /// <returns>是否成功执行</returns>
        public bool DocumentedMethod(string data, bool log)
        {
            return true;
        }
    }

    /// <summary>
    /// 左上角的Navigate Back按钮变亮了, 可以点击返回到Documented类的文档
    /// </summary>
    /// <remarks>
    /// <para>小技巧: 怎么用一只手按Ctrl+Shift+F1</para>
    /// <para>用左手大拇指按住Ctrl+Shift, 再用中指按F1</para>
    /// </remarks>
    public class RelatedClass
    {
    }

    #endregion
}
