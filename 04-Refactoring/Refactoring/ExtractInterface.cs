using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Extract Interface
    //
    // Extracts an interface based on the current class
    //
    // No keyboard shortcut. Invoke via Refactor This menu
    // Ctrl+Shift+R

    // 1. Extract interface
    //    Place text caret on type definition
    //    Invoke Refactor This → Extract Interface
    //    Confirm name of interface, location and which members
    //    If selecting private or protected members, ReSharper warns that they will be made public
    public class Person
    {
        public Person(string forename, string surname, int age)
        {
            Forename = forename;
            Surname = surname;
            Age = age;

            Dump();
        }

        public string Forename { get; private set; }
        public string Surname { get; private set; }
        public string Fullname { get { return Forename + " " + Surname; } }
        public int Age { get; private set; }

        private void Dump()
        {
            Console.WriteLine("{0} is {1} years old", Fullname, Age);
        }
    }

    // 2. Extract interface from hierarchy
    //    Place text caret on type definition
    //    Invoke Refactor This → Extract Interface
    //    Confirm name of interface, location and which members - list includes inherited members
    //    If selecting private or protected members, ReSharper warns that they will be made public
    public class DerivedPerson : BasePerson
    {
        public DerivedPerson(string forename, string surname, int age, string title)
            : base(forename, surname, age)
        {
            Title = title;
        }

        public string Title { get; private set; }
    }

    public class BasePerson
    {
        public BasePerson(string forename, string surname, int age)
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