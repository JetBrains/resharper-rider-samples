using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // 移動メニュー (Navigate to) を使ってみます。 - Type of Symbol
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

    public class WhenCaretIsOnSymbol
    {
        public void NavigateToSymbolType()
        {
            // 1. キャレットがシンボル (Auto変数) 上にある場合の動作を試してみましょう。
            //    "stuff" にキャレットを置き、 Navigate to -> Type of Symbol と選択します。
            //    基底クラスの宣言に移動できましたか？
            var stuff = new BaseClass();
        }
    }
}
