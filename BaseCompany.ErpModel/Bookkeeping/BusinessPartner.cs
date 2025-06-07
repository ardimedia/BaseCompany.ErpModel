using BaseCompany.ErpModel.Base;

namespace BaseCompany.ErpModel.Bookkeeping;

/// <summary>
/// Represents a party in a financial transaction (customer, vendor, etc.).
/// </summary>
public class BusinessPartner : AuditableEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public PartnerType Type { get; set; }
    public Guid? CustomerId { get; set; }
    public Guid? SupplierId { get; set; }
    public Guid? EmployeeId { get; set; }
}
