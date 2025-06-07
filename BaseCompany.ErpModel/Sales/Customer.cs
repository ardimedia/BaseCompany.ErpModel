using BaseCompany.ErpModel.Base;
using BaseCompany.ErpModel.Enums;
using BaseCompany.ErpModel.Sales;
using BaseCompany.ErpModel.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BaseCompany.ErpModel.Sales;

/// <summary>
/// Represents a customer who can place sales orders and receive invoices.
/// Maps to schema.org/Person or schema.org/Organization depending on customer type.
/// </summary>
public class Customer : AuditableEntity
{
    /// <summary>
    /// Gets or sets the customer's name.
    /// Maps to schema.org/name
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
    /// Maps to schema.org/email
    /// </summary>
    [EmailAddress(ErrorMessage = "Please provide a valid email address")]
    [MaxLength(255)]
    public string Email { get; set; }
    
    /// <summary>
    /// Gets or sets the customer's phone number.
    /// Maps to schema.org/telephone
    /// </summary>
    [Phone(ErrorMessage = "Please provide a valid phone number")]
    [MaxLength(20)]
    public string Phone { get; set; }
    
    /// <summary>
    /// Gets or sets the customer's billing address.
    /// Maps to schema.org/billingAddress
    /// </summary>
    [MaxLength(500)]
    public string BillingAddress { get; set; }
    
    /// <summary>
    /// Gets or sets the customer's shipping address.
    /// Maps to schema.org/address
    /// </summary>
    [MaxLength(500)]
    public string ShippingAddress { get; set; }
    
    /// <summary>
    /// Gets or sets the customer's tax ID or VAT number.
    /// Maps to schema.org/taxID or schema.org/vatID
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
    /// Maps to schema.org/paymentDue
    /// </summary>
    [MaxLength(100)]
    public string PaymentTerms { get; set; }
    
    /// <summary>
    /// Gets or sets the customer's website URL.
    /// Maps to schema.org/url
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
    /// Maps to schema.org/orderHistory
    /// </summary>
    public ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();

    /// <summary>
    /// Gets or sets the collection of addresses for the customer.
    /// Maps to schema.org/address
    /// </summary>
    public ICollection<Address> Addresses { get; set; } = new List<Address>();

    /// <summary>
    /// Gets or sets the collection of contact persons for the customer.
    /// Maps to schema.org/contactPoint
    /// </summary>
    public ICollection<ContactPerson> ContactPersons { get; set; } = new List<ContactPerson>();

    /// <summary>
    /// Gets or sets the description of the customer.
    /// Maps to schema.org/description
    /// </summary>
    [MaxLength(1000)]
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the logo URL for organization customers.
    /// Maps to schema.org/logo
    /// </summary>
    [Url]
    [MaxLength(255)]
    public string LogoUrl { get; set; }

    /// <summary>
    /// Gets or sets the founding date for organization customers.
    /// Maps to schema.org/foundingDate
    /// </summary>
    public DateTime? FoundingDate { get; set; }

    /// <summary>
    /// Gets or sets the industry or sector of the customer organization.
    /// Maps to schema.org/industry
    /// </summary>
    [MaxLength(100)]
    public string Industry { get; set; }

    /// <summary>
    /// Gets or sets the number of employees for organization customers.
    /// Maps to schema.org/numberOfEmployees
    /// </summary>
    public int? NumberOfEmployees { get; set; }

    /// <summary>
    /// Gets or sets alternate names or brands of the customer.
    /// Maps to schema.org/alternateName
    /// </summary>
    [MaxLength(255)]
    public string AlternateName { get; set; }

    /// <summary>
    /// Gets or sets the Dun & Bradstreet number for organization customers.
    /// Maps to schema.org/duns
    /// </summary>
    [MaxLength(50)]
    public string DunsNumber { get; set; }

    /// <summary>
    /// Gets or sets the global location number for organization customers.
    /// Maps to schema.org/globalLocationNumber
    /// </summary>
    [MaxLength(50)]
    public string GlobalLocationNumber { get; set; }

    /// <summary>
    /// Gets or sets the customer's fax number.
    /// Maps to schema.org/faxNumber
    /// </summary>
    [MaxLength(20)]
    public string FaxNumber { get; set; }
}
