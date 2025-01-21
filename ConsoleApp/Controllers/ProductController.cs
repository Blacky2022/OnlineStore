using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using StoreBLL.Models;
using StoreBLL.Services;
using StoreDAL.Data;

namespace ConsoleApp.Controllers
{
    public static class ProductController
    {
        private static StoreDbContext context = UserMenuController.Context;

        public static void AddProduct()
        {
            throw new NotImplementedException();
        }

        public static void UpdateProduct()
        {
            throw new NotImplementedException();
        }

        public static void DeleteProduct()
        {
            throw new NotImplementedException();
        }

        public static void ShowProduct()
        {
            throw new NotImplementedException();
        }

        public static void ShowAllProducts()
        {
            Console.WriteLine("=== Product List ===");
            var productService = new ProductService(context);

            try
            {
                var products = productService.GetAll();

                if (!products.Any())
                {
                    Console.WriteLine("No products available.");
                    return;
                }

                foreach (var product in products)
                {
                    var productModel = (ProductModel)product;
                    Console.WriteLine($"- {productModel.Title.Name} by {productModel.Manufacturer.Name}");
                    Console.WriteLine($"  Price: {productModel.Price:C}");
                    Console.WriteLine($"  Description: {productModel.Description}");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load products: {ex.Message}");
            }
        }

        public static void AddCategory()
        {
            throw new NotImplementedException();
        }

        public static void UpdateCategory()
        {
            throw new NotImplementedException();
        }

        public static void DeleteCategory()
        {
            throw new NotImplementedException();
        }

        public static void ShowAllCategories()
        {
            throw new NotImplementedException();
        }

        public static void AddProductTitle()
        {
            throw new NotImplementedException();
        }

        public static void UpdateProductTitle()
        {
            throw new NotImplementedException();
        }

        public static void DeleteProductTitle()
        {
            throw new NotImplementedException();
        }

        public static void ShowAllProductTitles()
        {
            throw new NotImplementedException();
        }

        public static void AddManufacturer()
        {
            throw new NotImplementedException();
        }

        public static void UpdateManufacturer()
        {
            throw new NotImplementedException();
        }

        public static void DeleteManufacturer()
        {
            throw new NotImplementedException();
        }

        public static void ShowAllManufacturers()
        {
            throw new NotImplementedException();
        }
    }
}