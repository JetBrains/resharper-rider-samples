namespace JetBrains.ReSharper.Koans.Navigation
{
    // ファイルメンバーへの移動
    //
    // 現在のファイルで定義されているメンバーに移動します。
    //
    // <shortcut id="File Member">Alt+\    (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="File Member">Ctrl+F12 (Rider Default IntelliJ Keymap)</shortcut>
    //
    // 1. 名前、CamelHumps (略語入力)、中間一致やワイルドカードで移動します。
    //    以下のようなキーワードをタイプして結果を確認してみましょう。
    //      "GoToFileMemberExample"
    //      "GTFME"
    //      "FileMember"
    //      "GoTo*Example"
    //
    // 2. 名前で Class メンバーに移動します。
    //    "foo" とタイプして、 "GoToFileMemberExample.Foo" に移動しましょう。
    //
    // 3. コンストラクターに移動します。
    //    "new" 、または "ctor" とタイプします。
    //
    // 4. 可視属性 (Visibility - public / private) で移動します。
    //    "public" 、または "private" とタイプします。


    // ----------

    public class GoToFileMemberExample
    {
        private readonly int bar;

        public GoToFileMemberExample(string foo, int bar)
        {
            this.bar = bar;
            Foo = foo;
        }

        public string Foo { get; private set; }
    }
}
