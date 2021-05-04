using System;
using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // 宣言や利用箇所に移動してみましょう。
    //
    // シンボル定義に移動してみます。
    //
    // <shortcut id="Go to Declaration or Usages">F12    or CTRL + Click (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Go to Declaration or Usages">Ctrl+B or CTRL + Click (Rider Default IntelliJ Keymap)</shortcut>
    //
    public class GoToDefinition
    {
        public void Method(string name, int age)
        {
            // 1. "Person" の上で、宣言へ移動する前述の操作を行います。
            // 2. ショートカットキーを使ってみましょう。
            var person = new Person("Hadi", 53);

            // 3. "name" と "age" のパラメーターに対しても同様に宣言に移動してみましょう。
            var otherPerson = new Person(name, age);

            // 4. "var" に対して、宣言への移動操作を行うと推論した型の定義に移動できます。
            var thirdPerson = otherPerson;

            // 5. ライブラリの型定義に移動してみます。
            //    "Console" の上で、宣言への移動操作を行ってみましょう。
            Console.WriteLine(thirdPerson.Name);

            // 6. Assembly Explorer (アセンブリ・エクスプローラー) で namespace (名前空間) を表示してみます。
            //    "System" の上で、宣言への移動操作を行ってみましょう。
            System.Console.WriteLine();

            // 7. namespace (名前空間) に移動してみます。
            //    "Navigation" の上で、宣言への移動操作を行ってみましょう。
            var type = typeof(JetBrains.ReSharper.Koans.Navigation.GoToDefinition);
        }
    }
}
