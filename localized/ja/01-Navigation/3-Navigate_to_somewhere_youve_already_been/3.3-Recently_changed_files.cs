﻿using System;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Recently Changed Files
    //
    // Shows a popup menu of recent edits. Shows code blocks, not files
    //
    // <shortcut id="Recently Changed Files">Ctrl+Shift+, (VS)</shortcut>
    // 

    public class RecentEdits
    {
        private string firstName;
        private string lastName;

        public RecentEdits(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        private string GetName()
        {
            // 1. Implement GetName by returning firstName
            throw new NotImplementedException();
        }

        public void Dump()
        {
            // 2. Implement by uncommenting
            // Console.WriteLine("Name: {0}", GetName());

            // 3. Return to GetName using Recent Edits and change to be firstName + lastName
            // 4. Return back here and uncomment the following
            // Console.WriteLine("Done");
        }
    }
}