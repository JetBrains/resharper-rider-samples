using System;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // 最近編集した場所にに移動する方法を試してみます。
    //
    //TODO: ReSharperで最近の編集表示機能 (View Recent Edits) が動作しない (ReSharper 2021.1 on VisualStudio2019)
    //TODO: rename file name 3.3-Recently_changed_files.cs -> 3.3-Recent_edits.cs
    //
    // 最近の編集箇所と内容をポップアップメニューで表示出来ます。
    // ファイルではなくコードブロックが表示出来ます。
    //
    // <shortcut id="View Recent Edits">Ctrl+Shift+, (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Recent Locations" >Ctrl+Shift+E (Rider Default IntelliJ Keymap)</shortcut>
    // 

    public class RecentEdits
    {
        private string firstName;
        private string lastName;

        public RecentEdits(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        private string GetName()
        {
            // 1. firstName を返す GetName を実装してください。
            //    コメントを外して Exception の行はコメントアウトしてください。
            // return firstName; 
            throw new NotImplementedException();
        }

        public void Dump()
        {
            // 2. コメントを外して実装してください。
            // Console.WriteLine("Name: {0}", GetName());

            // 3. GetName に ”Recent Edits" を使って戻り、 firstName + lastName に実装を変更します。
            // <shortcut id="View Recent Edits">Ctrl+Shift+, (ReSharper VisualStudio Keymap)</shortcut>
            // <shortcut id="Recent Locations" >Ctrl+Shift+E (Rider Default IntelliJ Keymap)</shortcut>

            // 4. ここに戻って以下のコメントを外してください。
            //    (この実装に大きな意味はありません。移動の操作感を体験してもらう内容です。)
            // Console.WriteLine("Done");
        }
    }
}