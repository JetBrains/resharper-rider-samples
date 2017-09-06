using System;
using System.Collections.Generic;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // 1. 这次对控制流的关键字使用Navigate to命令
    public class NavigateToControlFlowKeyword
    {
        public void ControlFlowWithForStatement()
        {
            for (int i = 0; i < Children.Count; i++)
            {
                var child = Children[i];

                // a) 选中"continue". 按C，转到控制流目标（Control Flow Target）
                //    光标会转到for语句中的 i++ 命令前
                if (ShouldSkipChild(child))
                    continue;

                // b) 选中"break". 按C，转到控制流目标（Control Flow Target）
                //    光标会转到循环后的第一条语句前
                if (ShouldStop(child))
                    break;

                // c) 选中"return". 按C，转到控制流目标（Control Flow Target）
                //    光标会转到函数体的闭合花括号前
                if (ShouldQuit(child))
                    return;
            }

            // 按Ctrl+-返回
            Console.WriteLine("Finished loop");
        }

        public void ControlFlowWithSwitchStatement(Size size)
        {
            switch (size)
            {
                case Size.Large:
                    // d) 选中"break". 按C，转到控制流目标（Control Flow Target）
                    //    光标会跳转到switch后第一条语句
                    break;
                case Size.Medium:
                    // e) 选中"return". 按C，转到控制流目标（Control Flow Target）
                    //    光标会转到函数体的闭合花括号前
                    return;
                case Size.Small:
                    // e) 选中"throw". 按C，转到控制流目标（Control Flow Target）
                    //    光标会转到函数体的闭合花括号前
                    throw new ArgumentOutOfRangeException("size");
            }

            Console.WriteLine("Finished switch");
        }

        #region Implementation details

        private IList<string> Children { get { return new List<string>(); } }

        private bool ShouldSkipChild(string child)
        {
            return child == "Barry";
        }

        private bool ShouldStop(string child)
        {
            return child == "Rocky";
        }

        private bool ShouldQuit(string child)
        {
            return child == "Damien";
        }

        public enum Size
        {
            Large,
            Medium,
            Small
        }

        #endregion
    }
}