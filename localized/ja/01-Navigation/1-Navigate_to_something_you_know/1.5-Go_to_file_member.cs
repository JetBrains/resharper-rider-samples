namespace JetBrains.ReSharper.Koans.Navigation
{
    // Go to File Member
    //
    // Navigate to any members defined in the current file
    //
    // <shortcut id="File Member">Alt+\ (VS)</shortcut>
    //
    // 1. Navigate to type by name, CamelHumps, middle matching or wildcard
    //    Type "GoToFileMemberExample"
    //    Type "GTFME"
    //    Type "FileMember"
    //    Type "GoTo*Example"
    //
    // 2. Navigate to class member by name
    //    Type "foo" to navigate to GoToFileMemberExample.Foo
    //
    // 3. Navigate to constructor
    //    Type "new" or "ctor"
    //
    // 4. Navigate to members by visibility
    //    Type "public" or "private"


    // ----------

    public class GoToFileMemberExample
    {
        private readonly int bar;

        public GoToFileMemberExample(string foo, int bar)
        {
            this.bar = bar;
            Foo = foo;
        }

        public string Foo { get; private set; }
    }
}