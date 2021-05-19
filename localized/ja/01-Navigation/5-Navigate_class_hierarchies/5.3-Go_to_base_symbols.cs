using System;
using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Go to Base Symbols
    //
    // <shortcut id="Go to base symbols">Alt+Home   (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Go to base symbols">Ctrl+U     (Rider Default IntelliJ Keymap)</shortcut>
    //

    public class GoToBaseSymbols
    {
        public void Method()
        {
            // 1. Customer を選択してキャレットを置き、この機能を試してみましょう。
            //    ICustomer に移動できましたか？
            Customer customer = GetCustomer();

            // 2. SilverCustomer を選択してキャレットを置き、この機能を試してみましょう。
            //    Customer に移動できましたか？
            //    ”Go to derived symbols” と異なり、常に１つ上の継承レベルに移動しますが、
            //    何段階も先の階層に移動することもできます。
            //
            var customer2 = new SilverCustomer("id", "Tim");

            // 3. PercentageDiscount を選択してキャレットを置き、この機能を試してみましょう。
            //    基底クラスの仮想プロパティが候補に表示されます。
            //
            Console.WriteLine(customer2.PercentageDiscount);
        }

        private Customer GetCustomer()
        {
            return new Customer("id", "Matt");
        }
    }
}
