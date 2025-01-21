using ConsoleApp.Controllers;
using ConsoleApp1;
using StoreDAL.Data;

namespace ConsoleMenu.Builder;

public class GuestMainMenu : AbstractMenuCreator
{
    public override (ConsoleKey id, string caption, Action action)[] GetMenuItems(StoreDbContext context)
    {
        return new (ConsoleKey id, string caption, Action action)[]
        {
            (ConsoleKey.F1, "Login", UserMenuController.Login),
            (ConsoleKey.F2, "Show product list", ProductController.ShowAllProducts),
            (ConsoleKey.F3, "Register", UserMenuController.Register),
        };
    }
}
