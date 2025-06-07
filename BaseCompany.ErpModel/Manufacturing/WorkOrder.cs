using BaseCompany.ErpModel.Base;
using BaseCompany.ErpModel.Manufacturing;
using BaseCompany.ErpModel.Inventory;

namespace BaseCompany.ErpModel.Manufacturing;

/// <summary>
/// Represents a work order to manufacture a product.
/// </summary>
public class WorkOrder : AuditableEntity
{
    public Guid BillOfMaterialsId { get; set; }
    public BillOfMaterials BillOfMaterials { get; set; }
    public DateTime PlannedStartDate { get; set; }
    public DateTime? ActualStartDate { get; set; }
    public DateTime? ActualEndDate { get; set; }
    public decimal QuantityToProduce { get; set; }
    public string Status { get; set; }
}
