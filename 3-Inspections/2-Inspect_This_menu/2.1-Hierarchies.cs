using System.Windows.Forms;

namespace JetBrains.ReSharper.Koans.Inspections
{
    // Inspect This menu - Hierarchies
    //
    // Inspect class hierarchies
    //
    // Ctrl+Shift+Alt+A (VS/IntelliJ)

    // 1. Display hierarchies of IComponent
    //    Place caret on IComponent and Invoke Inspect This
    //    Results are displayed in an Inspection window
    //    Select the type of hierarchy shown in the toolbar
    //    Choose from Class, Subtypes, Supertypes, Implementation and Interface leaves
    public interface IComponent
    {
    }

    // 2. Display hierarchies of BaseClass
    //    Note differences with IComponent - shows class hierarchy including Object,
    //    Implementation hierarchy shows BaseClass in context of related hierarchies
    public class BaseClass : IComponent
    {
    }

    public class DerivedClass1 : BaseClass
    {
    }

    public class DerivedClass2 : BaseClass
    {
    }

    public class DeepestDerivedClass : DerivedClass2
    {
    }

    public class UnrelatedClass : IComponent
    {
    }

    // 3. Display hierarchies of UserControl
    //    Doesn't show much until you uncheck "Show Elements from this Solution"
    public class UserControl : Button
    {

    }
}