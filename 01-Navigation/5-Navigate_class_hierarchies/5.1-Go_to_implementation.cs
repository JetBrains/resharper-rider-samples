using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // 转到实现
    // ReSharper - Navigate - Go to Implementation
    // 导航到类型的实现. 对大多数类型, 导航到定义.
    // 对于接口, 导航到接口的实现, 对于基类, 导航到衍生类.
    //
    // Alt+`, I 打开Navigate to菜单, 选择Implementation

    public class GoToImplementation
    {
        public void Method()
        {
            // 1. 选中ICustomer执行Go To Implementation
            //    可以看到三个选项: Customer, SilverCustomer 和 GoldCustomer
            //    Customer被加粗是因为他是ICustomer的直接实现.
            //    SilverCustomer 和 GoldCustomer 则是间接的实现.
            // 2. 在这个界面同样可以使用中间字匹配, 通配符和首字母缩写
            ICustomer customer = GetCustomer();

            // 3. 选中Customer执行Go To Implementation
            //    直接跳转到Customer的构造函数
            var customer2 = new Customer("id", "Daisy");
        }

        private ICustomer GetCustomer()
        {
            return new Customer("id", "Matt");
        }
    }
}
