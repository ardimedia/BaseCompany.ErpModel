using CompanyName.ERPNext.Entities.Base;
using CompanyName.ERPNext.Entities.Purchase;
using CompanyName.ERPNext.Entities.Sales;

namespace CompanyName.ERPNext.Entities.Purchase;

/// <summary>
/// Represents a purchase order issued to a supplier.
/// </summary>
public class PurchaseOrder : AuditableEntity
{
    public Guid SupplierId { get; set; }
    public Supplier Supplier { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime ExpectedDeliveryDate { get; set; }
    public string Status { get; set; }
    public decimal TotalAmount { get; set; }
    public ICollection<PurchaseOrderItem> Items { get; set; }
}
