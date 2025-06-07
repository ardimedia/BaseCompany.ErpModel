using CompanyName.ERPNext.Entities.Base;

namespace CompanyName.ERPNext.Entities.Assets;

/// <summary>
/// Represents a fixed asset in the organization.
/// </summary>
public class Asset : AuditableEntity
{
    public string AssetName { get; set; }
    public string AssetCategory { get; set; }
    public string SerialNumber { get; set; }
    public decimal PurchaseCost { get; set; }
    public DateTimeOffset PurchaseDate { get; set; }
    public string Status { get; set; }
}
