using BaseCompany.ErpModel.Base;
using BaseCompany.ErpModel.Purchase;
using BaseCompany.ErpModel.Common;
using System.Collections.Generic;

namespace BaseCompany.ErpModel.Purchase;

/// <summary>
/// Represents a supplier entity that provides goods or services.
/// </summary>
public class Supplier : AuditableEntity
{
    /// <summary>
    /// Gets or sets the supplier's name.
    /// </summary>
    public string SupplierName { get; set; }

    /// <summary>
    /// Gets or sets the supplier type (e.g., Company, Individual).
    /// </summary>
    public string SupplierType { get; set; }

    /// <summary>
    /// Gets or sets the supplier's email address.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the supplier's phone number.
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// Gets or sets the address ID for the supplier.
    /// </summary>
    public string Address { get; set; } // For backward compatibility

    /// <summary>
    /// Gets or sets the collection of addresses for the supplier.
    /// </summary>
    public ICollection<Address> Addresses { get; set; } = new List<Address>();

    /// <summary>
    /// Gets or sets the collection of contact persons for the supplier.
    /// </summary>
    public ICollection<ContactPerson> ContactPersons { get; set; } = new List<ContactPerson>();

    /// <summary>
    /// Gets or sets the collection of purchase orders for the supplier.
    /// </summary>
    public ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();
}
