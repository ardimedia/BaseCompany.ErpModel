using CompanyName.ERPNext.Entities.Base;
using CompanyName.ERPNext.Entities.Enums;
using CompanyName.ERPNext.Entities.Sales;
using CompanyName.ERPNext.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompanyName.ERPNext.Entities.Sales;

/// <summary>
/// Represents a customer who can place sales orders and receive invoices.
/// </summary>
public class Customer : AuditableEntity
{
    /// <summary>
    /// Gets or sets the customer's name.
    /// </summary>
    [Required(ErrorMessage = "Customer name is required")]
    [MaxLength(100, ErrorMessage = "Customer name cannot exceed 100 characters")]
    public string CustomerName { get; set; }
    
    /// <summary>
    /// Gets or sets the customer type.
    /// </summary>
    [Required(ErrorMessage = "Customer type is required")]
    public CustomerType CustomerType { get; set; } = CustomerType.Individual;
    
    /// <summary>
    /// Gets or sets the customer's email address.
    /// </summary>
    [EmailAddress(ErrorMessage = "Please provide a valid email address")]
    [MaxLength(255)]
    public string Email { get; set; }
    
    /// <summary>
    /// Gets or sets the customer's phone number.
    /// </summary>
    [Phone(ErrorMessage = "Please provide a valid phone number")]
    [MaxLength(20)]
    public string Phone { get; set; }
    
    /// <summary>
    /// Gets or sets the customer's billing address.
    /// </summary>
    [MaxLength(500)]
    public string BillingAddress { get; set; }
    
    /// <summary>
    /// Gets or sets the customer's shipping address.
    /// </summary>
    [MaxLength(500)]
    public string ShippingAddress { get; set; }
    
    /// <summary>
    /// Gets or sets the customer's tax ID or VAT number.
    /// </summary>
    [MaxLength(50)]
    public string TaxId { get; set; }
    
    /// <summary>
    /// Gets or sets the customer's credit limit.
    /// </summary>
    [Range(0, double.MaxValue, ErrorMessage = "Credit limit must be a positive value")]
    public decimal? CreditLimit { get; set; }
    
    /// <summary>
    /// Gets or sets the payment terms for this customer (e.g., Net 30).
    /// </summary>
    [MaxLength(100)]
    public string PaymentTerms { get; set; }
    
    /// <summary>
    /// Gets or sets the customer's website URL.
    /// </summary>
    [Url(ErrorMessage = "Please provide a valid URL")]
    [MaxLength(255)]
    public string Website { get; set; }
    
    /// <summary>
    /// Gets or sets whether the customer is active.
    /// </summary>
    public bool IsActive { get; set; } = true;
    
    /// <summary>
    /// Gets or sets the collection of sales orders associated with this customer.
    /// </summary>
    public ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();

    /// <summary>
    /// Gets or sets the collection of addresses for the customer.
    /// </summary>
    public ICollection<Address> Addresses { get; set; } = new List<Address>();

    /// <summary>
    /// Gets or sets the collection of contact persons for the customer.
    /// </summary>
    public ICollection<ContactPerson> ContactPersons { get; set; } = new List<ContactPerson>();
}
