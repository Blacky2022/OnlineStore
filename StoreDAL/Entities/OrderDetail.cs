namespace StoreDAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("customer_order_details")]
public class OrderDetail : BaseEntity
{
    private int v1;
    private int v2;
    private int v3;

    public OrderDetail()
        : base()
    {
    }

    public OrderDetail(int id, int v1, int v2, int v3) : base(id)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
    }

    public OrderDetail(int id, int orderId, int productId, decimal price, int amount)
        : base(id)
    {
        this.OrderId = orderId;
        this.ProductId = productId;
        this.Price = price;
        this.ProductAmount = amount;
    }

    [ForeignKey(nameof(Order))]
    [Column("customer_order_id")]
    public int OrderId { get; set; }

    [ForeignKey(nameof(Product))]
    [Column("product_id")]
    public int ProductId { get; set; }

    [Column("price")]
    public decimal Price { get; set; }

    [Column("product_amount")]
    public int ProductAmount { get; set; }

    public CustomerOrder Order { get; set; }

    public Product Product { get; set; }
}
