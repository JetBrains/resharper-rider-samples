namespace JetBrains.ReSharper.Koans.Navigation
{
    // ブックマーク機能を試してみます。
    //
    // TODO: ReSharperでブックマーク機能が動作しない (ReSharper 2021.1 on VisualStudio2019)
    // 
    // ブックマークを付けたり、外したり、ブックマーク先に移動したりします。
    //
    // 簡易見出し付き (with ニーモニック) のブックマークの付け外し
    // <shortcut id="Toggle Bookmark with Mnemonic">Ctrl+F11 (Common)</shortcut>
    //
    // 簡易見出し付きブックマークへの移動
    // <shortcut id="">Ctrl+[0-9] (Common)</shortcut>
    //
    // ブックマークリストのポップアップ表示
    // <shortcut id="Show Bookmarks">Ctrl+`    (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Show Bookmarks">Shift+F11 (Rider Default IntelliJ Keymap)</shortcut>
    //
    // 簡易見出し付きブックマークの直接作成 (上書き)
    // <shortcut id="Toggle Bookmark with X">Ctrl+Shift+[0-9] (Common)</shortcut>
    //
    // 1. 下に定義のある "MethodOne" に移動し、簡易見出し付きブックマーク "1" を設定します。
    //    メソッドの行にキャレットを置き、ショートカットキーを押します。
    //    <shortcut id="Toggle Bookmark with Mnemonic 1">Ctrl+Shift+1</shortcut> 
    //    エディター行番号付近の余白のブックマークアイコンではなく、ショートカットキーで操作しましょう。
    // 
    // 2. 同様に、 "MethodTwo" と "MethodThree" に 2 と 3 のブックマークを設定します。
    //
    // 3. 設定した３つのブックマークを移動してみます。
    //    以下のショートカットで移動してみましょう。
    //    Ctrl+1, Ctrl+2, Ctrl+3
    //
    // 4. ブックマークを削除したり、別の場所に移動したりしてみます。
    //    ブックマークのある行で同じ番号のショートカットを押すと、トグルで削除されます。
    //    他の行でショートカットを押すと、押したショートカットの番号は移動します。
    //    Ctrl+Shift+1, Ctrl+Shift+2, etc
    //
    // 5. ブックマーク一覧を表示して移動してみましょう。
    //    <shortcut id="Show Bookmarks">Ctrl+`    (ReSharper VisualStudio Keymap)</shortcut>
    //    <shortcut id="Show Bookmarks">Shift+F11 (Rider Default IntelliJ Keymap)</shortcut>
    //
    // 6. ポップアップメニューから匿名のブックマークを設定します。
    //    Shift+F11 でポップアップメニューを開き、コードを選択して F11 を押して匿名のブックマークを設定します。
    //    ブックマークのリストを選択すると該当ブックマークの箇所に移動できます。
    public class Bookmarks
    {
        public void MethodOne()
        {
        }

        public void MethodTwo()
        {
        }

        public void MethodThree()
        {
        }
    }
}