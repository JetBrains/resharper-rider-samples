using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Go to Implementation
    //
    // Alt+` (VS)
    // Ctrl+Shift+Alt+B (IntelliJ)

    public class GoToImplementation
    {
        public void Method()
        {
            // 1. Put the caret on ICustomer and Go To Implementation
            //    Get the choice of Customer, SilverCustomer and GoldCustomer
            //    Customer is bold because it's a direct implementation of ICustomer
            //    SilverCustomer and GoldCustomer are indirect implementations
            //    (because they derive from Customer)
            // 2. Put the caret on ICustomer and Go To Implementation
            //    Filter by typing, middle matching, wildcards and CamelHumps
            ICustomer customer = GetCustomer();

            // 3. Put the caret on the Customer and Go To Implementation
            //    Takes you straight to the implementation of the constructor
            var customer2 = new Customer("id", "Daisy");
        }

        private ICustomer GetCustomer()
        {
            return new Customer("id", "Matt");
        }
    }
}