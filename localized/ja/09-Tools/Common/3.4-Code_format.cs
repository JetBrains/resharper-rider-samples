﻿using System;

namespace JetBrains.ReSharper.Koans.Tools.Common
{
    // Code format for any language can be configured under
    // ReSharper → Options... → Code Editing
    //
    // Many options available! How to find out which ones apply to a block of code?
    public class CodeFormat
    {
        // 1. Select code from // start to // end
        //    Press <shortcut id="Show context actions">Alt+Enter</shortcut>, select Format selection → Configure
        //    A dialog opens that shows which settings apply to this block of code.
        //
        //    Settings can be changed in this dialog, and our code is reformatted as
        //    an example, making it easier to see which setting does what.
        // start
        public string SayHello(string name, string message)
        {
            if (name == null)    throw new ArgumentNullException(nameof(name));
            if (message == null) throw new ArgumentNullException(nameof(message));

            return $"{message}, {name}!";
        }
        // end
    }
}