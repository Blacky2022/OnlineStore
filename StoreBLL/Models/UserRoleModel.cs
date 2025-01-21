namespace StoreBLL.Models;
using System;
using System.Collections.Generic;

/// <summary>
/// Represents a user role model.
/// </summary>
public class UserRoleModel : AbstractModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserRoleModel"/> class.
    /// </summary>
    /// <param name="id">The unique identifier of the user role.</param>
    /// <param name="roleName">The name of the user role.</param>
    public UserRoleModel(int id, string roleName)
        : base(id)
    {
        this.RoleName = roleName;
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
    public string RoleName { get; set; }

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString()
    {
        return $"Id:{this.Id}, Role:  {this.RoleName}";
    }
}
