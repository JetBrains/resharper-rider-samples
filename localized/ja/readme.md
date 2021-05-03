# ReSharper/Rider の演習 (Workshop)

> 順次翻訳作業中です
> 
> 日本語版はOfficial英語版の以下バージョンを元にしています。
> 
> 2021-04-28 80c5afcd6a971b03be02392b9cf96be1a6147581

この場所では、 [ReSharper](https://jetbrains.com/resharper) や [Rider](https://jetbrains.com/rider) で利用することが出来る多くの機能や、生産性を上げる方法を学ぶことが出来ます。

ステップ・バイ・ステップ の演習として用意してあり、navigation (コードの移動・探索)、 editing (編集)、 inspections (静的解析などの検査)、 refactoring (リファクタリング) などです。 ReSharper や Rider の全ての機能を網羅しているわけではありませんが、初心者から玄人までを対象に、数多くの役立つテクニック (TIPSとトリック) を掲載しています。

また、各演習では、ReSharper や Rider をより効率的に (高速に) 操作出来るキーボードショートカットを紹介します。 全てのショートカットを一度に確認したい場合は、チートシートを活用してください。 JetBrains のウェブサイトからダウンロードできます。 (Rider や ReSharper の [Help] > [Keymap Reference] からウェブサイトの該当ページにジャンプ出来ます。)

オフィシャルのリンク先をいくつか掲載しておきます。

* [JetBrains ReSharper documentation web site](https://www.jetbrains.com/resharper/documentation/)
  * [Visual Studio keyboard scheme](https://www.jetbrains.com/resharper/docs/ReSharper90DefaultKeymap_VS_scheme.pdf)
  * [IntelliJ scheme](https://www.jetbrains.com/resharper/docs/ReSharper90DefaultKeymap_IDEA_scheme.pdf)
* [JetBrains Rider documentation website](https://www.jetbrains.com/rider/documentation/) ([overview of Rider keymaps](https://www.jetbrains.com/help/rider/Reference_Keyboard_Shortcuts_Index.html))
  * [Visual Studio keyboard scheme](https://www.jetbrains.com/help/rider/Reference_Keymap_VS.html)
  * [Rider scheme](https://www.jetbrains.com/help/rider/Reference_Keymap_Rider.html)

この演習は自分のペースで進めることが出来ます。既に理解している部分は読み飛ばしても構いませんし、どのような順序でも練習に取り組むことができます。
(でも、役に立つヒントを見逃さないでくださいね(^^))


## この演習を始める方法

Visual Studio (with ReSharper) 、または Rider で `resharper-rider-samples.sln` を開くだけで練習が始められます。自分が作業する環境に、このリポジトリをコピーしましょう (clone 、または直接ダウンロード)。

一番最初に、ソリューション ( `resharper-rider-samples.sln` 全体 ) をビルドすることを推奨します。一部の演習で使用している、様々な NuGet パッケージが自動的に準備されます。(Navigation や Edit など、コンパイルを必要としない演習も数多くありますが、 UnitTest や ASP.NET MVC のサポートなど、コードのコンパイルやサードパーティー製アセンブリの参照を必要とするものはNuGet パッケージが準備されていないと期待通り動作しません。)

演習は、番号の付いたフォルダで構成されています。各フォルダには１つ、または複数のプロジェクトが含まれており、通常、演習の説明はこれらのプロジェクトのソース内コメントに記載されています。好きなファイルを開いて、自分のペースで練習に取り組むことができます。

演習の種類は以下の通りです:

* `00-EssentialShortcuts` - 使い始める時に知っておくべきキーボードショートカットを紹介します。これらのショートカットを使うと、 ReSharper と Rider のほとんどの機能を呼び出すことが出来ます。
* `01-Navigation` - コードを移動・探索するための様々な方法を紹介します。 Go To (指定対象へのジャンプ) 、 Find Usages (利用箇所の探索) 、Navigating class hierarchies (クラスの継承関係をたどる) などです。
* `02-Editing` - コードを編集するための演習です。強力なコード補完機能、再配置機能 (ある選択ブロックの位置を入れ替えたりする機能) などです。
* `03-Inspections` - ReSharper と Rider が提供する数多くのコード検査 (静的解析機能) について紹介します。コードの潜在的な問題をどのように発見・修正し、管理出来るか、を見ていきます。また、非常に強力な Value Tracking 機能 (ある変数がどこで、どのように更新されて行くか解析する機能) についても紹介します。
* `04-Refactoring` - リファクタリング機能を紹介します。単純な名前の変更や変数のインライン化、クラスの抽出、クラス階層の間でメンバー実装を移動したりすることが出来ます。
* `05-LanguagesAndFrameworks` - ReSharper と Rider が提供する機能の大部分は、サポートする全ての言語フォーマットで動作します。一方で、ASP.NET MVC、XAMLや正規表現など、特定のフレームワークや言語に特化したサポートも提供しています。
* `06-UnitTesting` - UnitTestの演習です。ReSharper と Rider がどのように UnitTest をサポートするかを示します。
* `07-LiveTemplates` - 極めて強力なスニペット補完機能を紹介します。LiveTemplates という機能は、テンプレートに基づいてファイルやコード断片を作成した上で、個別編集したいホットスポットに対して、対話形式で編集することが出来ます。
* `08-StructuralSearchAndReplace` - 強力な検索・置換機能を学びます。ReSharper と Rider は単純なテキスト方式だけではなく、コードパターンに基づいた、非常に強力な検索・置換機能を持っています。
* `09-Tools` - 便利ツールの紹介です。Code Cleanup (コードのお掃除) 、Stack Trace Explorer (スタックトレース・エクスプローラー) 、 To Do Explorer (TODOエクスプローラー) です。


## ショートカットキーと機能

`Find Action...` の機能を使うと、たくさんあるショートカットキーに割り当てられた機能を見つけ出すことが出来ます。ショートカットキーの設定はいくつかの代表的な設定があります。自分がどの設定を使っているか、InstallしたReSharper や Rider の Preferences (設定) を確認してください。

`Find Action...` の機能を呼び出す代表的なショートカットキーは以下の通りです:

- ReSharper Keymap on Windows: `Ctrl + Shift + A`
- Visual Studio Keymap on Windows: `Ctrl + Shift + A`
- Visual Studio Keymap on macOS: `Command (⌘) + Shift (⇧) + A`

キーマップのリファレンスガイドはオンラインで参照できます:

- Rider: https://www.jetbrains.com/help/rider/Reference_Keymap_Rider.html
- ReSharper: https://www.jetbrains.com/help/resharper/Reference__Keyboard_Shortcuts.html

## Open Source - オープンソース

この演習は Apache 2 ライセンスに基づくオープンソースです。演習の資料改善に貢献したいと考えてくださる方は、このリポジトリを fork し、 Pull Request を送ってください。また、コメント、質問、改善提案などがある場合は、 [問題提議](https://github.com/JetBrains/resharper-workshop/issues) を歓迎します。
