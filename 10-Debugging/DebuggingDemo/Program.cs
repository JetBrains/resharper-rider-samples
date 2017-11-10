using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace DebuggingDemo
{
    internal static class Program
    {
        // Select DebuggingDemo Run Configuration in drop down in top right toolbar
        // Add breakpoint to line 26 (`var count = people.Count`)
        // Start debugging
        // Step over, step into (e.g. PrintPeople), step out
        // View values in editor, next to declarations
        // View values in Debug tool window
        //   Can type to search, but will only search visible text, not deep search of objects
        //   Can add watch expressions, with code completion, e.g. people.Count or people[0]
        //   Can use lambdas in watch expressions, e.g. people.FirstOrDefault(p => p.Company.Country == "CZ")
        private static void Main(string[] args)
        {
            var json = File.ReadAllText("people.json");
            var people = JsonConvert.DeserializeObject<List<Person>>(json);
            
            // Add breakpoint to next line
            var count = people.Count;

            PrintPeople(people);
            
            // Advanced - Uncomment next call to PrintPeople
            // Step into, step out of
            // Smart step into - Shift+F7
            //   Rider will prompt which method call to step into
            // Smart set breakpoint - click in gutter, Rider will prompt to add breakpoint for 
            //   method call or lambda expression, or both ("All")
//            PrintPeople(FilterPeople(people, BuildPredicate(person => person.Company.Country, "CZ")));

            Console.WriteLine("Press <enter> to quit.");
            // See "Console" tab in Debug tool window for output, and to hit <enter>
            Console.ReadLine();
        }
        
        private static void PrintPeople(List<Person> people)
        {
            for (var i = 0; i < people.Count; i++)
            {
                var person = people[i];
                
                // Control flow
                // Add breakpoint on next line (`var company = person.Company`)
                // Right click on `i` in Debug tool window, set value to 0 - resets loop
                // Alternatively, right click on line with `for` above, select "Set Next Statement" - resets loop
                var company = person.Company;
                
                PrintPerson(person);
            }
        }

        private static void PrintPerson(Person person)
        {
            var name = person.Name;
            Console.WriteLine(name);
        }
        
        private static List<Person> FilterPeople(IEnumerable<Person> people, Func<Person, bool> predicate)
        {
            return people.Where(predicate).ToList();
        }

        private static Func<Person, bool> BuildPredicate(Func<Person, string> propertyAccessor, string value)
        {
            return person => propertyAccessor(person) == value;
        }
    }
}