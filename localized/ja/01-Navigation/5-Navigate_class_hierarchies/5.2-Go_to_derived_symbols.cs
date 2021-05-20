using System;
using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Go to Derived Symbols (ReSharper) / Implementation(s) (Rider)
    //
    // <shortcut id="Go to derived symbols">Alt+End                      (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Implementation(s)">    Ctrl+Alt+B or Ctrl+Alt+Click (Rider Default IntelliJ Keymap)</shortcut>
    //

    public class GoToDerivedSymbols
    {
        public void Method()
        {
            // 1. ICustomer を選択してキャレットを置き、この機能を試してみましょう。
            //      ReSharper: Go to derived symbols
            //      Rider    : Implementation(s)
            //
            //    Customer, SilverCustomer, GoldCustomer が候補に表示されましたか？
            //    Customer は ICustomer の直接の実装であるので、太字で表示されます。
            //    SilverCustomer と GoldCustomer は間接的な実装です ( Customer を経由して派生しているため )。
            //
            ICustomer customer = GetCustomer();

            // 2. 再び ICustomer を選択してキャレットを置き、この機能を開いてみてください。
            //      ReSharper: Go to derived symbols
            //      Rider    : Implementation(s)
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
            //      ReSharper: Go to derived symbols
            //      Rider    : Implementation(s)
            //
            //    GoldCustomer と SilverCustomer が表示されましたか？
            //    ( Implementation(s) との挙動の違いに注目してください )
            //
            var customer2 = new Customer("id", "Daisy");

            // 4. PercentageDiscount を選択してキャレットを置き、この機能を開いてみてください。
            //      ReSharper: Go to derived symbols
            //      Rider    : Implementation(s)
            //
            //    SilverCustomer および GoldCustomer の オーバーライド・メソッドが候補に表示されます。
            //
            Console.WriteLine(customer2.PercentageDiscount);
        }

        private ICustomer GetCustomer()
        {
            return new Customer("id", "Matt");
        }
    }
}
