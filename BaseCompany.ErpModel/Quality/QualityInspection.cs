using CompanyName.ERPNext.Entities.Base;

namespace CompanyName.ERPNext.Entities.Quality;

/// <summary>
/// Represents a quality inspection performed on a product or batch.
/// </summary>
public class QualityInspection : AuditableEntity
{
    public string InspectionType { get; set; }
    public string ReferenceType { get; set; }
    public string ReferenceName { get; set; }
    public string Status { get; set; }
    public DateTimeOffset InspectionDate { get; set; }
    public string InspectedBy { get; set; }
}
