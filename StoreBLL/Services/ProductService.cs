namespace StoreBLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using global::StoreBLL.Interfaces;
using global::StoreBLL.Models;
using StoreDAL.Data;
using StoreDAL.Entities;

/// <summary>
/// Provides CRUD operations for products.
/// </summary>
public class ProductService : ICrud
{
    private readonly StoreDbContext context;

    /// <summary>
    /// Initializes a new instance of the <see cref="ProductService"/> class.
    /// </summary>
    /// <param name="context">The database context.</param>
    public ProductService(StoreDbContext context)
    {
        this.context = context ?? throw new ArgumentNullException(nameof(context));
    }

    /// <summary>
    /// Adds a new product to the database.
    /// </summary>
    /// <param name="model">The product model to add.</param>
    public void Add(AbstractModel model)
    {
        if (model is not ProductModel productModel)
        {
            throw new ArgumentException("Invalid model type. Expected ProductModel.");
        }

        var entity = new Product
        {
            TitleId = productModel.Title.Id,
            ManufacturerId = productModel.Manufacturer.Id,
            Description = productModel.Description,
            UnitPrice = productModel.Price,
        };

        this.context.Products.Add(entity);
        this.context.SaveChanges();
    }

    /// <summary>
    /// Deletes a product by ID.
    /// </summary>
    /// <param name="modelId">The ID of the product to delete.</param>
    public void Delete(int modelId)
    {
        var product = this.context.Products.FirstOrDefault(p => p.Id == modelId);
        if (product == null)
        {
            throw new KeyNotFoundException($"Product with ID {modelId} not found.");
        }

        this.context.Products.Remove(product);
        this.context.SaveChanges();
    }

    /// <summary>
    /// Retrieves all products from the database.
    /// </summary>
    /// <returns>A list of all products as AbstractModel objects.</returns>
    public IEnumerable<AbstractModel> GetAll()
    {
        return this.context.Products.Select(p => new ProductModel(
            p.Id,
            new ProductTitleModel(p.Title.Id, p.Title.Title),
            new ManufacturerModel(p.Manufacturer.Id, p.Manufacturer.Name),
            p.Description,
            p.UnitPrice)).ToList();
    }

    /// <summary>
    /// Retrieves a product by ID.
    /// </summary>
    /// <param name="id">The ID of the product.</param>
    /// <returns>The product as an AbstractModel.</returns>
    public AbstractModel GetById(int id)
    {
        var product = this.context.Products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            throw new KeyNotFoundException($"Product with ID {id} not found.");
        }

        return new ProductModel(
            product.Id,
            new ProductTitleModel(product.Title.Id, product.Title.Title),
            new ManufacturerModel(product.Manufacturer.Id, product.Manufacturer.Name),
            product.Description,
            product.UnitPrice);
    }

    /// <summary>
    /// Updates an existing product in the database.
    /// </summary>
    /// <param name="model">The updated product model.</param>
    public void Update(AbstractModel model)
    {
        if (model is not ProductModel productModel)
        {
            throw new ArgumentException("Invalid model type. Expected ProductModel.");
        }

        var product = this.context.Products.FirstOrDefault(p => p.Id == productModel.Id);
        if (product == null)
        {
            throw new KeyNotFoundException($"Product with ID {productModel.Id} not found.");
        }

        product.TitleId = productModel.Title.Id;
        product.ManufacturerId = productModel.Manufacturer.Id;
        product.Description = productModel.Description;
        product.UnitPrice = productModel.Price;

        this.context.Products.Update(product);
        this.context.SaveChanges();
    }
}
