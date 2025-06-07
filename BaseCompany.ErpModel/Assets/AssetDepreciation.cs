using BaseCompany.ErpModel.Base;

namespace BaseCompany.ErpModel.Assets;

/// <summary>
/// Represents depreciation applied to an asset.
/// </summary>
public class AssetDepreciation : AuditableEntity
{
    public Guid AssetId { get; set; }
    public Asset Asset { get; set; }
    public DateTimeOffset DepreciationDate { get; set; }
    public decimal Amount { get; set; }
}
