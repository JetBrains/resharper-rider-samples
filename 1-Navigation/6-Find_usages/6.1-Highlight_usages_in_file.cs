namespace JetBrains.ReSharper.Koans.Navigation
{
    // Highlight Usages in File
    //
    // Shift+Alt+F11 (VS)
    // Ctrl+Alt+F7 (IntelliJ)

    public class HighlightUsagesInFile
    {
        private const double MinValue = -3.5;
        private const double MaxValue = 3.5;

        public double Adjust(double original, double delta)
        {
            // 1. Place the caret on newValue and Highlight Usages in File
            //    Note the different colour highlights for read and write usage
            //    Note the highlights in the stripe on the right of the editor
            //    These highlights are clickable, and have tooltips
            //    Escape clears the highlight
            //    Ctrl+Alt+PgUp/Ctrl+Alt+PgDown (VS) to navigate between
            //    Ctrl+Alt+Up/Ctrl+Alt+Down (IntelliJ) to navigate between
            var newValue = original + delta;

            if (newValue < MinValue)
                newValue = MinValue;

            if (newValue > MaxValue)
                newValue = MaxValue;

            return newValue;
        }
    }
}