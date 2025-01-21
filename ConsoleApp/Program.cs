using ConsoleMenu.Builder;
using StoreDAL.Data;
using StoreDAL.Data.InitDataFactory;

namespace ConsoleApp1
{
    public static class Program
    {
        public static StoreDbContext Context { get; set; }

        public static void Main(string[] args)
        {
            // Initialize TestDataFactory
            var dataFactory = new TestDataFactory();

            // Initialize StoreDbFactory
            var dbFactory = new StoreDbFactory(dataFactory);

            // Create StoreDbContext
            Context = dbFactory.CreateContext();

            // Display Guest Menu
            var guestMenu = new GuestMainMenu();
            var menuItems = guestMenu.GetMenuItems(Context);

            ConsoleKey key;
            do
            {
                Console.WriteLine("\n=== Guest Menu ===");
                foreach (var item in menuItems)
                {
                    Console.WriteLine($"{item.id}: {item.caption}");
                }

                Console.WriteLine("Press ESC to exit.");
                key = Console.ReadKey(true).Key;

                foreach (var item in menuItems)
                {
                    if (key == item.id)
                    {
                        item.action.Invoke();
                        break;
                    }
                }
            }
            while (key != ConsoleKey.Escape);

            Console.WriteLine("Goodbye!");
        }
    }
}
