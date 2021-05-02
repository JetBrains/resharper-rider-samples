namespace JetBrains.ReSharper.Koans.Navigation
{
    // ブレイクポイントの表示
    //
    // Solution 内の ブレイクポイント を探索します。
    //
    // ブレイクポイントの表示
    // <shortcut id="View Breakpoints...">Ctrl+Alt+B    (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="View Breakpoints...">Ctrl+Shift+F8 (Rider Default IntelliJ Keymap)</shortcut>
    //
    // ブレイクポイント設定(トグル)
    // <shortcut id="Toggle line breakpoint">F9      (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Toggle line breakpoint">Ctrl+F8 (Rider Default IntelliJ Keymap)</shortcut>

    public class ViewBreakpoints
    {
        public void Foo()
        {
			// 1. このメソッドの開始地点にブレイクポイントを設定してください (上の行にキャレットを置きましょう)
        }

        public void Bar()
        {
			// 2. このメソッドの開始地点にブレイクポイントを設定してください (上の行にキャレットを置きましょう)
        }

        // 3. ブレイクポイントに移動してみます。
        //    前述のショートカットを使って "View Breakpoints..." を起動します。
        //    追加したブレイクポイントがリストされていることを確認したら、Enter を押して移動してみてください。
    }
}
