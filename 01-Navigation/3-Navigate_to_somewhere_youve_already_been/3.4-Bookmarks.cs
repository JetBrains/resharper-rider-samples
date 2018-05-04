namespace JetBrains.ReSharper.Koans.Navigation
{
    // 书签
    // ReSharper - Navigate - Bookmarks
    // 设置书签\取消书签\在书签中导航
    //
    // Ctrl+Shift+<num> 设置或取消一个带编号的书签
    // Ctrl+<num> 导航到指定编号的书签
    // Ctrl+` 显示书签的弹出菜单 (这个组合键很容易键盘冲突)
    // ReSharper.ReSharper_BookmarksBookmarsMenu 可以改成Alt+Shift+`
    //
    // 1. 使用Go To File Member功能(Alt+\)跳转到MethodOne,
    //    按下Ctrl+Shift+1设置书签, 左边会出现书签1的标记 (可能会被其他标记覆盖, 如灯泡, 榔头之类)
    // 
    // 2. 导航到MethodTwo, MethodThree, 分别设置书签2, 书签3
    //
    // 3. 使用Ctrl+1, Ctrl+2, Ctrl+3在这3个书签之间跳转
    //
    // 4. Ctrl+Shift+1取消书签1
    //
    // 5. 使用Ctrl+`弹出书签菜单, 点击书签可以跳转
    //
    // 6. 设置匿名书签, 同样可以点击跳转
    //
    // 7. ReSharper - Navigate - Bookmarks - Clear All Bookmarks, 删除所有书签
    public class Bookmarks
    {
        public void MethodOne()
        {
        }

        public void MethodTwo()
        {
        }

        public void MethodThree()
        {
        }
    }
}
