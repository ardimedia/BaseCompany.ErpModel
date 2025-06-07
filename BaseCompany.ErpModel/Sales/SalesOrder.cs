using CompanyName.ERPNext.Entities.Base;
using CompanyName.ERPNext.Entities.Enums;
using CompanyName.ERPNext.Entities.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompanyName.ERPNext.Entities.Sales;

/// <summary>
/// Represents a sales order placed by a customer.
/// </summary>
public class SalesOrder : AuditableEntity
{
    /// <summary>
    /// Gets or sets the unique order number/code for this sales order.
    /// </summary>
    [Required]
    [MaxLength(50)]
    public string OrderNumber { get; set; }
    
    /// <summary>
    /// Gets or sets the customer ID associated with this order.
    /// </summary>
    [Required]
    public Guid CustomerId { get; set; }
    
    /// <summary>
    /// Gets or sets the customer associated with this order.
    /// </summary>
    public Customer Customer { get; set; }
    
    /// <summary>
    /// Gets or sets the date when the order was placed.
    /// </summary>
    [Required]
    public DateTimeOffset OrderDate { get; set; }
    
    /// <summary>
    /// Gets or sets the expected delivery date for this order.
    /// </summary>
    public DateTimeOffset ExpectedDeliveryDate { get; set; }
    
    /// <summary>
    /// Gets or sets the status of the sales order.
    /// </summary>
    [Required]
    public OrderStatus Status { get; set; } = OrderStatus.Draft;
    
    /// <summary>
    /// Gets or sets the total amount of the order.
    /// </summary>
    [Range(0, double.MaxValue, ErrorMessage = "Total amount must be a positive value")]
    public decimal TotalAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the subtotal amount (before tax and discounts).
    /// </summary>
    [Range(0, double.MaxValue)]
    public decimal Subtotal { get; set; }
    
    /// <summary>
    /// Gets or sets the tax amount for this order.
    /// </summary>
    [Range(0, double.MaxValue)]
    public decimal TaxAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the discount amount for this order.
    /// </summary>
    [Range(0, double.MaxValue)]
    public decimal DiscountAmount { get; set; }
    
    /// <summary>
    /// Gets or sets the shipping amount for this order.
    /// </summary>
    [Range(0, double.MaxValue)]
    public decimal ShippingAmount { get; set; }
    
    /// <summary>
    /// Gets or sets any notes or comments related to this order.
    /// </summary>
    [MaxLength(1000)]
    public string Notes { get; set; }
    
    /// <summary>
    /// Gets or sets the reference number provided by the customer.
    /// </summary>
    [MaxLength(100)]
    public string CustomerReference { get; set; }
    
    /// <summary>
    /// Gets or sets the payment terms for this order.
    /// </summary>
    [MaxLength(100)]
    public string PaymentTerms { get; set; }
    
    /// <summary>
    /// Gets or sets the items in this sales order.
    /// </summary>
    public ICollection<SalesOrderItem> Items { get; set; } = new List<SalesOrderItem>();
}
