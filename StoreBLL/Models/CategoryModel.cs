namespace StoreBLL.Models;
using StoreDAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Represents a category model in the business logic layer.
/// </summary>
public class CategoryModel : AbstractModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CategoryModel"/> class.
    /// </summary>
    /// <param name="id">The identifier of the category model.</param>
    public CategoryModel(int id)
        : base(id)
    {
    }

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString()
    {
        return $"CategoryModel: {this.Id}";
    }
}
