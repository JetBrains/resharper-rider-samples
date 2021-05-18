namespace JetBrains.ReSharper.Koans.Navigation.ExampleCode
{
    #region Implementation details

    public interface ISimpleInterface
    {
        void SayHello();
        void SayGoodbye();
    }

    // 戻る
    // <shortcut id="Navigate back">Ctrl+- (minus) (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Navigate back">Ctrl+Alt+Left  (Rider Default IntelliJ Keymap)</shortcut>
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
        // 戻る
        // <shortcut id="Navigate back">Ctrl+- (minus) (ReSharper VisualStudio Keymap)</shortcut>
        // <shortcut id="Navigate back">Ctrl+Alt+Left  (Rider Default IntelliJ Keymap)</shortcut>
        //
        // 注目: 派生クラスの拡張メソッドに対しても機能します
        public static void ExtensionMethodForBaseClass(this BaseClass self)
        {
            // ...
        }

        // 戻る
        // <shortcut id="Navigate back">Ctrl+- (minus) (ReSharper VisualStudio Keymap)</shortcut>
        // <shortcut id="Navigate back">Ctrl+Alt+Left  (Rider Default IntelliJ Keymap)</shortcut>
        //
        // 注目: 基底クラスから移動してきた場合でも動作します
        public static DerivedClass MethodExposingDerivedClassAsReturnValue()
        {
            // ...
            return null;
        }
    }

    // 戻る
    // <shortcut id="Navigate back">Ctrl+- (minus) (ReSharper VisualStudio Keymap)</shortcut>
    // <shortcut id="Navigate back">Ctrl+Alt+Left  (Rider Default IntelliJ Keymap)</shortcut>
    public class ReallyDerivedClass : DerivedClass
    {
    }

    #endregion
}
