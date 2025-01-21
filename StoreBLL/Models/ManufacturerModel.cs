namespace StoreBLL.Models;
using StoreDAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

/// <summary>
/// Represents a manufacturer model.
/// </summary>
public class ManufacturerModel : AbstractModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ManufacturerModel"/> class.
    /// </summary>
    /// <param name="id">The identifier of the manufacturer.</param>
    /// <param name="name">The name of the manufacturer.</param>
    public ManufacturerModel(int id, string name)
        : base(id)
    {
        this.Name = name;
    }

    /// <summary>
    /// Gets the default Guest role.
    /// </summary>
    public static UserRoleModel GuestRole => new UserRoleModel(0, "Guest");

    /// <summary>
    /// Gets the Registered User role.
    /// </summary>
    public static UserRoleModel RegisteredUserRole => new UserRoleModel(1, "Registered User");

    /// <summary>
    /// Gets the Administrator role.
    /// </summary>
    public static UserRoleModel AdministratorRole => new UserRoleModel(2, "Administrator");

    /// <summary>
    /// Gets or sets the name of the user role.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString()
    {
        return $"Id: {this.Id}, Role: {this.Name}";
    }
}
