using System;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Find Usages advanced
    //
    // Displays a dialog with search options
    //
    // Ctrl+Shift+Alt+F12 (VS)
    // Shift+Alt+F7 (IntelliJ)

    public class FindUsagesAdvanced
    {
        // 1. Look for textual occurrences of Singularity
        //    Should find these two comments - "Singularity" and the code below
        public string Singularity { get; set; }

        public void PrintSingularity()
        {
            Console.WriteLine(Singularity);
            Console.WriteLine("Singularity");
        }

        // 2. Look for textual occurrences of Navigation
        //    Should find lots of namespace usages
        //    b) Reduce scope to current file and try again
        public string Navigation { get; set; }

        // 3. Look for all usages, including dynamic, of DynamicUsage
        //    Should find two usages in code + one textual
        public void DynamicUsage(string argument)
        {
            if (argument == null)
                return;

            var something = GetDynamicObject();
            something.DynamicUsage("sausages");

            // Non-dynamic usage
            this.DynamicUsage("hello");
        }

        private dynamic GetDynamicObject()
        {
            return this;
        }
    }
}