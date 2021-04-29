using System;
using System.ComponentModel;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // File Structure Window
    //
    // Displays outline of file
    //
    // <shortcut id="Show Structure window">Ctrl+Alt+F (VS)</shortcut>
    //
    //
    // 1. Double click to navigate
    // 2. Select "Track caret in editor" and move around the editor
    // 3. Use the Next and Previous buttons to navigate around
    // 4. Explore the right click options
    // 5. Type in the window to filter

    public class FileStructureWindow : IComponent
    {
        public FileStructureWindow()
        {
            Name = "Hello";
        }

        public string Name { get; private set; }
        
        #region Implementation of IComponent

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ISite Site { get; set; }
        public event EventHandler Disposed;

        #endregion
    }
}