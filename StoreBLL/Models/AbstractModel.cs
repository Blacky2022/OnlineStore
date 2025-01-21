namespace StoreBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents an abstract model with an identifier.
/// </summary>
public abstract class AbstractModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AbstractModel"/> class.
    /// </summary>
    /// <param name="id">The identifier of the model.</param>
    public AbstractModel(int id)
    {
        this.Id = id;
    }

    /// <summary>
    /// Gets or sets the identifier of the model.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString()
    {
        return $"Id: {this.Id}";
    }
}
