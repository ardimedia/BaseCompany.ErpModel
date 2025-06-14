using BaseCompany.ErpModel.Base;
using BaseCompany.ErpModel.Inventory;

namespace BaseCompany.ErpModel.Purchase;

/// <summary>
/// Represents an item within a purchase order.
/// </summary>
public class PurchaseOrderItem : AuditableEntity
{
    public Guid PurchaseOrderId { get; set; }
    public PurchaseOrder PurchaseOrder { get; set; }
    public Guid ItemId { get; set; }
    public Item Item { get; set; }
    public decimal Quantity { get; set; }
    public decimal Rate { get; set; }
    public decimal Amount { get; set; }
}
