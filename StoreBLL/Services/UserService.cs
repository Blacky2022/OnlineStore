namespace StoreBLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreBLL.Interfaces;
using StoreBLL.Models;
using StoreDAL.Data;
using StoreDAL.Entities;
using StoreDAL.Interfaces;

/// <summary>
/// Provides CRUD operations for User entities.
/// </summary>
public class UserService : ICrud
{
    private readonly StoreDbContext context;

    /// <summary>
    /// Initializes a new instance of the <see cref="UserService"/> class.
    /// </summary>
    /// <param name="context">The database context to use.</param>
    public UserService(StoreDbContext context)
    {
        this.context = context ?? throw new ArgumentNullException(nameof(context));
    }

    /// <summary>
    /// Adds a new user.
    /// </summary>
    /// <param name="model">The user model to add.</param>
    public void Add(AbstractModel model)
    {
        if (model is not UserModel userModel)
        {
            throw new ArgumentException("Invalid model type. Expected UserModel.");
        }

        var entity = new User
        {
            Name = userModel.Name,
            LastName = userModel.LastName,
            Login = userModel.Login,
            Password = userModel.Password,
            RoleId = userModel.Role.Id,
        };

        this.context.Users.Add(entity);
        this.context.SaveChanges();
    }

    /// <summary>
    /// Deletes a user by ID.
    /// </summary>
    /// <param name="modelId">The ID of the user to delete.</param>
    public void Delete(int modelId)
    {
        var user = this.context.Users.FirstOrDefault(u => u.Id == modelId) ?? throw new KeyNotFoundException($"User with ID {modelId} not found.");
        this.context.Users.Remove(user);
        this.context.SaveChanges();
    }

    /// <summary>
    /// Gets all users.
    /// </summary>
    /// <returns>A list of all users.</returns>
    public IEnumerable<AbstractModel> GetAll()
    {
        return this.context.Users.Select(u => new UserModel(
            u.Id,
            u.Name,
            u.LastName,
            u.Login,
            u.Password,
            new UserRoleModel(
                u.RoleId,
                this.context.UserRoles.Where(r => r.Id == u.RoleId).Select(r => r.RoleName).FirstOrDefault() ?? "Unknown"))).ToList();
    }

    /// <summary>
    /// Gets a user by ID.
    /// </summary>
    /// <param name="id">The ID of the user.</param>
    /// <returns>The user model.</returns>
    public AbstractModel GetById(int id)
    {
        var user = this.context.Users.FirstOrDefault(u => u.Id == id) ?? throw new KeyNotFoundException($"User with ID {id} not found.");

        return new UserModel(
            user.Id,
            user.Name,
            user.LastName,
            user.Login,
            user.Password,
            new UserRoleModel(
                user.RoleId,
                this.context.UserRoles.Where(r => r.Id == user.RoleId).Select(r => r.RoleName).FirstOrDefault() ?? "Unknown"));
    }

    /// <summary>
    /// Updates an existing user.
    /// </summary>
    /// <param name="model">The updated user model.</param>
    public void Update(AbstractModel model)
    {
        if (model is not UserModel userModel)
        {
            throw new ArgumentException("Invalid model type. Expected UserModel.");
        }

        var user = this.context.Users.FirstOrDefault(u => u.Id == userModel.Id) ?? throw new KeyNotFoundException($"User with ID {userModel.Id} not found.");
        user.Name = userModel.Name;
        user.LastName = userModel.LastName;
        user.Login = userModel.Login;
        user.Password = userModel.Password;
        user.RoleId = userModel.Role.Id;

        this.context.Users.Update(user);
        this.context.SaveChanges();
    }
}
