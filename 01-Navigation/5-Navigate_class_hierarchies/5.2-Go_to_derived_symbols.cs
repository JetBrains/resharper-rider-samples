using System;
using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // 转到衍生符号
    // ReSharper - Navigate - Derived Symbols
    // Alt+End (VS)
    // Ctrl+Alt+B (IntelliJ)

    public class GoToDerivedSymbols
    {
        public void Method()
        {
            // 1. 选中ICustomer执行Go To Derived Symbols
            //    可以看到三个选项: Customer, SilverCustomer 和 GoldCustomer
            //    Customer被加粗是因为他是ICustomer的直接实现.
            //    SilverCustomer 和 GoldCustomer 则是间接的实现.
            // 2. 在这个界面同样可以使用中间字匹配, 通配符和首字母缩写
            // 以上和Go To Implementation是一样的
            ICustomer customer = GetCustomer();

            // 3. 选中Customer执行Go To Derived Symbols
            //    显示 GoldCustomer 和 SilverCustomer (现在和Go To Implementation不一样了)
            var customer2 = new Customer("id", "Daisy");

            // 4. 选中 PercentageDiscount 执行 Go To Derived Symbols
            //    显示了这个虚属性在SilverCustomer 和 GoldCustomer中的两个重载
            Console.WriteLine(customer2.PercentageDiscount);
        }

        private ICustomer GetCustomer()
        {
            return new Customer("id", "Matt");
        }
    }
}
