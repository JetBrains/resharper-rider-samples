using System.Diagnostics;

namespace DebuggingDemo
{
    // Uncomment to customise display of Person instances
    // Note code completion in expressions - e.g. "{Na<completion>}"
//    [DebuggerDisplay("{Name} ({Email})")]
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Company Company { get; set; }
    }
    
    public class Company
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}