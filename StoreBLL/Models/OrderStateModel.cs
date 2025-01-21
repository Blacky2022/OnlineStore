namespace StoreBLL.Models;
using System;
using System.Collections.Generic;

/// <summary>
/// Represents the state of an order.
/// </summary>
public class OrderStateModel : AbstractModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OrderStateModel"/> class.
    /// </summary>
    /// <param name="id">The unique identifier of the order state.</param>
    /// <param name="stateName">The name of the order state.</param>
    public OrderStateModel(int id, string stateName)
        : base(id)
    {
        this.StateName = stateName;
    }

    /// <summary>
    /// Gets the order state when a new order is created.
    /// </summary>
    public static OrderStateModel NewOrder => new (0, "New Order");

    /// <summary>
    /// Gets the order state when the order is canceled by the user.
    /// </summary>
    public static OrderStateModel CanceledByUser => new (1, "Canceled by User");

    /// <summary>
    /// Gets the order state when the order is canceled by the administrator.
    /// </summary>
    public static OrderStateModel CancelledByAdministrator => new (2, "Cancelled by administrator");

    /// <summary>
    /// Gets the order state when the order is confirmed.
    /// </summary>
    public static OrderStateModel Confirmed => new (3, "Confirmed");

    /// <summary>
    /// Gets the order state when the order is moved to the delivery company.
    /// </summary>
    public static OrderStateModel MovedToDeliveryCompany => new (4, "Moved to delivery company");

    /// <summary>
    /// Gets the order state when the order is in delivery.
    /// </summary>
    public static OrderStateModel InDelivery => new (5, "In delivery");

    /// <summary>
    /// Gets the order state when the order is delivered to the client.
    /// </summary>
    public static OrderStateModel Delivered => new (6, "Delivered to client");

    /// <summary>
    /// Gets the order state when the order is in progress.
    /// </summary>
    public static OrderStateModel InProgress => new (7, "In delivery");

    /// <summary>
    /// Gets the order state when delivery is confirmed by the client.
    /// </summary>
    public static OrderStateModel DeliveryConfirmedByClient => new (8, "Delivery confirmed by client");

    /// <summary>
    /// Gets or sets the name of the order state.
    /// </summary>
    public string StateName { get; set; }

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString()
    {
        return $"Id:{this.Id}, State: {this.StateName}";
    }
}
