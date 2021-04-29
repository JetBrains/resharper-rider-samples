namespace JetBrains.ReSharper.Koans.Editing
{
    // Filtered Completion
    //
    // Filter completion lists, including or excluding by item kind (class, method, etc.)
    // and visibility (public, protected, etc.)
    //
    // Available in automatic, basic, import and smart completion
    //
    // <shortcut id="Basic Completion">Ctrl+Space</shortcut> (basic completion)

    public class FilterCompletion
    {
        // 1. Invoke completion here
        //    ReSharper shows keywords and types
        //    Filter by namespace - Alt+N or Alt+I, N to ignore namespaces
        //    Filter by classes - Alt+C or Alt+I, C to ignore classes
        //    Filter by interfaces - Alt+F or Alt+I, F to ignore classes
        //    Filter by structs - Alt+S or Alt+I, S to ignore classes
        //    Filter by enums - Alt+U or Alt+I, U to ignore enums
        //    Filter by delegates - Alt+D or Alt+I, D to ignore delegates
        //    Filter by keywords - Alt+K or Alt+I, K to ignore keywords





        public void Method()
        {
            // 2. Uncomment "this." and invoke completion after the dot
            //    Filter by field - Alt+F or Alt+I, F to ignore fields
            //    Filter by property - Alt+P or Alt+I, P to ignore fields
            //    Filter by method - Alt+M or Alt+I, M to ignore fields
            //    Filter by public symbol - Alt+1 or Alt+I, 1 to ignore public symbols
            //    Filter by protected symbol - Alt+3 or Alt+I, 3 to ignore protected symbols
            //    Filter by private symbol - Alt+4 or Alt+I, 4 to ignore private symbols
            //this.
        }

        #region Implementation details

        private int _age;

        public string Name { get; set; }
        public int Age { get { return _age; } }

        #endregion
    }
}