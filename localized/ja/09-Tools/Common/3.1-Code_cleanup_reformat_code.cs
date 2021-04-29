namespace JetBrains.ReSharper.Koans.Tools.Common
{
    // Code cleanup
    //
    // Cleanup the code according to your style
    //
    // <shortcut id="Code Cleanup...">Ctrl+E, Ctrl+C (VS)</shortcut>
    //
    //
    // Silent cleanup:
    // <shortcut id="Silent Code Cleanup">Ctrl+E, Ctrl+F</shortcut>
    public class ReformatCode
    {



        // 1. Reformat code
        //    Invoke Code Cleanup
        //    Select Reformat Code profile
        //    Click ok
        //    Note whitespace all cleaned up
        public                    void             BadlySpacedMethod(string   options     )
        {
            



               }


        // Note that content split over multiple lines is not changed
        public

                                    void


            MultilineValuesNotMoved(   ) { }


        // Note that redundant code (e.g. the this. prefix aren't removed)
        private string name = "Stuff";
        public void ReferencingThis()
        {
            this.name = "blah";
        }



        public void UsesVar()
        {
            // Note that var usage is unchanged
            var fruit = "banana";
            string vegetable = "potato";
        }


        public void ReferencesAreNotShortened()
        {
            var x = 42;
            System.Diagnostics.Debug.Assert(x == 42);
        }
    }
}