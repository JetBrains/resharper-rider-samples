namespace JetBrains.ReSharper.Koans.Navigation
{
    // 前後の操作箇所の間を移動する操作をしてみます。
    //
    // カーソル (キャレット) を操作していた前後の場所に移動します。
    //
    // 戻る
    // <shortcut id="Navigate back">Ctrl+- (minus) (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Navigate back">Ctrl+Alt+Left  (Rider Default IntelliJ Keymap)</shortcut>
    //
    // 進む
    // <shortcut id="Navigate forward">Ctrl+Shift+- (minus) (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Navigate forward">Ctrl+Alt+Right       (Rider Default IntelliJ Keymap)</shortcut>
    //
    public class NavigateBackAndForward
    {
        public void StartingPoint()
        {
            var navigateTo = new NavigateTo();

            // 1. "Destination" に対して、宣言への移動操作を行います。
            //      移動した先で戻る操作をしてみてください。
            //
            // 宣言への移動操作は憶えていますか？忘れた人は以下です。
            // <shortcut id="Go to Declaration or Usages">F12    or CTRL + Click (ReSharper VisualStudio Keymap)</shortcut>
            // <shortcut id="Go to Declaration or Usages">Ctrl+B or CTRL + Click (Rider Default IntelliJ Keymap)</shortcut>
            //
            // 2. この場所に戻ってきたら、今度は進む操作をしてみましょう。
            //    先ほど参照した "Destination" の宣言をもう一度確認することが出来るはずです。
            //
            navigateTo.Destination();
        }
    }
}
