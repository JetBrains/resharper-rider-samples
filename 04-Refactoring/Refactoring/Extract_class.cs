using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    namespace ExtractClass
    {
        // Extract Class
        //
        // Creates a new class based on members in the existing class.
        // Updates references to the extracted members to refer to
        // an instance of the new class
        //
        // No keyboard shortcut. Invoke via Refactor This menu
        // Ctrl+Shift+R

        public class Person
        {
            public string Forename { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }

            // 1. Extract address to new class
            //    Select the members of the class to extract (the 5 properties below)
            //    Invoke Refactor This → Extract Class
            //    ReSharper shows dialog with properties already selected to move to extracted class
            //    Give name to extracted class ("Address" - ReSharper then populates reference to be extracted "address")
            //    By default, the original properties are removed
            //      Select from the drop down for "Source class member":
            //      None - original property is removed
            //      Create copy - a copy of the original property is left
            //      Create delegating wrapper - the original property calls into the new instance of the extracted class
            //    Any usages are updated to use the new Address property
            public string HouseNumber { get; set; }
            public string Street { get; set; }
            public string County { get; set; }
            public string PostCode { get; set; }
            public string Country { get; set; }
        }

        public class PersonConsumer
        {
            public void Method()
            {
                var person = new Person();

                // 2. Ensure all properties still work
                Console.WriteLine(person.HouseNumber);
                Console.WriteLine(person.Street);
                Console.WriteLine(person.County);
                Console.WriteLine(person.PostCode);
                Console.WriteLine(person.Country);
            }
        }
    }
}