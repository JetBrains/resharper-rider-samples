namespace JetBrains.ReSharper.Koans.Navigation.ExampleCode
{
    public interface ICustomer
    {
        string Id { get; }
        string Name { get; }
        int PercentageDiscount { get; }
    }

    public class Customer : ICustomer
    {
        public Customer(string id, string name)
        {
            Id = id;
            Name = name;
            PercentageDiscount = 0;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public virtual int PercentageDiscount { get; private set; }
    }

    public class SilverCustomer : Customer
    {
        public SilverCustomer(string id, string name)
            : base(id, name)
        {
        }

        public override int PercentageDiscount { get { return 10; } }
    }

    public class GoldCustomer : Customer
    {
        public GoldCustomer(string id, string name)
            : base(id, name)
        {
        }

        public override int PercentageDiscount { get { return 25; } }
    }
}