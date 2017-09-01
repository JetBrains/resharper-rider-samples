using System;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // 显示最近的修改
    //
    // 显示最近修改的弹出菜单
    //
    // Ctrl+Shift+, (VS)
    // Ctrl+Shift+Alt+Backspace (IntelliJ)

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
            // 1. 删除下面的代码, 返回firstName
            throw new NotImplementedException();
        }

        public void Dump()
        {
            // 2. 取消下面代码的注释
            // Console.WriteLine("Name: {0}", GetName());

            // 3. 打开最近修改, 回到GetName(), 改成返回firstName + lastName
            // 4. 再回到这里取消下面代码的注释
            // Console.WriteLine("Done");
        }
    }
}
