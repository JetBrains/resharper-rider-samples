using System;
using System.Drawing;
using System.Text;


namespace JetBrains.ReSharper.Koans.UnitTesting
{
    // Code cleanup
    //
    // Cleanup the code according to your style
    //
    // Ctrl+E, Ctrl+C (VS)
    // Ctrl+Alt+F (IntelliJ)
    //
    // Silent cleanup:
    // Ctrl+Shift+Alt+F 
    public class CustomProfile
    {



        // 1. Custom profile
        //    Invoke Code Cleanup
        //    Select "Edit Profiles"
        //    Click Add
        //    Select options
        //    Note that code formatting options are defined elsewhere in options
        //    The profile declares what formatting options are applied, not what they are
        public                    void             BadlySpacedMethod(string   options     )
        {
            



               }


        // Note that content split over multiple lines is not changed
        public

                                    void


            MultilineValuesNotMoved(   ) { }


        // Note that redundancies are removed (including usings at top of file)
        private string name = "Stuff";
        public void ReferencingThis()
        {
            this.name = "blah";
        }



        public void UsesVar()
        {
            // Note that var usage is made consistent
            var fruit = "banana";
            string vegetable = "potato";
        }


        public void ReferencesAreShortened()
        {
            var x = 42;
            // Note that references are shortened
            System.Diagnostics.Debug.Assert(x == 42);
        }
    }
}