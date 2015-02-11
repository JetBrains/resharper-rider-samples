using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    namespace ExtractSuperclass
    {
        // Extract Superclass
        //
        // Extract members to act as a new base class to the current class
        //
        // No keyboard shortcut. Invoke via Refactor This menu
        // Ctrl+Shift+R

        // 1. Extract superclass
        //    Place text caret on type definition
        //    Invoke Refactor This → Extract Superclass
        //    Confirm name of base class, location and which members
        //      (Select Forename, Surname and Age)
        //    ReSharper creates a new class with the members, inherits from it
        public class Person
        {
            public Person(string forename, string surname, int age)
            {
                Forename = forename;
                Surname = surname;
                Age = age;
            }

            public string Forename { get; private set; }
            public string Surname { get; private set; }

            public string Fullname
            {
                get { return Forename + " " + Surname; }
            }

            public int Age { get; private set; }
        }

        // 2. Extract interface from hierarchy
        //    Place text caret on type definition
        //    Invoke Refactor This → Extract Superclass
        //    Confirm name of base class, location and which members - list includes inherited members
        //      (Select SayHello)
        public class TitledPerson : SimplePerson
        {
            public TitledPerson(string forename, string surname, int age, string title)
                : base(forename, surname, age)
            {
                Title = title;
            }

            public string Title { get; private set; }

            public string SayHello()
            {
                Console.WriteLine("Hello {0}", Forename);
            }
        }

        public class SimplePerson
        {
            public SimplePerson(string forename, string surname, int age)
            {
                Forename = forename;
                Surname = surname;
                Age = age;
            }

            public string Forename { get; private set; }
            public string Surname { get; private set; }
            public int Age { get; private set; }
        }
    }
}