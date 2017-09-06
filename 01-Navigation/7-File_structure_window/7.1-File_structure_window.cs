using System;
using System.ComponentModel;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // 文件结构窗口
    // ReSharper - Windows - File Structure
    // 显示文件的概括
    //
    // Ctrl+Alt+F (VS)
    // Ctrl+F11 (IntelliJ)
    //
    // 1. 双击任一项目即可跳转，右键菜单，快捷键同样有效。
    // 2. 尝试一下工具栏上的各个按钮
    // 3. 直接输入字符可以进行查找，同样的，中间字匹配，通配符和首字母缩写都可以

    public class FileStructureWindow : IComponent
    {
        public FileStructureWindow()
        {
            Name = "Hello";
        }

        public string Name { get; private set; }

        // 4. 点击Implementation of IComponent右侧的×号
        //    可以删除region语句
        #region Implementation of IComponent

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ISite Site { get; set; }
        public event EventHandler Disposed;

        #endregion
    }
}