namespace JetBrains.ReSharper.Koans.Navigation.ExampleCode
{
    #region Implementation details

    public interface ISimpleInterface
    {
        void SayHello();
        void SayGoodbye();
    }

    // 按Ctrl+-返回
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
        // 按Ctrl+-返回
        // 尽管是BaseClass的扩展函数，但对DerivedClass使用Navigate To Extension Methods也能跳转到这里来
        public static void ExtensionMethodForBaseClass(this BaseClass self)
        {
            // ...
        }

        // Navigate back (Ctrl+-)
        // Note also works when navigating from BaseClass
        public static DerivedClass MethodExposingDerivedClassAsReturnValue()
        {
            // ...
            return null;
        }
    }

    // 按Ctrl+-返回
    public class ReallyDerivedClass : DerivedClass
    {
    }

    #endregion
}