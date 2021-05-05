namespace JetBrains.ReSharper.Koans.Navigation
{
    // 戻る操作をしてみます。
    //
    // カーソル (キャレット) を最後に操作していた場所に戻します。
    //
    // <shortcut id="Navigate back">Ctrl+- (minus) (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Navigate back">Ctrl+Alt+Left  (Rider Default IntelliJ Keymap)</shortcut>
    //
    public class NavigateBack
    {
        public void StartingPoint()
        {
            var navigateTo = new NavigateTo();

            // 1. "Destination" に対して、宣言への移動操作を行います。
            //      移動した先で戻る操作をしてみてください。
            //      この場所に戻ってきたら、今度は進む操作をしてみましょう。
            //
            // 宣言への移動操作は憶えていますか？忘れた人は以下です。
            // <shortcut id="Go to Declaration or Usages">F12    or CTRL + Click (ReSharper VisualStudio Keymap)</shortcut>
            // <shortcut id="Go to Declaration or Usages">Ctrl+B or CTRL + Click (Rider Default IntelliJ Keymap)</shortcut>
            //
            navigateTo.Destination();
        }
    }
}