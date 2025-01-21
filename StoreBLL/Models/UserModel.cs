namespace StoreBLL.Models;

/// <summary>
/// Represents a user in the system.
/// </summary>
public class UserModel : AbstractModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserModel"/> class.
    /// </summary>
    /// <param name="id">The user ID.</param>
    /// <param name="name">The user's name.</param>
    /// <param name="lastName">The user's surname.</param>
    /// <param name="login">The user's login.</param>
    /// <param name="password">The user's password.</param>
    /// <param name="role">The user's role.</param>
    public UserModel(int id, string name, string lastName, string login, string password, UserRoleModel role)
        : base(id)
    {
        this.Name = name;
        this.LastName = lastName;
        this.Login = login;
        this.Password = password;
        this.Role = role;
    }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the user's surname.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Gets or sets the password.
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Gets or sets the login.
    /// </summary>
    public string Login { get; set; }

    /// <summary>
    /// Gets or sets the user's role.
    /// </summary>
    public UserRoleModel Role { get; set; }

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString()
    {
        return $"{this.Name} {this.LastName} ({this.Login})";
    }
}
