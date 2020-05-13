namespace JetBrains.ReSharper.Koans.Navigation
{
    // Quick Find Usages
    //
    // Displays popup menu of usages in current file
    //
    // <shortcut id="Show Usages">Alt+Shift+F12 (VS)</shortcut>
    //

    public class QuickFindUsages
    {
        private const double MinValue = -3.5;
        private const double MaxValue = 3.5;

        public double Adjust(double original, double delta)
        {
            // 1. Place the caret on newValue and invoke Quick Find Usages
            var newValue = original + delta;

            if (newValue < MinValue)
                newValue = MinValue;

            if (newValue > MaxValue)
                newValue = MaxValue;

            return newValue;
        }
    }
}