using System;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // 移動メニュー (Navigate to) を使ってみます。 - Menu on Method
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

    // 1. メソッド上にキャレットがある場合
    public class NavigateToMenuOnMethod
    {
        // a) Member Overloads を選択してみましょう
        //    対象メソッドがハイライト表示されます。
        //    Escape を押すとハイライトはクリアされます。
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
        public bool OverloadedMethod()  // <- OverloadedMethod を選択してキャレットを置き、試してみてください
        {
            return true;
        }

        // b) Function exit(s) を選択してみましょう。
        //    関数からの出口がハイライト表示されます。
        //    Escape を押すとハイライトはクリアされます。
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
        public bool OverloadedMethod(string arg1)   // <- OverloadedMethod を選択してキャレットを置き、試してみてください
        {
            if (string.IsNullOrEmpty(arg1))
                return false;
            Console.WriteLine("do!");
            if (arg1 == "throw")
                throw new InvalidOperationException();
            return true;
        }

        public bool OverloadedMethod(string arg1, string arg2)
        {
            return false;
        }
    }
}
