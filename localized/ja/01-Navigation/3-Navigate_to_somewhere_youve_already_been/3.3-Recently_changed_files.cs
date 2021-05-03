using System;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // 最近編集したファイルのリストに移動する方法を試してみます。
    //
    //TODO: ReSharperで最近の編集表示機能 (View Recent Edits) が動作しない (ReSharper 2021.1 on VisualStudio2019)
    //TODO: Riderで最近の編集表示機能 (View Recent Edits) はコードブロックでなく、ファイルリストで表示される (Rider 2021.2)
    //
    // 最近の編集内容をポップアップメニューで表示出来ます。
    // (ReSharper) ファイルではなくコードブロックが表示出来ます。
    //
    // <shortcut id="Recently Changed Files">Ctrl+Shift+,    (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Recently Changed Files">Ctrl+E (Toggle) (Rider Default IntelliJ Keymap)</shortcut>
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

            // 4. ここに戻って以下のコメントを外してください。
            //    (この実装に大きな意味はありません。移動の操作感を体験してもらう内容です。)
            //TODO: Riderではこの演習は機能しない。コードブロック表示ではなくファイルリストで、自ファイルは表示されない。
            // Console.WriteLine("Done");
        }
    }
}