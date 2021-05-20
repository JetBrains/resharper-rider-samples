using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Go to Implementation (ReSharper) / Implementations(s) (Rider)
    //
    // その型の実装に移動します。ほとんどの型では、定義に移動します。
    // インターフェイスの場合は、インターフェイスの実装、基底クラス、派生クラスに移動します。
    //
    // ReSharper の場合は１つの機能で、状況によって候補リストが表示されたり、
    // 実装に直接ジャンプしたりと挙動が変わります。
    //
    // Rider の場合、リスト表示と直接ジャンプは別の機能としてアサインされています。
    //
    // <shortcut id="Go to implementation">Ctrl+F12   or Ctrl+Click     (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Go to implementation">Ctrl+B     or Ctrl+Click     (Rider Default IntelliJ Keymap)</shortcut>
    // <shortcut id="Implementation(s)">   Ctrl+Alt+B or Ctrl+Alt+Click (Rider Default IntelliJ Keymap)</shortcut>
    //

    public class GoToImplementation
    {
        public void Method()
        {
            // 1. ICustomer を選択してキャレットを置き、この機能を試してみましょう。
            //      ReSharper: Go to implementation
            //      Rider    : Implementation(s)
            //
            // <shortcut id="Go to implementation">Ctrl+F12   or Ctrl+Click     (ReSharper VisualStudio Keymap)</shortcut>
            // <shortcut id="Implementation(s)">   Ctrl+Alt+B or Ctrl+Alt+Click (Rider Default IntelliJ Keymap)</shortcut>
            //
            //    Customer, SilverCustomer, GoldCustomer が候補に表示されましたか？
            //    Customer は ICustomer の直接の実装であるので、太字で表示されます。
            //    SilverCustomer と GoldCustomer は間接的な実装です ( Customer を経由して派生しているため )。
            //
            ICustomer customer = GetCustomer();

            // 2. 再び ICustomer を選択してキャレットを置き、この機能を開いてみてください。
            //      ReSharper: Go to implementation
            //      Rider    : Implementation(s)
            //
            // <shortcut id="Go to implementation">Ctrl+F12   or Ctrl+Click     (ReSharper VisualStudio Keymap)</shortcut>
            // <shortcut id="Implementation(s)">   Ctrl+Alt+B or Ctrl+Alt+Click (Rider Default IntelliJ Keymap)</shortcut>
            //
            //    リストのポップアップ画面が出たら、タイプしてフィルターしてみましょう。
            //    中間一致、ワイルドカードや CamelHumps (略語入力) を使ってみましょう。
            //
            //      ex.
            //         CamelHumps (略語入力)
            //          gc -> GoldCustomer
            //                ~   ~
            //          sc -> SilverCustomer
            //                ~     ~
            //

            // 3. 今度は Customer を選択してキャレットを置き、この機能を開いてみてください。
            //      ReSharper: Go to implementation
            //      Rider    : Go to implementation
            //
            // <shortcut id="Go to implementation">Ctrl+F12   or Ctrl+Click     (ReSharper VisualStudio Keymap)</shortcut>
            // <shortcut id="Go to implementation">Ctrl+B     or Ctrl+Click     (Rider Default IntelliJ Keymap)</shortcut>
            //
            //    コンストラクタの実装に直接ジャンプできます。
            //
            var customer2 = new Customer("id", "Daisy");
        }

        private ICustomer GetCustomer()
        {
            return new Customer("id", "Matt");
        }
    }
}
