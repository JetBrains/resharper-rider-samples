using System.Windows.Forms;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // 移動メニュー (Navigate to) を使ってみます。 - Related Files Forms
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

    // 1. Related files への移動方法を試してみましょう(例: Related designer files)。
    //    ここにキャレットを置いてください →
    //    Related Files... を選択すると、Form1 の定義を含む他のファイルリストを表示します。

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
