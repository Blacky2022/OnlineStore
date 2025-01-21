using StoreDAL.Entities;

namespace StoreDAL.Data.InitDataFactory
{
    public class TestDataFactory : AbstractDataFactory
    {
        public override Category[] GetCategoryData()
        {
            return new[]
            {
                new Category(1, "fruits"),
                new Category(2, "water"),
                new Category(3, "vegetables"),
                new Category(4, "seafood"),
                new Category(5, "meat"),
                new Category(6, "grocery"),
                new Category(7, "milk food"),
                new Category(8, "smartphones"),
                new Category(9, "laptop"),
                new Category(10, "photocameras"),
                new Category(11, "kitchen accessories"),
                new Category(12, "spices"),
                new Category(13, "juice"),
                new Category(14, "alcohol drinks"),
            };
        }

        public override CustomerOrder[] GetCustomerOrderData()
        {
            return new[]
            {
                new CustomerOrder(1, "2025-01-14 14:30:00", 2, 1),
                new CustomerOrder(2, "2025-01-15 10:15:00", 2, 1),
            };
        }

        public override Manufacturer[] GetManufacturerData()
        {
            return new[]
            {
                new Manufacturer(1, "Apple"),
                new Manufacturer(2, "Samsung"),
                new Manufacturer(3, "Sony"),
                new Manufacturer(4, "Nestle"),
                new Manufacturer(5, "Coca-Cola"),
            };
        }

        public override OrderDetail[] GetOrderDetailData()
        {
            return new[]
            {
                new OrderDetail(1, 1, 1, 1.5m, 2), // Order 1 contains 2 units of Product 1
            };
        }

        public override OrderState[] GetOrderStateData()
        {
            return new[]
            {
                new OrderState(1, "New Order"),
                new OrderState(2, "Cancelled by user"),
                new OrderState(3, "Cancelled by administrator"),
                new OrderState(4, "Confirmed"),
                new OrderState(5, "Moved to delivery company"),
                new OrderState(6, "In delivery"),
                new OrderState(7, "Delivered to client"),
                new OrderState(8, "Delivery confirmed by client"),
            };
        }

        public override Product[] GetProductData()
        {
            return new[]
            {
                new Product(1, 1, 1, "Fresh apples from the farm.", 1.5m),
                new Product(2, 2, 2, "1L bottle of pure mineral water.", 0.8m),
                new Product(3, 3, 3, "Organic tomatoes.", 2.0m),
                new Product(4, 4, 4, "Fresh Norwegian salmon.", 15.0m),
            };
        }

        public override ProductTitle[] GetProductTitleData()
        {
            return new[]
            {
                new ProductTitle(1, "Apple", 1),
                new ProductTitle(2, "Water", 2),
                new ProductTitle(3, "Tomato", 3),
                new ProductTitle(4, "Salmon", 4),
            };
        }

        public override User[] GetUserData()
        {
            return new[]
            {
                new User(1, "Admin", "User", "admin", "admin123", 1), // Admin user
                new User(2, "John", "Doe", "john_doe", "password", 2), // Registered user
            };
        }

        public override UserRole[] GetUserRoleData()
        {
            return new[]
            {
                new UserRole(1, "Admin"),
                new UserRole(2, "Registered"),
                new UserRole(3, "Guest"),
            };
        }
    }
}
