namespace StoreBLL.Models;

/// <summary>
/// Represents a product title model.
/// </summary>
public class ProductTitleModel : AbstractModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductTitleModel"/> class.
    /// </summary>
    /// <param name="id">The product ID.</param>
    /// <param name="name">The product name.</param>
    public ProductTitleModel(int id, string name)
        : base(id)
    {
        this.Name = name;
    }

    /// <summary>
    /// Gets or sets the product name.
    /// </summary>
    public string Name { get; set; }
}
