using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



public class Customer
{
    public int CustomerId { get; set; }
    [Required]
    [MaxLength(30)]
    public string Name { get; set; }
    [Required]
    [MaxLength(12)]
    public string Phone { get; set; }
    [Required]
    public string Email { get; set; }

    public string Address{ get; set; }

    public virtual List<Order> Orders { get; set; }
    public Customer()
    {
        Orders = new List<Order>();
    }
}

public class Order
{
    public int OrderId { get; set; }

    public DateTime PurchaseDate { get; set; }

    public Customer Customer { get; set; }
    //public virtual List<Product> Products { get; set; }

    //public Order()
    //{
    //    Products = new List<Product>();
    //}

    public double OrderTotalPrice { get; set; }
}

public class Product
{
    public int ProductId { get; set; }
    [Required]
    [MaxLength(30)]
    public string Vendor { get; set; }
    [Required]
    [MaxLength(30)]
    public string Brand { get; set; }
    [Required]
    [MaxLength(15)]
    public string PartNumber { get; set; }
    [Required]
    public string ProductName { get; set; }
    [Required]
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    public int? QuantityInOrder { get; set; }

}

public class ProductsInOrder
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LineNumberId { get; set; }
    public int OrderId { get; set; }
    [ForeignKey("OrderId")]
    public Order Order { get; set; }
    public string Vendor { get; set; }
    public string Brand { get; set; }
    public string PartNumber { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int QuantityInOrder { get; set; }
    public double TotalPrice { get; set; }

}

//public class OrdersView
//{
//    public int OrderId { get; private set; }

//    public string CustomerName { get; private set; }
//    public DateTime PurchaseDate { get; private set; }
//    public double OrderTotalPrice { get; private set; }
//}


