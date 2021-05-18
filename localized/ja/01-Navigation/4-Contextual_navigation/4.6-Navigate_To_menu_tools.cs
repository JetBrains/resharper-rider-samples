// 移動メニュー (Navigate to) を使ってみます。 - tools
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

// 1. エクスプローラーで開いているファイルの場所を表示します。
//
// 詳細は 4.8-Navigate_To_menu_file_nearby.md を参照してください。
//
// <shortcut id="Locate in Solution Explorer">Shift+Alt+L (ReSharper VisualStudio Keymap)</shortcut>
// <shortcut id="Select Opened File">         Alt+F1, 1   (Rider Default IntelliJ Keymap)</shortcut>

using System;
using JetBrains.ReSharper.Koans.Navigation;

public class Foo
{
    public Form1 Form2 { get; private set; }

    public void Thing()
    {
        Console.WriteLine("Fast!");

        Form2 = new Form1();
    }
}
