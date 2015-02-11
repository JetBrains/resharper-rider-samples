using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    // Generate Code menu
    //
    // Displays a contextual menu of options for generating code available at the current location
    //
    // Alt+Insert (in text editor)
    //
    // (Alt+Insert on Solution Explorer invokes Generate menu for File Templates,
    //  see Live Templates section)

    public class InsertConstructor
    {
        // 1. Insert constructor
        //    Place caret inside class
        //    Invoke Generate Code and select constructor
        //    Caret is placed ready to enter parameters


    }

    public class InsertConstructorWithParameters
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // 1. Insert constructor
        //    Place caret inside class
        //    Invoke Generate Code and select constructor
        //    Select properties to generate and click OK


    }

    public class GenerateOverridingMembers : BaseClass
    {
        // 2. Generate overriding members
        //    Place caret inside class
        //    Invoke Generate and select Overriding Members
        //    Select members to implement and click OK


    }

    public class GeneateEquality
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // 3. Generate equality methods
        //    Place caret inside class
        //    Invoke Generate and select Equality members
        //    Select members to be compared for equality, and optionally override equals operators
        //    Generates Equals + GetHashCode


    }


    public class GenerateDelegatingMembers
    {
        private readonly IService service;

        public GenerateDelegatingMembers(IService service)
        {
            this.service = service;
        }

        // 4. Generate delegating members
        //    Given a field of a given type, create members to delegate to that inner instance
        //    Place caret inside class
        //    Invoke Generate and select Delegating members
        //    Select the members to delegate
        //    If all members are implemented, this class can then implement IService
        

    }

    public class GenerateFromUsage
    {
        // 5. Generate from usage
        //    Alt+Enter on missing symbols to generate them


        // 5.1 Generate variable
        //     Uncomment the Console.WriteLine statement message will be undefined
        //     Alt+Enter on message to get option to create local variable
        //     Specify type, hit tab and caret is moved to allow for setting value
        public void GenerateVariable()
        {
            //Console.WriteLine(message);
        }

        // 5.2 Generate method
        //     Uncomment following statements. The GetMessage method will be undefined
        //     Alt+Enter on GetMessage to get option to create method
        //     ReSharper will infer return type and parameters
        public void GenerateMethod()
        {
            //string message = GetMessage(42);
            //Console.WriteLine(message);
        }

        // 5.3 Generate class (great for TDD!)
        //     Uncomment the following statements. The class will be undefined
        //     Alt+Enter on Processor to get option to create class
        //     ReSharper will create class + constructor
        //     Tab throw options 
        public void GenerateClass()
        {
            //var message = new Message();
            //var processor = new Processor(message);
            //Console.WriteLine(processor);
        }
    }

    public class GenerateSwitchLabels
    {
        public void Method(DayOfWeek day)
        {
            // 6. Generate switch labels
            //    Place text caret inside switch statement
            //    Alt+Enter and select Generate switch labels
            switch (day)
            {

            }
        }
    }

    #region Implementation details

    public class BaseClass
    {
        public virtual void VirtualMethod()
        {
        }

        public virtual string VirtualProperty { get { return "hello"; } }
    }

    public interface IService
    {
        void SayHello();
        void Shout();
        int Choose(string options);
    }

    public class Message
    {
        public string Id { get; set; }
        public string Body { get; set; }
    }

    #endregion
}