namespace JetBrains.ReSharper.Koans.Navigation.ExampleCode
{
    // 戻る
    // <shortcut id="Navigate back">Ctrl+- (minus) (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Navigate back">Ctrl+Alt+Left  (Rider Default IntelliJ Keymap)</shortcut>
    public interface ICustomer
    {
        string Id { get; }
        string Name { get; }

        // 戻る
        // <shortcut id="Navigate back">Ctrl+- (minus) (ReSharper VisualStudio Keymap)</shortcut>
        // <shortcut id="Navigate back">Ctrl+Alt+Left  (Rider Default IntelliJ Keymap)</shortcut>
        int PercentageDiscount { get; }
    }

    // 戻る
    // <shortcut id="Navigate back">Ctrl+- (minus) (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Navigate back">Ctrl+Alt+Left  (Rider Default IntelliJ Keymap)</shortcut>
    public class Customer : ICustomer
    {
        // 戻る
        // <shortcut id="Navigate back">Ctrl+- (minus) (ReSharper VisualStudio Keymap)</shortcut>
        // <shortcut id="Navigate back">Ctrl+Alt+Left  (Rider Default IntelliJ Keymap)</shortcut>
        public Customer(string id, string name)
        {
            Id = id;
            Name = name;
            PercentageDiscount = 0;
        }

        public string Name { get; private set; }
        public string Id { get; private set; }

        // 戻る
        // <shortcut id="Navigate back">Ctrl+- (minus) (ReSharper VisualStudio Keymap)</shortcut>
        // <shortcut id="Navigate back">Ctrl+Alt+Left  (Rider Default IntelliJ Keymap)</shortcut>
        public virtual int PercentageDiscount { get; private set; }
    }

    // 戻る
    // <shortcut id="Navigate back">Ctrl+- (minus) (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Navigate back">Ctrl+Alt+Left  (Rider Default IntelliJ Keymap)</shortcut>
    public class SilverCustomer : Customer
    {
        public SilverCustomer(string id, string name)
            : base(id, name)
        {
        }

        // 戻る
        // <shortcut id="Navigate back">Ctrl+- (minus) (ReSharper VisualStudio Keymap)</shortcut>
        // <shortcut id="Navigate back">Ctrl+Alt+Left  (Rider Default IntelliJ Keymap)</shortcut>
        public override int PercentageDiscount
        {
            get { return 10; }
        }
    }

    // 戻る
    // <shortcut id="Navigate back">Ctrl+- (minus) (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Navigate back">Ctrl+Alt+Left  (Rider Default IntelliJ Keymap)</shortcut>
    public class GoldCustomer : Customer
    {
        public GoldCustomer(string id, string name)
            : base(id, name)
        {
        }

        // 戻る
        // <shortcut id="Navigate back">Ctrl+- (minus) (ReSharper VisualStudio Keymap)</shortcut>
        // <shortcut id="Navigate back">Ctrl+Alt+Left  (Rider Default IntelliJ Keymap)</shortcut>
        public override int PercentageDiscount
        {
            get { return 25; }
        }
    }
}
