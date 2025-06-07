using BaseCompany.ErpModel.Base;
using BaseCompany.ErpModel.Inventory;

namespace BaseCompany.ErpModel.Manufacturing;

/// <summary>
/// Represents a Bill of Materials (BOM) for manufacturing a product.
/// </summary>
public class BillOfMaterials : AuditableEntity
{
    public Guid ItemId { get; set; }
    public Item Item { get; set; }
    public string BOMType { get; set; }
    public decimal Quantity { get; set; }
    public string UnitOfMeasure { get; set; }
    public ICollection<BOMItem> Components { get; set; }
}
