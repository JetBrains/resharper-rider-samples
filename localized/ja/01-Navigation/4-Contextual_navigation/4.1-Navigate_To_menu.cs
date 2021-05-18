// 移動メニュー (Navigate to) を使ってみます。 - 基本
//
// 現在の場所から移動する機能を呼び出すコンテキストメニューを表示します。
// これだけ覚えておけば、移動に関する個別のショートカットを覚える必要がない便利な方法です。
//
// https://www.jetbrains.com/help/resharper/Navigation_and_Search__Navigate_from_Here.html
// https://www.jetbrains.com/help/rider/Navigation_and_Search__Navigate_from_Here.html
//
// <shortcut id="Navigate to">Alt+`        (ReSharper VisualStudio Keymap)</shortcut>
// <shortcut id="Navigate to">Ctrl+Shift+G (Rider Default IntelliJ Keymap)</shortcut>
//
// 対象の上にキャレットを置き、実行してみましょう。
// ReSharper や Rider は、キャレットが置かれている対象を賢く識別し、
// その対象、文脈、背景から実装者が欲しくなる移動の機能を提供します。
// (つまり、キャレットが置かれた場所によってメニューの内容が変わります。)
//
// 補足
// Rider Default IntelliJ Keymap の場合、Go! と覚えましょう (Ctrl+Shift+G の "G" の意味)。
// 対象の上でこのキーを押せば、そこから移動するための何かしらのアクションがリストされます。
// これには、定義箇所や利用箇所のリスト表示といった、移動のための表示機能も含まれます。
// ツールに問い合わせる感覚で気軽に押すようにすると、自然と活用の幅が広がって行くでしょう。
//

// 1. ステートメントを含むすべてのシンボルで動作します。
//    using している名前空間の上で操作して、
//    以下のようなメニューがリストされることを確認し、実行してみましょう。
//      Declaration
//      Implementation
//      Find Usage of Symbol
//      Usage of Symbol
//
// 注意
// resharper-rider-samples/localized/ja のディレクトリをルートで開いてください。
// resharper-rider-samples のディレクトリを開いていると、
// 英語版のプロジェクト側が読み込まれてしまい参照関係がリストに表示されません。
using System;
using System.Collections.Generic;
using System.ComponentModel;

// 2. 自分で定義した名前空間の上で操作してみましょう。
namespace JetBrains.ReSharper.Koans.Navigation
{
}
