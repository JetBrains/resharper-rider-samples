namespace EssentialShortcuts
{
    // Navigate To メニューを使ってみます。
    //
    // 現在の場所から移動したい時に利用できるコンテキストメニューを表示します。
    // これ１つ覚えておけば目的ごとの個別ショートカットを憶える必要がない便利なナビゲーション機能です。
    //
    // <shortcut id="Navigate To...">Ctrl+Shift+G (Rider Default Keymap)</shortcut>
    // <shortcut id="Navigate To...">Alt+` (Rider VisualStudio Keymap)</shortcut>
    //
    // 下の例で試してみましょう。２つの方法があります。
    // クラス名にキャレットを置き、
    // 1. 上で示したショートカットで 'Navigate to...' を起動します。
    // 2. <shortcut id="Show context actions">Alt+Enter</shortcut> を押し、'Navigate To' とタイプします。
    //
    // いずれの場合も表示されたコンテキストメニューで任意のワードをタイプすると、その内容で機能がフィルターできます。
    // 例えば、 'Navigate to...' を起動したコンテキストメニューで 'Extension methods' とタイプしてみてください。
    //
    // (ここで表示されるほとんどの選択肢はこの演習例では意味をなしません。後のセクションで詳しく説明します。)
    public class NavigateTo
    {
    }


    // Refactor This メニューを使ってみます。
    //
    // 現在の場所で利用可能なリファクタリングのメニューを表示します。
    // これも１つ覚えておけば目的ごとの個別ショートカットを憶える必要がない便利な機能です。
    //
    // <shortcut id="Refactor This...">Ctrl+Alt+Shift+T (Rider Default Keymap)</shortcut>
    // <shortcut id="Refactor This...">Ctrl+Shift+R (Rider VisualStudio Keymap)</shortcut>
    //
    // クラス名にキャレットを置き、
    // 3. 上で示したショートカットで 'Refactor This' を起動します。
    //    rename を選択し、クラス名を rename してみましょう。
    // 4. <shortcut id="Show context actions">Alt+Enter</shortcut> を押し、'Refactor This' とタイプします。
    //    続けて 'Rename' とタイプして rename してみましょう。
    //
    // (詳細は次のセクションで説明します。)
    public class RefactorThis
    {
    }


    // Generate Code メニューを使ってみます。
    //
    // 現在の場所で利用可能なコード生成のメニューを表示します。
    //
    // <shortcut id="Generate...">Alt+Insert (in text editor / Rider Default Keymap)</shortcut>
    // <shortcut id="Generate...">Ctrl+N (in text editor / Rider VisualStudio Keymap)</shortcut>
    //
    // (詳細は Editing のセクションで説明します。)
    public class GenerateCode
    {
    }

    // Inspect This メニューを使ってみます。
    //
    // 現在の場所で利用可能なコード解析とコントロールフローを分析するためのメニューを表示します。
    // これ１つ覚えておけば変数解析の個別ショートカットを憶える必要がない便利な機能です。
    //
    // <shortcut id="Inspect This...">Ctrl+Shift+Alt+A (Common)</shortcut>
    //
    // クラス名にキャレットを置き、
    // 5. 上で示したショートカットで 'Inspect This...' を起動します。
    // 6. <shortcut id="Show context actions">Alt+Enter</shortcut> を押し、 'Inspect This' とタイプします。
    //    続けて 'TypeHierarchy' とタイプして 継承関係を確認してみましょう。
    //
    // (ここで表示されるほとんどの選択肢はこの演習例では意味をなしません。後のセクションで詳しく説明します。)
    public class InspectThis
    {
    }
}
