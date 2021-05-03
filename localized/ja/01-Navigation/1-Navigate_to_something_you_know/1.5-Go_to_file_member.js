// ファイルメンバーへの移動 (JavaScript)
//
// 現在のファイルで定義されているメンバーに移動します。
//
// <shortcut id="File Member">Alt+\    (ReSharper VisualStudio Keymap)</shortcut>
// <shortcut id="File Member">Ctrl+F12 (Rider Default IntelliJ Keymap)</shortcut>
//
// 1. "example" 、または "other" とタイプして移動してみましょう。
//
// 2. 中間一致とワイルドカードを使って移動してみましょう。
//    以下の様にタイプして動きを確認してみましょう。
//      "interesting"
//      "really*function"
//
// 3. アンダースコアで区切られた名前に移動する方法を確認してみます。
//    "rif" とタイプしてみましょう。
//    古いバージョンの場合大文字小文字を区別します - "RIF" ではありません。
//    (参考) Rider 2021.1.2 では "RIF" でもマッチします。

function example(name, age) {
    // ...
}

function other() {
    // ...
}

function really_interesting_function() {
    // ...
}
