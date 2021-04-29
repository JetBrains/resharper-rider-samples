using System;
using System.Collections.Generic;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Navigate To menu
    //
    // Displays a contextual menu of options you can use to navigate to from
    // your current location
    //
    // Very useful way of navigating without having to learn ALL of the shortcuts!
    //
    // <shortcut id="Navigate To...">Alt+`</shortcut>
    //


    // 1. When caret is on a control flow keyword
    public class NavigateToControlFlowKeyword
    {
        public void ControlFlowWithForStatement()
        {
            for (int i = 0; i < Children.Count; i++)
            {
                var child = Children[i];

                // a) Place the caret on "continue". Navigate To → Control Flow Target
                //    takes the caret to the i++ in the for declaration
                if (ShouldSkipChild(child))
                    continue;

                // b) Place the caret on "break". Navigate To → Control Flow Target
                //    takes the caret to the next statement after the loop
                if (ShouldStop(child))
                    break;

                // c) Place the caret on "return". Navigate To → Control Flow Target
                //    takes the caret to the closing brace of the function
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
                    // d) Place the caret on "break". Navigate To → Control Flow Target
                    //    takes the caret to the first statement after the switch
                    break;
                case Size.Medium:
                    // e) Place the caret on "return". Navigate To → Control Flow Target
                    //    takes the caret to the closing brace of the function
                    return;
                case Size.Small:
                    // e) Place the caret on "throw". Navigate To → Control Flow Target
                    //    takes the caret to the closing brace of the function
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