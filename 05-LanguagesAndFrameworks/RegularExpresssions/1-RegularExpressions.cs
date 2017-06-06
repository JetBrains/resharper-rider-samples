using System;
using System.Text.RegularExpressions;

namespace JetBrains.ReSharper.Koans.RegularExpressions
{
    // Regular expression support
    //
    // Syntax highlighting, code completion + testing of regular expressions

    public class RegularExpressions
    {
        public static void Editing()
        {
            // 1. Start typing in empty regex string
            //     Add open bracket, square bracket or escape char see code completion
            // 2. Invoke code completion (Ctrl+Space) in various places in expression
            var match = Regex.Match("abc", @"(?<Word>[A-Za-z]+)(\s|\t)+(?# Comment)", RegexOptions.ExplicitCapture);
        }

        public static void ValidateExpression()
        {
            // 3. Place caret on expression and Alt+Enter, select "Validate regular expression"
            //    Enter test words, see that they're captured
            //    See that regex requires a trailing space to capture the last word
            //    Change the "+" before the comment to "*"
            //    Test + click insert. See that the expression has been updated
            var match = Regex.Match("abc", @"(?<Word>[A-Za-z]+)(\s|\t)+(?# Comment)", RegexOptions.ExplicitCapture);
        }

        public static void StringLiteralAsRegularExpression()
        {
            // 4. Make arbitrary string a syntax highlighted regex
            //    Note pattern is not syntax highlighted
            //    Place text caret on string literal
            //    Alt+Enter and select "Make regular expression here"
            //    Note that string literal is now syntax highlighted
            const string pattern = @"(?<Word>[A-Za-z]+)(\s|\t)+(?# Comment)";
            var match = Regex.Match("abc", pattern, RegexOptions.ExplicitCapture);
        }

        public static void CodeCompletionOfMatches()
        {
            var match = Regex.Match("abc", @"(?<Word>[A-Za-z]+)(\s|\t)+(?# Comment)", RegexOptions.ExplicitCapture);

            // 5. Type match. (note trailing period)
            //    Code completion shows match.Groups["Word"], pulling capture from expression
        }
    }
}