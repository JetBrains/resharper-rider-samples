using System;
using System.Collections.Generic;
using System.Linq;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Extract Method
    //
    // Creates a new method based on a selected code fragment
    //
    // Ctrl+R, M (VS)
    // Ctrl+Alt+M (IntelliJ)

    // Inline Method
    //
    // Replaces the call site of a method call with the contents of the method,
    // optionally removing the original method definition
    //
    // Ctrl+R, I (VS)
    // Ctrl+Alt+N (IntelliJ)

    public class ExtractMethod
    {
        public List<string> LongMethod(IEnumerable<string> items)
        {
            var results = new List<string>();
            foreach (var item in items)
            {
                // 1. Extract method, with parameters and return value
                //    Select the next two lines of code. Note that it uses "item" and creates the "result" variable
                //    Invoke Extract Method - confirm name, select return value, parameters, make static/virtual, etc.
                var result = item.ToUpperInvariant();
                result = new string(result.Reverse().ToArray());

                // Don't select this line
                results.Add(result); 
            }
            return results;
        }
    }

    public class InlineMethod
    {
        private const string Name = "Fred";

        public string SayHello()
        {
            // 2. Inline Method
            //    Place the text caret on the method name
            //    Invoke Inline Method
            //    Confirm to inline all instances, and remove original method definition
            Console.WriteLine("Hello " + GetName());
            Console.WriteLine("Hi " + GetName());
        }

        public string GetName()
        {
            return Name;
        }
    }
}