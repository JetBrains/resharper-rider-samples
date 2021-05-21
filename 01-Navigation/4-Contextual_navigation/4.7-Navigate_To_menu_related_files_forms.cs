using System.Windows.Forms;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // Navigate To menu - Type of Symbol
    //
    // This is a convenient way to navigate from the current location.
    // See "4.1-Navigate_To_menu.cs" for the basic mechanism.
    //
    // How to use Navigate to
    // <shortcut id="Navigate to">Alt+`        (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Navigate to">Ctrl+Shift+G (Rider Default IntelliJ Keymap)</shortcut>
    //
    // Put the caret on the target and use the keyboard shortcut.
    //

    // 1. Navigate to related files. E.g. related designer files
    //    Put text caret here →
    //    Related Files... shows list of other files containing definitions of Form1

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
