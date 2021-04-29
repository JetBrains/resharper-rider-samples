using System;
using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Go to Derived Symbols (Go to Implementation(s))
    //
    // <shortcut id="Go to Implementation(s)">Alt+End (VS)</shortcut>
    //

    public class GoToDerivedSymbols
    {
        public void Method()
        {
            // 1. Put the caret on ICustomer and Go To Derived Symbols
            //    Get the choice of Customer, SilverCustomer and GoldCustomer
            //    Customer is bold because it's a direct implementation of ICustomer
            //    SilverCustomer and GoldCustomer are indirect implementations
            //    (because they derive from Customer)
            // 2. Put the caret on ICustomer and Go To Implementation
            //    Filter by typing, middle matching, wildcards and CamelHumps
            ICustomer customer = GetCustomer();

            // 3. Put the caret on the Customer and Go To Derived Symbols
            //    Shows GoldCustomer and SilverCustomer (note difference with
            //    Go To Implementation)
            var customer2 = new Customer("id", "Daisy");

            // 4. Put the caret on PercentageDiscount and Go To Derived Symbols
            //    Shown overrides of virtual property in SilverCustomer and GoldCustomer
            Console.WriteLine(customer2.PercentageDiscount);
        }

        private ICustomer GetCustomer()
        {
            return new Customer("id", "Matt");
        }
    }
}