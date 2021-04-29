using System;
using System.Runtime.CompilerServices;

namespace JetBrains.ReSharper.Koans.Editing
{
    // Automatic Completion
    //
    // Code completion that appears while typing, to complete method names
    // or elements, etc.
    //
    // Combines Basic, Import and Smart completion
    // Basic = standard code completion from the current context (methods, properties, etc)
    // Import = code completion from other namespaces
    // Smart = filtered code completion for the current context (e.g. only string values for a string parameter)
    //
    // <shortcut id="Basic Completion">Ctrl+Space</shortcut> / Automatic

    public class AutomaticCompletion
    {
        // 1. Type: this.
        //    After the dot, Basic completion shows the code completion options for the current context
        //    Members of the current type are shown in bold
        //    Inherited members are in normal text
        // 2. Type: string value =
        //    After the equals sign, Automatic Completion shows the locally scoped Basic completion options followed
        //      by the wider scope of Basic Completion items, followed by Import Completion items
        //    I.e. Local context (variables, parameters, members)
        //         Locally accessible types (for navigating into)
        //         Importable types (for navigating into, but requires a using statement)
        // 3. The most frequently used item is usually pre-selected e.g. this.Age might be the most used
        // 4. If there isn't a most frequently used item, the most likely item is highlighted but not selected
        //    e.g. "string value =" shows a completion list with stringParameter highlighted
        // 5. Ctrl makes code completion window transparent
        // 6. Dismiss the window with Esc
        // 7. ".", space, tab and enter accept the choice (configurable in options)
        public void ShowCurrentContext(string stringParameter)
        {
            //this.

            //string value 
        }

        #region Implementation details

        public string Name { get; set; }
        public int Age { get; set; }

        public string SayHello(string who)
        {
            return "Hello " + who;
        }

        public string SayGoodbye(string who)
        {
            return "Goodbye " + who;
        }

        #endregion

        // 8. Enter inserts, Tab replaces (configurable in options)
        //    Place caret after the word Say and hit Ctrl+Space
        //    Choose the option and hit enter - text is inserted
        //    Choose the option and hit tab - text is replaced
        // 9. Configure in ReSharper → Options → Intellisense → Completing Characters
        public void ReplacingExistingCode()
        {
            this.SayHello("Matt");

            // Uncomment string literal, try typing Say and completing SayHello
            // Enter will complete and wrap the string literal as a parameter
            // Tab will complete the method call with the string literal pushed after
            //"Matt";
        }

        // 10. Use CamelHumps to match
        //     Start typing: this.SCC to match ShowCurrentContext
        public void UseCamelHumps()
        {
            // this.
        }
    }

    // 11. Completion for overriding members
    //     Type "override" to get a list of members to override, select ToString()
    public class CompleteOverrideKeyword
    {
        // Type here:


        MyFSharp.SharpPerson _sharpPerson = new MyFSharp.SharpPerson("Mary", "Smith");
        
    }

    // 12. Automatic Completion will import types from namespaces of existing references
    //     Start typing ": INotifyPropertyChanged" after the class declaration
    //     ReSharper will show Automatic Completion "INotifyPropertyChanged (in System.ComponentModel)"
    //     Selecting this will add a using System.ComponentModel to the top of the file
    // See also Import Completion
    public class AutomaticImportCompletion
    {
        #region Implementation details

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }

    #region Implementation details

    public static class ExtensionMethods
    {
        public static void SayCheese(this AutomaticCompletion self)
        {
        }
    }

    #endregion
}