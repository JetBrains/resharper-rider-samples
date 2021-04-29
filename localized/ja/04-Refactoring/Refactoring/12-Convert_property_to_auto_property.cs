﻿namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Convert Property to Auto Property
    //
    // Refactoring has no keyboard shortcut. Invoke via Refactor This menu
    // <shortcut id="Refactor This...">Ctrl+Shift+R</shortcut>
    //
    // Also available as Quick Fix via <shortcut id="Show context actions">Alt+Enter</shortcut>

    public class ConvertPropertyToAutoProperty
    {
        private string backingStore;
        private string backingStore2;
        private string backingStore3;

        // 1. Convert to Auto Property with refactoring
        //    Place text caret on property definition
        //    Invoke Refactor This menu → Convert Property to Auto-Property
        public string PropertyWithBackingStore
        {
            get { return backingStore; }
            set { backingStore = value; }
        }

        // 2. Convert to Auto Property with Alt+Enter
        //    Note shown as suggestion
        //    Place text caret on property definition
        //    <shortcut id="Show context actions">Alt+Enter</shortcut> and select Convert to auto-property
        public string PropertyWithBackingStore2
        {
            get { return backingStore2; }
            set { backingStore2 = value; }
        }

        // 2. Convert to read-only Auto Property with Alt+Enter
        //    Note shown as hint
        //    Place text caret on property definition
        //    <shortcut id="Show context actions">Alt+Enter</shortcut> and select Convert to auto-property
        public string PropertyWithBackingStore3
        {
            get { return backingStore3; }
        }
    }
}