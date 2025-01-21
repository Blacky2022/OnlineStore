using ConsoleMenu;
using ConsoleMenu.Builder;
using StoreBLL.Models;
using StoreBLL.Services;
using StoreDAL.Data;
using StoreDAL.Data.InitDataFactory;

namespace ConsoleApp1;

public enum UserRoles
{
    Guest,
    Administrator,
    RegistredCustomer,
}

public static class UserMenuController
{
    private static readonly Dictionary<UserRoles, Menu> RolesToMenu;
    private static int userId;
    private static UserRoles userRole;
    private static StoreDbContext context;

    static UserMenuController()
    {
        userId = 0;
        userRole = UserRoles.Guest;
        RolesToMenu = new Dictionary<UserRoles, Menu>();
        var factory = new StoreDbFactory(new TestDataFactory());
        context = factory.CreateContext();
        RolesToMenu.Add(UserRoles.Guest, new GuestMainMenu().Create(context));
        RolesToMenu.Add(UserRoles.RegistredCustomer, new UserMainMenu().Create(context));
        RolesToMenu.Add(UserRoles.Administrator, new AdminMainMenu().Create(context));
    }

    public static StoreDbContext Context
    {
        get { return context; }
    }

    public static void Login()
    {
        Console.WriteLine("=== Login ===");
        Console.Write("Login: ");
        var login = Console.ReadLine();
        Console.Write("Password: ");
        var password = Console.ReadLine();

        var userService = new UserService(context);

        var user = userService.GetAll()
            .Cast<UserModel>()
            .FirstOrDefault(u => u.Login == login && u.Password == password);

        if (user == null)
        {
            Console.WriteLine("Invalid login or password.");
            return;
        }

        userId = user.Id;
        userRole = user.Role.RoleName switch
        {
            "Administrator" => UserRoles.Administrator,
            "RegistredCustomer" => UserRoles.RegistredCustomer,
            _ => UserRoles.Guest
        };

        Console.WriteLine($"Welcome, {user.Name}! Your role is {userRole}.");
    }

    public static void Logout()
    {
        userId = 0;
        userRole = UserRoles.Guest;
        Console.WriteLine("You have been logged out.");
    }

    public static void Start()
    {
        ConsoleKey resKey;
        bool updateItems = true;
        do
        {
            resKey = RolesToMenu[userRole].RunOnce(ref updateItems);
        }
        while (resKey != ConsoleKey.Escape);

        Console.WriteLine("Goodbye!");
    }

    internal static void Register()
    {
        throw new NotImplementedException();
    }
}