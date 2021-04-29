namespace JetBrains.ReSharper.Koans.Navigation.ExampleCode
{
    #region Implementation details

    public interface ISimpleInterface
    {
        void SayHello();
        void SayGoodbye();
    }

    // Navigate back <shortcut id="Back">Ctrl+- (minus)</shortcut>
    public class BaseClass
    {
        public virtual void VirtualMethod()
        {
        }

        public virtual string VirtualProperty
        {
            get { return "hello"; }
        }
    }

    public static class BaseClassExtensions
    {
        // Navigate back <shortcut id="Back">Ctrl+- (minus)</shortcut>
        // Note also works as extension method for DerivedClass
        public static void ExtensionMethodForBaseClass(this BaseClass self)
        {
            // ...
        }

        // Navigate back <shortcut id="Back">Ctrl+- (minus)</shortcut>
        // Note also works when navigating from BaseClass
        public static DerivedClass MethodExposingDerivedClassAsReturnValue()
        {
            // ...
            return null;
        }
    }

    // Navigate back <shortcut id="Back">Ctrl+- (minus)</shortcut>
    public class ReallyDerivedClass : DerivedClass
    {
    }

    #endregion
}