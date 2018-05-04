using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{

    public class WhenCaretIsOnSymbol
    {
        public void NavigateToSymbolType()
        {
            // 1. 这次对符号执行Navigate To命令。如stuff。
            //    按T，转到符号的类型（Type of Symbol）
            //    会转到BaseClass的定义
            var stuff = new BaseClass();
        }
    }
}