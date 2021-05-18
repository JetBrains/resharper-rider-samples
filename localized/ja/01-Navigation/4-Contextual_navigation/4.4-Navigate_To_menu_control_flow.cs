using System;
using System.Collections.Generic;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // 移動メニュー (Navigate to) を使ってみます。 - Control Flow Target
    //
    // 現在の場所から移動する便利な方法です。
    // 基本的な仕組みは 基本編 4.1-Navigate_To_menu.cs を参照してください。
    //
    // Navigate to の操作方法
    // <shortcut id="Navigate to">Alt+`        (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Navigate to">Ctrl+Shift+G (Rider Default IntelliJ Keymap)</shortcut>
    //
    // 対象の上にキャレットを置き、実行してみましょう。
    //

    // 1. キャレットが制御キーワード (Control Flow Keyword) 上にある場合の動作を試してみましょう。
    //    ReSharper や Rider はコードの流れも解釈し、次の実行位置を教えてくれます。
    public class NavigateToControlFlowKeyword
    {
        public void ControlFlowWithForStatement()
        {
            for (int i = 0; i < Children.Count; i++)
            {
                var child = Children[i];

                // a) "continue" にキャレットを置き、 Navigate to → Control Flow Target と選択します。
                //    for 構文の i++ のところにキャレットが移動しましたか？
                if (ShouldSkipChild(child))
                    continue;

                // b) "break" にキャレットを置き、 Navigate to → Control Flow Target と選択します。
                //    for ループを抜けた次の実行ラインにキャレットが移動しましたか？
                if (ShouldStop(child))
                    break;

                // c) "return" にキャレットを置き、 Navigate to → Control Flow Target と選択します。
                //    当該関数のスコープであるブレースの末尾 "}" にキャレットが移動しましたか？
                if (ShouldQuit(child))
                    return;
            }

            Console.WriteLine("Finished loop");
        }

        public void ControlFlowWithSwitchStatement(Size size)
        {
            switch (size)
            {
                case Size.Large:
                    // d) "break" にキャレットを置き、 Navigate to → Control Flow Target と選択します。
                    //    switchを抜けた次の実行ラインにキャレットが移動しましたか？
                    break;
                case Size.Medium:
                    // e) "return" にキャレットを置き、 Navigate to → Control Flow Target と選択します。
                    //    当該関数のスコープであるブレースの末尾 "}" にキャレットが移動しましたか？
                    return;
                case Size.Small:
                    // e) "throw" にキャレットを置き、 Navigate to → Control Flow Target と選択します。
                    //    当該関数のスコープであるブレースの末尾 "}" にキャレットが移動しましたか？
                    throw new ArgumentOutOfRangeException("size");
            }

            Console.WriteLine("Finished switch");
        }

        #region Implementation details

        private IList<string> Children { get { return new List<string>(); } }

        private bool ShouldSkipChild(string child)
        {
            return child == "Barry";
        }

        private bool ShouldStop(string child)
        {
            return child == "Rocky";
        }

        private bool ShouldQuit(string child)
        {
            return child == "Damien";
        }

        public enum Size
        {
            Large,
            Medium,
            Small
        }

        #endregion
    }
}
