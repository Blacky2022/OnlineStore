namespace StoreBLL.Models;

/// <summary>
/// Represents a product model with details such as title, manufacturer, description, and price.
/// </summary>
public class ProductModel : AbstractModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductModel"/> class.
    /// </summary>
    /// <param name="id">The product identifier.</param>
    /// <param name="title">The title of the product.</param>
    /// <param name="manufacturer">The manufacturer of the product.</param>
    /// <param name="description">The description of the product.</param>
    /// <param name="price">The price of the product.</param>
    public ProductModel(int id, ProductTitleModel title, ManufacturerModel manufacturer, string description, decimal price)
        : base(id)
    {
        this.Title = title;
        this.Manufacturer = manufacturer;
        this.Description = description;
        this.Price = price;
    }

    /// <summary>
    /// Gets or sets the title of the product.
    /// </summary>
    public ProductTitleModel Title { get; set; }

    /// <summary>
    /// Gets or sets the manufacturer of the product.
    /// </summary>
    public ManufacturerModel Manufacturer { get; set; }

    /// <summary>
    /// Gets or sets the description of the product.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the price of the product.
    /// </summary>
    public decimal Price { get; set; }
}
