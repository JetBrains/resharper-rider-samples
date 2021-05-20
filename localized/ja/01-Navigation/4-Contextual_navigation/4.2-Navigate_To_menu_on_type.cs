using System;
using System.ComponentModel;
using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // 移動メニュー (Navigate to) を使ってみます。 - Menu on Type
    //
    // 現在の場所から移動する便利な方法です。
    // 基本的な仕組みは 基本編 4.1-Navigate_To_menu.cs を参照してください。
    //
    // Navigate to の操作方法
    // <shortcut id="Navigate to">Alt+`        (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Navigate to">Ctrl+Shift+G (Rider Default IntelliJ Keymap)</shortcut>
    //
    // 対象の上にキャレットを置き、実行してみましょう。
    //

    // 1. 型定義 (継承クラス) にキャレットがある場合、以下のような候補が表示されます。
    //    それぞれ試してみましょう。
    //      - Declaration           : 宣言に移動します
    //      - Implementation        : 実装に移動します
    //      - Base Symbols          : 基底クラスに移動します
    //      - Find Usages of Symbol : (*1)
    //      - Related Files...      : (*1)
    //      - Usages of Symbol      : (*1)
    //      - Derived Symbols       : 派生クラスに移動します
    //      - Extension methods     : 拡張メソッドに移動します
    //      - Consuming APIs        : 自身をパラメーターで受け取る箇所に移動します
    //      - Exposing APIs         : 自身を戻り値として返す箇所に移動します
    //      - Referenced Code       : 型が参照されるすべてのコードを見つけます (例: BaseClass)。
    //      - Locate in Solution Explorer   : (Only ReSharper) Solution Explorer で現在のファイルに移動します
    //
    //    (*1) Find Usages of Symbol, Usages of Symbol, Related files は後の演習で詳細に説明します。
    public class DerivedClass   // <- DerivedClass を選択してキャレットを置き、試してみてください
        : BaseClass
    {
    }


    // 2. 型定義 (基底クラス) にキャレットがある場合も同様の候補が表示されます。
    //    このクラスの場合、 override したメソッド定義があるので、
    //    ReSharper や Rider は正しく認識して候補に表示します。
    //      - Overriding members    : 全ての override されているメソッドをハイライト表示します
    //                                Escape を押すとハイライトはクリアされます
    //
    // (参考) 候補間の移動方法
    //
    // NOTE: Rider のショートカットはデフォルトで未定義(設定なし)であり、独自に設定しなければ動作しない
    // [Settings] > [Keymap] > [Main Manu] > [Edit] > [Find Usages]
    //  - Next Highlited Usage
    //  - Previous Highlited Usage
    //
    //   <shortcut id="Go to Next/Previous">Ctrl+Alt+PageUp/Ctrl+Alt+PageDown (ReSharper VisualStudio Keymap)</shortcut>
    //   <shortcut id="Find Next/Previous"> F3 / Shift+F3                     (Rider Default IntelliJ Keymap)</shortcut>
    //
    //   (ReSharper) https://www.jetbrains.com/help/resharper/Navigation_and_Search__Navigate_from_Here__Overriding_Members.html
    //   (Rider)     https://www.jetbrains.com/help/rider/Navigation_and_Search__Navigate_from_Here__Overriding_Members.html
    //
    public class DerivedClass2
        : BaseClass // <- BaseClass を選択してキャレットを置き、試してみてください
    {
        public override void VirtualMethod()
        {
        }

        public override string VirtualProperty
        {
            get { return "cheese"; }
        }
    }


    // 3. 実装時のインターフェース型 (ここでは ISimpleInterface ) にキャレットがある場合も同様の候補が表示されます。
    //    ReSharper や Rider は Interface であることを正しく認識して候補に表示します。
    //      - Implementing Members  : Interface で定義されている全てのメンバーをハイライト表示します
    //                                Escape を押すとハイライトはクリアされます
    //
    // (参考) 候補間の移動方法
    //
    // NOTE: Rider のショートカットはデフォルトで未定義(設定なし)であり、独自に設定しなければ動作しない
    // [Settings] > [Keymap] > [Main Manu] > [Edit] > [Find Usages]
    //  - Next Highlited Usage
    //  - Previous Highlited Usage
    //
    //   <shortcut id="Go to Next/Previous">Ctrl+Alt+PageUp/Ctrl+Alt+PageDown (ReSharper VisualStudio Keymap)</shortcut>
    //   <shortcut id="Find Next/Previous"> F3 / Shift+F3                     (Rider Default IntelliJ Keymap)</shortcut>
    //
    //   (ReSharper) https://www.jetbrains.com/help/resharper/Navigation_and_Search__Navigate_from_Here__Overriding_Members.html
    //   (Rider)     https://www.jetbrains.com/help/rider/Navigation_and_Search__Navigate_from_Here__Overriding_Members.html
    //
    public class SimpleClass
        : ISimpleInterface  // <- ISimpleInterface を選択してキャレットを置き、試してみてください
    {
        public void SayHello()
        {
            Console.WriteLine("hello");
        }

        public void SayGoodbye()
        {
            Console.WriteLine("goodbye");
        }
    }


    // 4. 他のアセンブリで定義された実装インターフェース (ここでは IComponent)
    //    にキャレットがある場合も同様の候補が表示されます。
    //    ここでのポイントは、
    //      - Derived Symbols で派生クラスを探すとこのSolutionに関係したものだけがフィルターして表示されます
    //      - Declaration で宣言に移動した後で、 IComponent に対して Derived Symbols を実行すると、
    //        全ての参照アセンブリを含み、もっと多くの派生型を探すことが出来ます。
    //
    public class SimpleComponent
        : System.ComponentModel.IComponent  // <- IComponent を選択してキャレットを置き、試してみてください
    {
        #region Implementation details

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ISite Site { get; set; }
        public event EventHandler Disposed;

        #endregion
    }
}
