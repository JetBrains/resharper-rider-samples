namespace EssentialShortcuts
{
    // <shortcut id="Show context actions">Alt+Enter</shortcut>
    //
    // QuickFix 機能を使ってみましょう。
    //
    // QuickFix は、Inspections (コード検査機能 = 波線で表示されるところ) や、
    // 現在のキャレット位置に応じて ReSharper や Rider が提供する機能を
    // 簡単に (ダイレクトに) 適用することが出来ます。
    //
    // もちろん、メニューから機能を選ぶことで、ReSharper や Rider が提供する
    // 全ての機能を選択して適用することもできます。
    //
    // QuickFix があることは、エディタの左側余白(行番号付近)に表示されます。
    // 例えば、以下のようなバリエーションがあります。
    //  - 黄色の電球: 警告の修正
    //  - 赤色の電球: エラーの修正
    //  - ハンマー  : コンテキストアクションの適用 (選択箇所特有の機能適用)
    //  - などなど
    //
    // (補足)
    // 「コンテキスト」という言葉は日本語だと「文脈」と翻訳されますが、
    // 「その時の状況」といったイメージで理解すると良いでしょう。
    // ReSharper や Rider は、選択箇所そのものの問題だけでなく、
    // その時の状況 (前後関係やそこに至る文脈) に応じて
    // 推奨する改善や修正を提示してくれます。
    // ソフトウエア業界では、こういった前後関係の文脈や
    // 時間的連続性を言うときに「コンテキスト」という表現を
    // 使うことが多いです。
    // https://ja.wikipedia.org/wiki/%E3%82%B3%E3%83%B3%E3%83%86%E3%82%AF%E3%82%B9%E3%83%88
    //

    // 1. Inspection (コード検査結果) に QuickFix を適用してみます
    //    設定で定義している命名スタイルと一致しないクラス名があったとします。
    //    ReSharper や Rider は 波線で教えてくれます。
    //
    //    badlyNamedClass に波線が引かれていると思います (*1)。
    //    <shortcut id="Show context actions">Alt+Enter</shortcut> を押すか、
    //    エディター左側の余白、行番号付近にある電球アイコンをクリックしましょう。
    //
    //    "Rename to 'BadlyNamedClass'" とコードスタイルに設定されている
    //    命名規則に適合した修正が提案されているはずです。選択して修正してみましょう。
    //
    //    (*1)
    //    もし、badlyNamedClass に波線が引かれていない場合は、
    //    あなたが使っている ReSharper や Rider のコードスタイル設定が、
    //    この演習が期待している前提と違っている可能性が高いです。
    //    コードスタイルの設定に関しては以下を参照してください。
    //    https://www.jetbrains.com/resharper/features/code_formatting.html
    //
    // (Inspections (コード検査) については Section 3 で詳しく説明します)
    public class badlyNamedClass
    {
    }

    public class ContextAction
    {
        public static string FormatString(string arg)
        {
            // 2. コンテキストアクションを適用してみます
            //    下の "arg" を選択してキャレットを置いてください。
            //    ハンマーのアイコンが表示されましたか？
            //    コンテキストアクションを使うことが出来ます(波線は出ませんので注意！)。
            //    <shortcut id="Show context actions">Alt+Enter</shortcut> を押して、
            //    "To String.Format invocation" を選択してください。
            //    String.Format 形式に簡単に修正できます。
            //
            //    (注意)
            //    C#での文字列操作は気付かずパフォーマンス悪化に陥ることが多いです。
            //    言語仕様を理解していないと、メモリ消費、実行速度の２つの面で課題が出ます。
            //    メモリ消費の観点では '+' 演算は使うべきではありません。
            //    StringBuilder 、または内部的に StringBuilder を使っている
            //    文字列補完機能 '$' を使うべきです。
            //    もし、実行速度にこだわるのであればもう少し実装方式を考える必要が出てくるでしょう。
            //
            //    String 型と StringBuilder 型 の違い
            //    https://docs.microsoft.com/ja-jp/dotnet/api/system.text.stringbuilder?view=net-5.0#the-string-and-stringbuilder-types
            //
            //    Performance Of String Concatenation In C# (C#における文字列結合の性能考察)
            //    https://dotnetcoretutorials.com/2020/02/06/performance-of-string-concatenation-in-c/
            //
            return "Hello" + arg + "World";
        }
    }

    // 3. Go to action 機能を使ってみます。
    //    下のクラス名のどこかにキャレットを置き、
    //    <shortcut id="Show context actions">Alt+Enter</shortcut> を押します。
    //
    //    コンテキストメニューが表示されている状態で 'rename' とタイプし、
    //    たくさんの機能からフィルターして表示される 'Rename...' を選択します。
    //
    //    このように、 ReSharper や Rider は、
    //    様々な場所で直接タイプすることで機能をフィルターし、
    //    直接呼び出すことが出来ます。
    public class GoToAction
    {
    }
}
