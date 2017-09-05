using System;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // 查找所有使用(高级)
    // ReSharper - Find - Find Usages advanced...
    // 显示一个搜索选项对话框
    //
    // Ctrl+Shift+Alt+F12 (VS)
    // Shift+Alt+F7 (IntelliJ)

    public class FindUsagesAdvanced
    {
        // 1. 选中Singularity, 然后执行Find Usages advanced
        //    勾选Textual occurrences, 可以搜索Singularity的文本
        //    可以找到下面两条Console.WriteLine语句, 一个直接使用Singularity, 另一个使用字符串"Singularity"
        public string Singularity { get; set; }

        public void PrintSingularity()
        {
            Console.WriteLine(Singularity);
            Console.WriteLine("Singularity");
        }

        // 2. 再对下面Navigation试一下, 会搜索到两条命名空间中的文本使用
        //    在搜索范围(Scope)中选中当前文件(current file), 再试一下看看
        //    注: 我试下来这个对话框总是显示不全
        public string Navigation { get; set; }

        // 3. 这次对 DynamicUsage 试一下选中动态引用(Dynamic references)
        //    应该会找到两处代码使用和一处文本使用
        public void DynamicUsage(string argument)
        {
            if (argument == null)
                return;

            var something = GetDynamicObject();
            // 动态的使用
            something.DynamicUsage("sausages");

            // 非动态的使用
            this.DynamicUsage("hello");
        }

        private dynamic GetDynamicObject()
        {
            return this;
        }
    }
}
