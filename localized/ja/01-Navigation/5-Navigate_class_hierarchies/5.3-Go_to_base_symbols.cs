using System;
using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Go to Derived Symbols
    //
    // <shortcut id="Go to Super Method">Alt+Home (VS)</shortcut>
    //

    public class GoToBaseSymbols
    {
        public void Method()
        {
            // 1. Put the caret on Customer and Go To Base Symbols
            //    Navigated to ICustomer
            Customer customer = GetCustomer();

            // 2. Put the caret on SilverCustomer and Go To Base Symbols
            //    Navigated to Customer.
            //    Always navigates one level up the hierarchy, rather than
            //    Go To Derived Symbols, which can navigate many levels down
            var customer2 = new SilverCustomer("id", "Tim");

            // 3. Put the caret on PercentageDiscount and Go To Base Symbols
            //    Navigated to virtual property Customer.PercentageDiscount
            Console.WriteLine(customer2.PercentageDiscount);
        }

        private Customer GetCustomer()
        {
            return new Customer("id", "Matt");
        }
    }
}