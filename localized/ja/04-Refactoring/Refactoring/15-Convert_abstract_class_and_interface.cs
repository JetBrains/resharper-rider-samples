using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Convert Abstract Class to Interface
    //
    // No keyboard shortcut. Invoke via Refactor This menu
    // <shortcut id="Refactor This...">Ctrl+Shift+R</shortcut>

    // Convert Interface to Abstract Class
    //
    // No keyboard shortcut. Invoke via Refactor This menu
    // <shortcut id="Refactor This...">Ctrl+Shift+R</shortcut>


    // 1. Convert abstract class to interface
    //    Place text caret on class definition
    //    Invoke Refactor This → Convert Abstract Class to Interface
    public abstract class AbstractClass
    {
        public abstract string Name { get; protected set; }
    }

    public class DerivedClass : AbstractClass
    {
        private string name;

        public DerivedClass()
        {
            name = "Phil";
        }

        public override string Name
        {
            get { return name; }
            protected set { name = value; }
        }
    }

    // 2. Convert abstract class to interface, when abstract class has implementations
    //    Place text caret on class definition
    //    Invoke Refactor This → Convert Abstract Class to Interface
    //    ReSharper warns abstract class has implementation methods
    //    Cancel, or continue to convert to interface and remove the body of the implementation
    //      (Derived class will not compile)
    public abstract class AbstractClassWithImplementation
    {
        public abstract string Name { get; protected set; }

        public void SayHello()
        {
            Console.WriteLine("Hello " + Name);
        }
    }

    public class DerivedClass2 : AbstractClassWithImplementation
    {
        private string name;

        public DerivedClass2()
        {
            name = "Phil";
        }

        public override string Name
        {
            get { return name; }
            protected set { name = value; }
        }
    }

    // 3. Convert interface to abstract class
    //    Place text caret on class definition
    //    Invoke Refactor This → Convert Abstract Class to Interface
    //    ReSharper creates abstract class with no implementations
    //      and makes implementing methods "override" in derived class
    public interface IPerson
    {
        string Name { get; }
        void SayHello();
    }

    public class Person : IPerson
    {
        private readonly string name;

        public Person(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }

        public void SayHello()
        {
            Console.WriteLine("Hello " + Name);
        }
    }
}