using BaseCompany.ErpModel.Base;
using BaseCompany.ErpModel.Inventory;

namespace BaseCompany.ErpModel.Manufacturing;

/// <summary>
/// Represents a component item in a Bill of Materials.
/// </summary>
public class BOMItem : AuditableEntity
{
    public Guid BillOfMaterialsId { get; set; }
    public BillOfMaterials BillOfMaterials { get; set; }
    public Guid ItemId { get; set; }
    public Item Item { get; set; }
    public decimal Quantity { get; set; }
}
