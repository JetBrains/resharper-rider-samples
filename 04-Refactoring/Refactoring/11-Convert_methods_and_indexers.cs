using System;
using System.Collections.Generic;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Convert Method to Indexer
    //
    // No shortcut. Invoke via Refactor This menu
    // <shortcut id="Refactor This...">Ctrl+Shift+R</shortcut>

    // Convert Indexer to Method(s)
    //
    // Converts an indexer property to a getter and/or setter method(s)
    //
    // No shortcut. Invoke via Refactor This menu
    // <shortcut id="Refactor This...">Ctrl+Shift+R</shortcut>

    public class ConvertMethodToIndexer
    {
        private readonly IDictionary<string, string> lookup = new Dictionary<string, string>();

        // 1. Convert method to indexer
        //    Method must have single parameter
        //    Place text caret on method definition
        //    Invoke Convert Method To Indexer
        //    ReSharper suggests name
        //    Confirm to convert
        private string GetValueByKey(string key)
        {
            return lookup.ContainsKey(key) ? lookup[key] : string.Empty;
        }

        // 2. Convert method to multi-dimensional indexer
        //    Method must have multiple parameters
        //    Place text caret on method definition
        //    Invoke Convert Method To Indexer
        //    ReSharper suggests name
        //    Confirm to convert
        private string GetValueByKey(string key, string @default)
        {
            return lookup.ContainsKey(key) ? lookup[key] : @default;
        }

        public void OutputName()
        {
            Console.WriteLine(GetValueByKey("foo"));
            Console.WriteLine(GetValueByKey("foo", "default value"));
        }
    }

    public class ConvertIndexerToMethod
    {
        private readonly IDictionary<string, string> lookup = new Dictionary<string, string>();

        // 3. Convert readonly indexer to method
        //    Place text caret on "this"
        //    Invoke Convert Indexer to Method(s)
        //    Create getter method
        public string this[int index]
        {
            get { return lookup.ContainsKey(index.ToString()) ? lookup[index.ToString()] : string.Empty; }
        }

        // 3. Convert read/write indexer to method
        //    Place text caret on "this"
        //    Invoke Convert Indexer to Method(s)
        //    Create getter and setter method
        public string this[string index]
        {
            get { return lookup.ContainsKey(index) ? lookup[index] : string.Empty; }
            set { lookup[index] = value; }
        }
    }
}