using System;
using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // 转到基符号
    // ReSharper - Navigate - Base Symbols
    // Alt+Home (VS)
    // Ctrl+U (IntelliJ)

    public class GoToBaseSymbols
    {
        public void Method()
        {
            // 1. 选中 Customer 执行 Go To Base Symbols
            //    导航到 ICustomer
            Customer customer = GetCustomer();

            // 2. 选中 SilverCustomer 执行 Go To Base Symbols
            //    导航到 Customer.
            //    总是向上跳转一层, 而不是像Go To Derived Symbols命令, 会显示多层
            var customer2 = new SilverCustomer("id", "Tim");

            // 3. 选中 PercentageDiscount 执行 Go To Base Symbols
            //    跳转到虚属性 Customer.PercentageDiscount
            Console.WriteLine(customer2.PercentageDiscount);
        }

        private Customer GetCustomer()
        {
            return new Customer("id", "Matt");
        }
    }
}
